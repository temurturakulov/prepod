using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Повышение_квалификации
{
    public partial class МенюМетодиста : Form
    {
        ВыборПользователя ВыборПользователя = null;

        public МенюМетодиста(ВыборПользователя выборПользователя)
        {
            ВыборПользователя = выборПользователя;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ВыборПользователя.Show();
            this.Hide();
        }

        private void МенюМетодиста_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "курсы_ОбученяDataSet.Курсы". При необходимости она может быть перемещена или удалена.
            this.курсыTableAdapter.Fill(this.курсы_ОбученяDataSet.Курсы);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.курсыTableAdapter.FillBy(this.курсы_ОбученяDataSet.Курсы);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}

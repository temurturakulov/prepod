using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Повышение_квалификации.Data;

namespace Повышение_квалификации
{
    public partial class МенюМетодиста : Form
    {
        ВыборПользователя ВыборПользователя = null;
        private User _user = null;

        public МенюМетодиста(ВыборПользователя выборПользователя, User user)
        {
            _user = user;
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "silverHa.ФормаОбучения". При необходимости она может быть перемещена или удалена.
            this.формаОбученияTableAdapter.Fill(this.silverHa.ФормаОбучения);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "silverHa.ВидКурса". При необходимости она может быть перемещена или удалена.
            this.видКурсаTableAdapter.Fill(this.silverHa.ВидКурса);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "silverHa.Курсы". При необходимости она может быть перемещена или удалена.
            this.курсыTableAdapter.Fill(this.silverHa.Курсы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "курсы_ОбученяDataSet.Курсы". При необходимости она может быть перемещена или удалена.

         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
               // this.курсыTableAdapter1.FillBy(this.);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DbWorker dbWorker = new DbWorker();

            object value = educationFormList.SelectedItem;

            int coursTypeId = Convert.ToInt32(coursTypeList.SelectedValue.ToString());
            int coursFormId = Convert.ToInt32(educationFormList.SelectedValue.ToString());


            dbWorker.AddCours(textBox1.Text,coursTypeId,Convert.ToInt32(textBox2.Text), coursFormId);
            this.курсыTableAdapter.Fill(this.silverHa.Курсы);
        }

    }
}

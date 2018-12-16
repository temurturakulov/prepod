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
    public partial class Выбор_курсов : Form
    {
        private User _user = null;

        public Выбор_курсов(User user)
        {
            _user = user;
            this.dataGridView1.MultiSelect = true;
            InitializeComponent();
        }

        private void Выбор_курсов_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "silverHa.Курсы". При необходимости она может быть перемещена или удалена.
            this.курсыTableAdapter.Fill(this.silverHa.Курсы);

        }

        private void button2_Click(object sender, EventArgs e)
        {
          DataGridViewSelectedRowCollection row =  dataGridView1.SelectedRows;            
          //row.
        }
    }
}

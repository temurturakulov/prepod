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
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DbWorker dbWorker = new DbWorker();

            int role = 0;

            if (radioButton1.Checked)
            {
                role = (int)DbWorker.Roles.Metodist;
            }

            if (radioButton2.Checked)
            {
                role = (int)DbWorker.Roles.Kadrovik;
            }


            dbWorker.RegisterUser(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, dateTimePicker1.Value, role);

            textBox1.Clear(); 
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

            MessageBox.Show("Запись добавлена");
        }
    }
}

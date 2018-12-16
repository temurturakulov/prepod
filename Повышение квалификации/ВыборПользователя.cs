using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Повышение_квалификации
{
    public partial class ВыборПользователя : Form
    {
        Form1 main = null;
        DbWorker dbWorker = new DbWorker();

        public ВыборПользователя(Form1 form1)
        {
            main = form1;
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {

            if (dbWorker.IsExactUser(textBox3.Text, textBox4.Text, (int)DbWorker.Roles.Admin))
            {
                МенюАдминистратора менюАдминистратора = new МенюАдминистратора();
                менюАдминистратора.Show();
                this.Hide();
                return;
            }

            if (dbWorker.IsExactUser(textBox3.Text, textBox4.Text, (int)DbWorker.Roles.Teacher))
            {
                МенюПреподавателя менюПреподавателя = new МенюПреподавателя(this);
                менюПреподавателя.Show();
                this.Hide();
                return;
            }

            if (dbWorker.IsExactUser(textBox3.Text, textBox4.Text, (int)DbWorker.Roles.Metodist))
            {
                МенюМетодиста менюМетодиста = new МенюМетодиста(this);
                менюМетодиста.Show();
                this.Hide();
                return;

            }
            if (dbWorker.IsExactUser(textBox3.Text, textBox4.Text, (int)DbWorker.Roles.Kadrovik))
            {
                МенюКадровика менюКадровика = new МенюКадровика(this);
                менюКадровика.Show();
                this.Hide();
                return;
            }

            MessageBox.Show("Пользователь не найден!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main.Show();
            this.Hide();
        }

        private void ВыборПользователя_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void ВыборПользователя_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Register(object sender, EventArgs e)
        {
            string id = dbWorker.GetAuthtorizationId(textBox6.Text);
            
            if (id == null || id?.Length < 0)
            {
                int rows = dbWorker.RegisterUser(textBox6.Text, textBox5.Text, textBox1.Text, textBox2.Text, textBox7.Text, dateTimePicker1.Value, (int)DbWorker.Roles.Teacher);
            }
            else
            {
                MessageBox.Show("Логин занят другим пользователем");
            }
        }
    }
}

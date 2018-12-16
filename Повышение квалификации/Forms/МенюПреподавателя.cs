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
    public partial class МенюПреподавателя : Form
    {
        ВыборПользователя Пользователя = null;
        private User _user = null;

        public МенюПреподавателя(ВыборПользователя выборПользователя, User user)
        {
            _user = user;
            Пользователя = выборПользователя;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ПросмотКурсов просмотКурсов = new ПросмотКурсов();
            просмотКурсов.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Выбор_курсов выбор_Курсов = new Выбор_курсов(_user);
            выбор_Курсов.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Пользователя.Show();
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Повышение_квалификации
{
    public partial class UpdateUser : Form
    {
        public static string connectString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\повышение квалиф-ии\Повышение квалификации\Повышение квалификации\bin\Debug\повышение квалиф.mdb";
        public string CmdText = "SELECT * FROM [Авторизация]";
        public UpdateUser()
        {
            
            InitializeComponent();
            //OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CmdText, connectString);
            //// создаем объект DataSet
            //DataSet ds = new DataSet();
            //// заполняем таблицу Order  
            //// данными из базы данных
            //dataAdapter.Fill(ds, "[Авторизация]");
            //dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateUser_Load(object sender, EventArgs e)
        {

        }
    }
}

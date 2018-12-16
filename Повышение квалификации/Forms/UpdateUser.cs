using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "silverHa.Авторизация". При необходимости она может быть перемещена или удалена.
            this.авторизацияTableAdapter.Fill(this.silverHa.Авторизация);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "silverHa.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this.silverHa.Пользователи);

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void AvtorizationChangeEvent(object sender, DataGridViewCellEventArgs e)
        {
            DbWorker dbWorker = new DbWorker();
            SqlConnection connection = dbWorker.GetConnection();
            SqlCommand command = new SqlCommand();
            string queryComand = @" update Авторизация
                                      set login='{0}', password = '{1}' 
                                      where id = {2};";
            if (e.RowIndex >= 0)
            {
                queryComand = string.Format(queryComand,
                                        dataGridView1[1, e.RowIndex].Value.ToString(),
                                        dataGridView1[2, e.RowIndex].Value.ToString(),
                                        dataGridView1[0, e.RowIndex].Value.ToString());
                command.CommandText = queryComand;
                connection.Open();
                command.Connection = connection; 
                command.ExecuteNonQuery();
                connection.Close();
            }
            
        }

        private void UserChangeEvent(object sender, DataGridViewCellEventArgs e)
        {
            DbWorker dbWorker = new DbWorker();
            SqlConnection connection = dbWorker.GetConnection();
            SqlCommand command = new SqlCommand();
            string queryComand = @"  update  Пользователи
                                      set firstName= N'{0}', 
		                                    midleName = N'{1}', 
		                                    lastName = N'{2}', 
		                                    dateOfBirth= '{3}',
		                                    authId = {4},
		                                    roleId= {5}
                                      where id = {6};";
            if (e.RowIndex >= 0)
            {
                queryComand = string.Format(queryComand,
                                        dataGridView2[1, e.RowIndex].Value.ToString(),
                                        dataGridView2[2, e.RowIndex].Value.ToString(),
                                        dataGridView2[3, e.RowIndex].Value.ToString(),
                                        dataGridView2[4, e.RowIndex].Value.ToString(),
                                        dataGridView2[5, e.RowIndex].Value.ToString(),
                                        dataGridView2[6, e.RowIndex].Value.ToString(),
                                        dataGridView2[0, e.RowIndex].Value.ToString());
                command.CommandText = queryComand;
                connection.Open();
                command.Connection = connection;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void RemoveUserEvent(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            DbWorker dbWorker = new DbWorker();
            SqlConnection connection = dbWorker.GetConnection();
            SqlCommand command = new SqlCommand();
            string queryComand = @"  delete from  Пользователи
                                      where id = {0};";
            if (e.RowIndex >= 0)
            {
                queryComand = string.Format(queryComand,
                                        dataGridView2[0, e.RowIndex+1].Value.ToString());
                command.CommandText = queryComand;
                connection.Open();
                command.Connection = connection;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void AuthDataRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            DbWorker dbWorker = new DbWorker();
            SqlConnection connection = dbWorker.GetConnection();
            SqlCommand command = new SqlCommand();
            string queryComand = @"  delete from  Авторизация
                                      where id = {0};";
            if (e.RowIndex >= 0)
            {
                queryComand = string.Format(queryComand,
                                        dataGridView2[0, e.RowIndex + 1].Value.ToString());
                command.CommandText = queryComand;
                connection.Open();
                command.Connection = connection;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}

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
    public partial class DeleteUser : Form
    {
                
        public DeleteUser()
        {
            
            InitializeComponent();
            FillAuthorization();
        }
        private void FillAuthorization()
        {
            try
            {
                this.авторизацияTableAdapter.FillBy(this.повышение_квалифDataSet.Авторизация);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.авторизацияTableAdapter.FillBy(this.повышение_квалифDataSet.Авторизация);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

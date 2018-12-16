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
    public partial class СформироватьОтчет : Form
    {
        public СформироватьОтчет()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Templater templater = new Templater();
            templater.Maketemplate("\\Documents\\справка.docx");
            MessageBox.Show("Справка сформирована!");
        }
    }
}

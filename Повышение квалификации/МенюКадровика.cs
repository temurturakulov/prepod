﻿using System;
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
    public partial class МенюКадровика : Form
    {
        ВыборПользователя Выбор = null;
        public МенюКадровика(ВыборПользователя выбор)
        {
            Выбор = выбор;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ОдобритьКурс одобритьКурс = new ОдобритьКурс();
            одобритьКурс.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            СформироватьОтчет сформироватьОтчет = new СформироватьОтчет();
            сформироватьОтчет.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Выбор.Show();
            this.Hide();
        }
    }
}

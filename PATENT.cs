using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp123
{
    public partial class PATENT : Form
    {
        public PATENT()
        {
            InitializeComponent();
        }

        private void PATENT_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            filmler menü2 = new filmler();
            menü2.Show();
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp123
{
    public partial class filmler : Form
    {
        public filmler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            biletA bilet3 = new biletA();
            bilet3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            biletA bilet4 = new biletA();
            bilet4.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            biletA bilet5 = new biletA();
            bilet5.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            biletA bilet6 = new biletA();
            bilet6.Show();
            this.Hide();
        }

        private void aNASAYFAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void iNSTAGRAMToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult geçiş1 = new DialogResult();
            geçiş1 = MessageBox.Show("İNSTAGRAMA YÖNLENDİRİLİYORSUNUZ", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (geçiş1 == DialogResult.OK)
            {
                Process.Start("https://www.instagram.com/pembekosksinemalari/");
            }
            else
            {
                filmler film5 = new filmler();
                film5.Show();
                this.Hide();
            }
        }

        private void bÜTÜNFİLMLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BÜTÜNF bütün1 = new BÜTÜNF();
            bütün1.Show();
            this.Hide();
        }

        private void vZYONDAOLANLARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filmler vizyon1 = new filmler();
            vizyon1.Show();
            this.Hide();
        }

        private void mARKAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://tr.wikipedia.org/wiki/Pembe_K%C3%B6%C5%9Fk_(%C4%B0smet_%C4%B0n%C3%B6n%C3%BC_Evi)");
        }

        private void tÜMHAKLARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TÜM VERİLERİNİZ SAKLANMAKTADIR");
            PATENT hak1 = new PATENT();
            hak1.Show();
            this.Hide();
        }

        private void iLETİŞİMToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void bÜFE1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HOŞGELDİNİZ...","BÜFEMİZE HOŞGELDİNİZ...");
            büfe büfe1 = new büfe();
            büfe1.Show();
            this.Hide();

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp123
{
    public partial class biletA : Form
    {
        public biletA()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {        
            int bakıye = 150;
            if (checkBox1.Checked)
            {
                label4.Text = "1-ÖGRENCİ(15TL)";
                bakıye -= 15;       
                DialogResult tepki1 = new DialogResult();
                tepki1 = MessageBox.Show("REZERVASYON OLUŞTURULDU", "SATIN ALMA İŞLEMİ TAMAMLANDI", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                
                if (tepki1 == DialogResult.OK)
                {
                    MessageBox.Show("LÜTFEN KOLTUK SEÇİMİ YAPINIZ");
                    SEÇİC SEÇME1 = new SEÇİC();
                    SEÇME1.Show();
                    this.Hide();
                }
                if (tepki1 == DialogResult.Cancel)
                {
                    biletA bilet = new biletA();
                    bilet.Show();
                    this.Hide();
                }

            }
            if (checkBox2.Checked)
            {

                bakıye -= 27;
                label4.Text = "2-3 SAATLİK ÖGRENCİ(27.5 TL)";
                DialogResult tepki2 = new DialogResult();
                tepki2 = MessageBox.Show("REZERVASYON OLUŞTURULDU", "SATIN ALMA İŞLEMİ TAMAMLANDI", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                
                if (tepki2 == DialogResult.OK)
                {
                    MessageBox.Show("LÜTFEN KOLTUK SEÇİMİ YAPINIZ");
                    SEÇİC SEÇME1 = new SEÇİC();
                    SEÇME1.Show();
                    this.Hide();
                }
                if (tepki2 == DialogResult.Cancel)
                {
                    biletA bilet = new biletA();
                    bilet.Show();
                    this.Hide();
                }
            }
            if (checkBox5.Checked)
            {
                if (checkBox3.Checked)
                {

                    bakıye -= 20;
                    label4.Text = "1-2 SAATLİK YETİŞKİN (20 TL)";
                    DialogResult tepki3 = new DialogResult();
                    tepki3 = MessageBox.Show("REZERVASYON OLUŞTURULDU", "SATIN ALMA İŞLEMİ TAMAMLANDI", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    
                    if (tepki3 == DialogResult.OK)
                    {
                        MessageBox.Show("LÜTFEN KOLTUK SEÇİMİ YAPINIZ");
                        SEÇİC SEÇME1 = new SEÇİC();
                        SEÇME1.Show();
                        this.Hide();
                    }
                    if (tepki3 == DialogResult.Cancel)
                    {
                        biletA bilet = new biletA();
                        bilet.Show();
                        this.Hide();
                    }
                }
                if (checkBox4.Checked)
                {
                    bakıye -= 35;
                    label4.Text = "2-3 SAATLİK YETİŞKİN (35 TL)";
                    DialogResult tepki4 = new DialogResult();
                    tepki4 = MessageBox.Show("REZERVASYON OLUŞTURULDU", "SATIN ALMA İŞLEMİ TAMAMLANDI", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    if (tepki4 == DialogResult.OK)
                    {
                        MessageBox.Show("LÜTFEN KOLTUK SEÇİMİ YAPINIZ");
                        SEÇİC SEÇME1 = new SEÇİC();
                        SEÇME1.Show();
                        this.Hide();
                    }
                    if (tepki4 == DialogResult.Cancel)
                    {
                        biletA bilet = new biletA();
                        bilet.Show();
                        this.Hide();
                    }
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            filmler filmg = new filmler();
            filmg.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            büfe büfe2 = new büfe();
            büfe2.Show();
            this.Hide();
        }
    }
}

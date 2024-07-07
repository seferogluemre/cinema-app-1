using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp123
{
    public partial class SEÇİC : Form
    {
        public SEÇİC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            DialogResult tepki1 = new DialogResult();
            tepki1 = MessageBox.Show("BU KOLTUGU SEÇMEK İSTEDİGİNZE EMİN MİSİNİZ", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Random random = new Random();
            int hour = random.Next(0, 24);
            int minute = random.Next(0, 60);
            int second = random.Next(0, 60);
            DateTime randomTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hour, minute, second);
            MessageBox.Show("KAYDINIZ ŞU SAATE YAPILMIŞTIR :" + randomTime);
            

            if (tepki1 == DialogResult.OK)
            {
                MessageBox.Show("KAYDINIZ YAPILDI İYİ EGLENCELER DİLERİZ (:");
                pictureBox1.Visible = false;
                label1.Text = "DOLU";

                _1fılm film1ızle = new _1fılm();
                film1ızle.Show();
                this.Hide();

            }
            else
            {
                SEÇİC seçme1 = new SEÇİC();
                seçme1.Show();
                this.Hide();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult tepki1 = new DialogResult();
            tepki1 = MessageBox.Show("BU KOLTUGU SEÇMEK İSTEDİGİNZE EMİN MİSİNİZ", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Random random = new Random();
            int hour = random.Next(0, 24);
            int minute = random.Next(0, 60);
            int second = random.Next(0, 60);
            DateTime randomTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hour, minute, second);
            MessageBox.Show("KAYDINIZ ŞU SAATE YAPILMIŞTIR :" + randomTime);
            if (tepki1 == DialogResult.OK)
            {
                MessageBox.Show("KAYDINIZ YAPILDI İYİ EGLENCELER DİLERİZ (:");
                pictureBox2.Visible = false;
                label2.Text = "DOLU";

                _fılm2 film2 = new _fılm2();
                film2.Show();
                this.Hide();
            }
            else
            {
                SEÇİC seçme1 = new SEÇİC();
                seçme1.Show();
                this.Hide();

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult tepki1 = new DialogResult();
            tepki1 = MessageBox.Show("BU KOLTUGU SEÇMEK İSTEDİGİNZE EMİN MİSİNİZ", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Random random = new Random();
            int hour = random.Next(0, 24);
            int minute = random.Next(0, 60);
            int second = random.Next(0, 60);
            DateTime randomTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hour, minute, second);
            MessageBox.Show("KAYDINIZ ŞU SAATE YAPILMIŞTIR :" + randomTime);
            if (tepki1 == DialogResult.OK)
            {
                MessageBox.Show("KAYDINIZ YAPILDI İYİ EGLENCELER DİLERİZ (:");
                pictureBox3.Visible = false;
                label3.Text = "DOLU";
            }
            else
            {
                SEÇİC seçme1 = new SEÇİC();
                seçme1.Show();
                this.Hide();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult tepki1 = new DialogResult();
            tepki1 = MessageBox.Show("BU KOLTUGU SEÇMEK İSTEDİGİNZE EMİN MİSİNİZ", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Random random = new Random();
            int hour = random.Next(0, 24);
            int minute = random.Next(0, 60);
            int second = random.Next(0, 60);
            DateTime randomTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hour, minute, second);
            MessageBox.Show("KAYDINIZ ŞU SAATE YAPILMIŞTIR :" + randomTime);
            if (tepki1 == DialogResult.OK)
            {
                MessageBox.Show("KAYDINIZ YAPILDI İYİ EGLENCELER DİLERİZ (:");
                pictureBox4.Visible = false;
                label4.Text = "DOLU";
            }
            else
            {
                SEÇİC seçme1 = new SEÇİC();
                seçme1.Show();
                this.Hide();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult tepki1 = new DialogResult();
            tepki1 = MessageBox.Show("BU KOLTUGU SEÇMEK İSTEDİGİNZE EMİN MİSİNİZ", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Random random = new Random();
            int hour = random.Next(0, 24);
            int minute = random.Next(0, 60);
            int second = random.Next(0, 60);
            DateTime randomTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hour, minute, second);
            MessageBox.Show("KAYDINIZ ŞU SAATE YAPILMIŞTIR :" + randomTime);
            if (tepki1 == DialogResult.OK)
            {
                MessageBox.Show("KAYDINIZ YAPILDI İYİ EGLENCELER DİLERİZ (:");
                pictureBox5.Visible = false;
                label5.Text = "DOLU";
            }
            else
            {
                SEÇİC seçme1 = new SEÇİC();
                seçme1.Show();
                this.Hide();

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult tepki1 = new DialogResult();
            tepki1 = MessageBox.Show("BU KOLTUGU SEÇMEK İSTEDİGİNZE EMİN MİSİNİZ", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Random random = new Random();
            int hour = random.Next(0, 24);
            int minute = random.Next(0, 60);
            int second = random.Next(0, 60);
            DateTime randomTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hour, minute, second);
            MessageBox.Show("KAYDINIZ ŞU SAATE YAPILMIŞTIR :" + randomTime);
            if (tepki1 == DialogResult.OK)
            {
                MessageBox.Show("KAYDINIZ YAPILDI İYİ EGLENCELER DİLERİZ (:");
                pictureBox6.Visible = false;
                label6.Text = "DOLU";
            }
            else
            {
                SEÇİC seçme1 = new SEÇİC();
                seçme1.Show();
                this.Hide();

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult tepki1 = new DialogResult();
            tepki1 = MessageBox.Show("BU KOLTUGU SEÇMEK İSTEDİGİNZE EMİN MİSİNİZ", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Random random = new Random();
            int hour = random.Next(0, 24);
            int minute = random.Next(0, 60);
            int second = random.Next(0, 60);
            DateTime randomTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hour, minute, second);
            MessageBox.Show("KAYDINIZ ŞU SAATE YAPILMIŞTIR :" + randomTime);
            if (tepki1 == DialogResult.OK)
            {
                MessageBox.Show("KAYDINIZ YAPILDI İYİ EGLENCELER DİLERİZ (:");
                pictureBox7.Visible = false;
                label7.Text = "DOLU";
            }
            else
            {
                SEÇİC seçme1 = new SEÇİC();
                seçme1.Show();
                this.Hide();

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult tepki1 = new DialogResult();
            tepki1 = MessageBox.Show("BU KOLTUGU SEÇMEK İSTEDİGİNZE EMİN MİSİNİZ", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Random random = new Random();
            int hour = random.Next(0, 24);
            int minute = random.Next(0, 60);
            int second = random.Next(0, 60);
            DateTime randomTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hour, minute, second);
            MessageBox.Show("KAYDINIZ ŞU SAATE YAPILMIŞTIR :" + randomTime);
            if (tepki1 == DialogResult.OK)
            {
                MessageBox.Show("KAYDINIZ YAPILDI İYİ EGLENCELER DİLERİZ (:");
                pictureBox8.Visible = false;
                label8.Text = "DOLU";
            }
            else
            {
                SEÇİC seçme1 = new SEÇİC();
                seçme1.Show();
                this.Hide();

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            _1fılm fılmm2 = new _1fılm();
            fılmm2.Show();
            this.Hide();

            DialogResult tepki1 = new DialogResult();
            tepki1 = MessageBox.Show("BU KOLTUGU SEÇMEK İSTEDİGİNZE EMİN MİSİNİZ", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Random random = new Random();
            int hour = random.Next(0, 24);
            int minute = random.Next(0, 60);
            int second = random.Next(0, 60);
            DateTime randomTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hour, minute, second);
            MessageBox.Show("KAYDINIZ ŞU SAATE YAPILMIŞTIR :" + randomTime);
            if (tepki1 == DialogResult.OK)
            {
                MessageBox.Show("KAYDINIZ YAPILDI İYİ EGLENCELER DİLERİZ (:");
                pictureBox9.Visible = false;
                label9.Text = "DOLU";
            }
            else
            {
                SEÇİC seçme1 = new SEÇİC();
                seçme1.Show();
                this.Hide();

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DialogResult tepki1 = new DialogResult();
            tepki1 = MessageBox.Show("BU KOLTUGU SEÇMEK İSTEDİGİNZE EMİN MİSİNİZ", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Random random = new Random();
            int hour = random.Next(0, 24);
            int minute = random.Next(0, 60);
            int second = random.Next(0, 60);
            DateTime randomTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hour, minute, second);
            MessageBox.Show("KAYDINIZ ŞU SAATE YAPILMIŞTIR :" + randomTime);
            if (tepki1 == DialogResult.OK)
            {
                MessageBox.Show("KAYDINIZ YAPILDI İYİ EGLENCELER DİLERİZ (:");
                pictureBox10.Visible = false;
                label10.Text = "DOLU";
            }
            else
            {
                SEÇİC seçme1 = new SEÇİC();
                seçme1.Show();
                this.Hide();

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DialogResult tepki1 = new DialogResult();
            tepki1 = MessageBox.Show("BU KOLTUGU SEÇMEK İSTEDİGİNZE EMİN MİSİNİZ", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Random random = new Random();
            int hour = random.Next(0, 24);
            int minute = random.Next(0, 60);
            int second = random.Next(0, 60);
            DateTime randomTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hour, minute, second);
            MessageBox.Show("KAYDINIZ ŞU SAATE YAPILMIŞTIR :" + randomTime);
            if (tepki1 == DialogResult.OK)
            {
                MessageBox.Show("KAYDINIZ YAPILDI İYİ EGLENCELER DİLERİZ (:");
                pictureBox11.Visible = false;
                label11.Text = "DOLU";
            }
            else
            {
                SEÇİC seçme1 = new SEÇİC();
                seçme1.Show();
                this.Hide();

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DialogResult tepki1 = new DialogResult();
            tepki1 = MessageBox.Show("BU KOLTUGU SEÇMEK İSTEDİGİNZE EMİN MİSİNİZ", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Random random = new Random();
            int hour = random.Next(0, 24);
            int minute = random.Next(0, 60);
            int second = random.Next(0, 60);
            DateTime randomTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hour, minute, second);
            MessageBox.Show("KAYDINIZ ŞU SAATE YAPILMIŞTIR :" + randomTime);
            if (tepki1 == DialogResult.OK)
            {
                MessageBox.Show("KAYDINIZ YAPILDI İYİ EGLENCELER DİLERİZ (:");
                pictureBox13.Visible = false;
                label13.Text = "DOLU";
            }
            else
            {
                SEÇİC seçme1 = new SEÇİC();
                seçme1.Show();
                this.Hide();

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DialogResult tepki1 = new DialogResult();
            tepki1 = MessageBox.Show("BU KOLTUGU SEÇMEK İSTEDİGİNZE EMİN MİSİNİZ", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Random random = new Random();
            int hour = random.Next(0, 24);
            int minute = random.Next(0, 60);
            int second = random.Next(0, 60);
            DateTime randomTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hour, minute, second);
            MessageBox.Show("KAYDINIZ ŞU SAATE YAPILMIŞTIR :" + randomTime);
            if (tepki1 == DialogResult.OK)
            {
                MessageBox.Show("KAYDINIZ YAPILDI İYİ EGLENCELER DİLERİZ (:");
                pictureBox12.Visible = false;
                label12.Text = "DOLU";
            }
            else
            {
                SEÇİC seçme1 = new SEÇİC();
                seçme1.Show();
                this.Hide();

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            DialogResult tepki1 = new DialogResult();
            tepki1 = MessageBox.Show("BU KOLTUGU SEÇMEK İSTEDİGİNZE EMİN MİSİNİZ", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Random random = new Random();
            int hour = random.Next(0, 24);
            int minute = random.Next(0, 60);
            int second = random.Next(0, 60);
            DateTime randomTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hour, minute, second);
            MessageBox.Show("KAYDINIZ ŞU SAATE YAPILMIŞTIR :" + randomTime);
            if (tepki1 == DialogResult.OK)
            {
                MessageBox.Show("KAYDINIZ YAPILDI İYİ EGLENCELER DİLERİZ (:");
                pictureBox14.Visible = false;
                label14.Text = "DOLU";
            }
            else
            {
                SEÇİC seçme1 = new SEÇİC();
                seçme1.Show();
                this.Hide();

            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            DialogResult tepki1 = new DialogResult();
            tepki1 = MessageBox.Show("BU KOLTUGU SEÇMEK İSTEDİGİNZE EMİN MİSİNİZ", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Random random = new Random();
            int hour = random.Next(0, 24);
            int minute = random.Next(0, 60);
            int second = random.Next(0, 60);
            DateTime randomTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hour, minute, second);
            MessageBox.Show("KAYDINIZ ŞU SAATE YAPILMIŞTIR :" + randomTime);
            if (tepki1 == DialogResult.OK)
            {
                MessageBox.Show("KAYDINIZ YAPILDI İYİ EGLENCELER DİLERİZ (:");
                pictureBox16.Visible = false;
                label16.Text = "DOLU";
            }
            else
            {
                SEÇİC seçme1 = new SEÇİC();
                seçme1.Show();
                this.Hide();

            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            DialogResult tepki1 = new DialogResult();
            tepki1 = MessageBox.Show("BU KOLTUGU SEÇMEK İSTEDİGİNZE EMİN MİSİNİZ", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Random random = new Random();
            int hour = random.Next(0, 24);
            int minute = random.Next(0, 60);
            int second = random.Next(0, 60);
            DateTime randomTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hour, minute, second);
            MessageBox.Show("KAYDINIZ ŞU SAATE YAPILMIŞTIR :" + randomTime);
            if (tepki1 == DialogResult.OK)
            {
                MessageBox.Show("KAYDINIZ YAPILDI İYİ EGLENCELER DİLERİZ (:");
                pictureBox15.Visible = false;
                label15.Text = "DOLU";
            }
            else
            {
                SEÇİC seçme1 = new SEÇİC();
                seçme1.Show();
                this.Hide();

            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            DialogResult tepki1 = new DialogResult();
            tepki1 = MessageBox.Show("BU KOLTUGU SEÇMEK İSTEDİGİNZE EMİN MİSİNİZ", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Random random = new Random();
            int hour = random.Next(0, 24);
            int minute = random.Next(0, 60);
            int second = random.Next(0, 60);
            DateTime randomTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hour, minute, second);
            MessageBox.Show("KAYDINIZ ŞU SAATE YAPILMIŞTIR :" + randomTime);
            if (tepki1 == DialogResult.OK)
            {
                MessageBox.Show("KAYDINIZ YAPILDI İYİ EGLENCELER DİLERİZ (:");
                pictureBox17.Visible = false;
                label17.Text = "DOLU";
                
            }
            else
            {
                SEÇİC seçme1 = new SEÇİC();
                seçme1.Show();
                this.Hide();

            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            DialogResult tepki1 = new DialogResult();
            tepki1 = MessageBox.Show("BU KOLTUGU SEÇMEK İSTEDİGİNZE EMİN MİSİNİZ", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Random random = new Random();
            int hour = random.Next(0, 24);
            int minute = random.Next(0, 60);
            int second = random.Next(0, 60);
            DateTime randomTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hour, minute, second);
            MessageBox.Show("KAYDINIZ ŞU SAATE YAPILMIŞTIR :" + randomTime);
            if (tepki1 == DialogResult.OK)
            {

                MessageBox.Show("KAYDINIZ YAPILDI İYİ EGLENCELER DİLERİZ (:");
                pictureBox18.Visible = false;
                label18.Text = "DOLU";

                
            }
            else
            {
                SEÇİC seçme1 = new SEÇİC();
                seçme1.Show();
                this.Hide();

            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            biletA biletkısım1 = new biletA();
            biletkısım1.Show();
            this.Hide();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            
            filmler filmGoruntule = new filmler();
            filmGoruntule.Show();
            this.Hide();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            DialogResult çıkış1 = new DialogResult();
            çıkış1 = MessageBox.Show("ÇIKIŞ YAPMAK İSTEDİGİNİZE EMİN MİSİNİZ ?", "ÇIKIŞ YAPIYORSUNUZ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if(çıkış1 == DialogResult.OK)
            {
                MessageBox.Show("İYİ GÜNLER DİLERİZ (:");
                Application.Exit();
            }
            else
            {
                SEÇİC seçme2 = new SEÇİC();
                seçme2.Show();
                this.Hide();
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            BÜTÜNF tüm1 = new BÜTÜNF();
            tüm1.Show();
            this.Hide();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            büfe büfeg = new büfe();
            büfeg.Show();
            this.Hide();
        }
    }
}

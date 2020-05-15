using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSB3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e) //aşağıdaki kodlar form yüklenirken çalışmaya başlar
        {
            progressBar1.Value = Form1.yuklenme; // progressbarın yeni değeri 60 olur
            Form1.yuklenme += 20;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            label1.Text = "Soru 3";
            label2.Text = "Resimde görüğünüz hayvanın adı nedir?";
            label3.Text = Form1.dakika.ToString();
            label4.Text = Form1.saniye.ToString();
            radioButton1.Text = "Aslan";
            radioButton2.Text = "Ayı";
            radioButton3.Text = "Kurbağa";
            radioButton4.Text = "Köpek";
            pictureBox1.Image = TSB3.Properties.Resources.dog;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Form1.saniye++;
            if (Form1.saniye > 60)
            {
                Form1.dakika++;
                Form1.saniye = Form1.saniye - 60;
            }
            else if (Form1.saniye == 60)
            {
                Form1.dakika++;
                Form1.saniye = 0;
            }

            label3.Text = Form1.dakika.ToString();
            label4.Text = Form1.saniye.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                Form1.dogru++;
                this.Hide();
                Form1.frm5.Show();
            }
            else
            {
                Form1.yanlis++;
                this.Hide();
                Form1.frm5.Show();
            }

            timer1.Enabled = false;

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}

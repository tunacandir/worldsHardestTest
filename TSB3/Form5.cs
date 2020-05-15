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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e) //aşağıdaki kodlar form yüklenirken çalışmaya başlar
        {
            progressBar1.Value = Form1.yuklenme;
            Form1.yuklenme += 20;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            label1.Text = "Soru 4";
            label2.Text = "Şu anda testin yüzde kaçını tamamladınız?";
            label3.Text = Form1.dakika.ToString();
            label4.Text = Form1.saniye.ToString();
            radioButton1.Text = "%60";
            radioButton2.Text = "%40";
            radioButton3.Text = "%80";
            radioButton4.Text = "%20";
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
            if (radioButton3.Checked)
            {
                Form1.dogru++;
                this.Hide();
                Form1.frm6.Show();
            }
            else
            {
                Form1.yanlis++;
                this.Hide();
                Form1.frm6.Show();
            }

            timer1.Enabled = false;
        }
    }
}

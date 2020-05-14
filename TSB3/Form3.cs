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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            progressBar1.Value = Form1.yuklenme;
            Form1.yuklenme += 20;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            checkBox1.Text = "Ay bir yıldızdır.";
            checkBox2.Text = "Güneş bir yıldızdır.";
            checkBox3.Text = "Dünya bir gezegendir.";
            checkBox4.Text = "Dünya bir yıldızdır.";
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

            label1.Text = Form1.dakika.ToString();
            label2.Text = Form1.saniye.ToString();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true && checkBox3.Checked == true)
            {
                Form1.dogru++;
                this.Hide();
                Form1.frm4.Show();
            }
            else
            {
                Form1.yanlis++;
                this.Hide();
                Form1.frm4.Show();
            }

            timer1.Enabled = false;
        }
    }
}

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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e) //aşağıdaki kodlar form yüklenirken çalışmaya başlar
        {
            progressBar1.Value = Form1.yuklenme;
            Form1.yuklenme += 20;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            label1.Text = "Soru 5";
            label2.Text = "Aşağıdakilerden hangisi veya hangileri programlama dilidir?";
            label3.Text = Form1.dakika.ToString();
            label4.Text = Form1.saniye.ToString();
            checkBox1.Text = "SQL";
            checkBox2.Text = "Java";
            checkBox3.Text = "HTML";
            checkBox4.Text = "C#";
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            if (checkBox2.Checked == true && checkBox4.Checked == true)
            {
                Form1.dogru++;
                this.Hide();
                Form1.frm7.Show();
            }
            else
            {
                Form1.yanlis++;
                this.Hide();
                Form1.frm7.Show();
            }

            timer1.Enabled = false;
        }
    }
}

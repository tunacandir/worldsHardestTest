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
    public partial class Form7 : Form
    {
        public static int puan = 10;
        public static int sure = 60;
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e) //aşağıdaki kodlar form yüklenirken çalışmaya başlar
        {
            label1.Text = "Toplam geçen süre:" + Form1.dakika + " dakika, " + Form1.saniye + "saniye";
            label2.Text = "Doğru : " + Form1.dogru;
            label3.Text = "Yanlış : " + Form1.yanlis;
            button1.Text = "BİTİR";
            if (Form1.yanlis == 5)
            {
                puan = 0;
            }
            else
            {
                puan = puan * Form1.dogru;
            }

            sure = sure * Form1.dakika;
            sure = sure + Form1.saniye;
            
            sure = 50 - sure;
            puan = puan + sure;

            if (Form1.yanlis == 5)
            {
                puan = 0;
            }

            if (puan < 0)
            {
                puan = 0;
            }

            label4.Text = "Skor : " + puan + "/100";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

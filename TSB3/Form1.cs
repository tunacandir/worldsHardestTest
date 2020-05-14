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
    public partial class Form1 : Form
    {
        public static int yuklenme = 20;
        public static int dogru = 0;
        public static int yanlis = 0;
        public static int saniye = 0;
        public static int dakika = 0;
        public static Form2 frm2 = new Form2();
        public static Form3 frm3 = new Form3();
        public static Form4 frm4 = new Form4();
        public static Form5 frm5 = new Form5();
        public static Form6 frm6 = new Form6();
        public static Form7 frm7 = new Form7();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            frm2.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "!!!Dünyanın En Zor Sınavı!!!";
            button1.Text = "BAŞLA";
        }
    }
}

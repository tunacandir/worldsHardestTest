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
        
        //public staticler sayesinde bunların hepsini bütün formlarda kullanabiliyoruz
        public static int yuklenme = 20; // progress bar için ne kadar yükleneceğini tutan public static int.
        public static int dogru = 0; // dogru sayısı sayacı
        public static int yanlis = 0; // yanlış sayacı
        public static int saniye = 0; // saniye sayacı
        public static int dakika = 0; // dakika sayacı
        public static Form frm1 = new Form(); // form 1 yi kullanmak diğer formlarda kullanmaya yarar
        public static Form2 frm2 = new Form2(); // form 2 yi kullanmak diğer formlarda kullanmaya yarar
        public static Form3 frm3 = new Form3(); // form 3 yi kullanmak diğer formlarda kullanmaya yarar
        public static Form4 frm4 = new Form4(); // form 4 yi kullanmak diğer formlarda kullanmaya yarar
        public static Form5 frm5 = new Form5(); // form 5 yi kullanmak diğer formlarda kullanmaya yarar
        public static Form6 frm6 = new Form6(); // form 6 yi kullanmak diğer formlarda kullanmaya yarar
        public static Form7 frm7 = new Form7(); // form 7 yi kullanmak diğer formlarda kullanmaya yarar
        public Form1()
        {
            InitializeComponent();
        }

        private bool flag;
        private void button1_Click(object sender, EventArgs e)
        {
            frm2.Show(); //2. formu açar
            this.Hide(); // bu formu saklar
            System.Drawing.Bitmap bitmap1;

            if (flag)
            {
                bitmap1 = TSB3.Properties.Resources.başla2;
            }
            else
            {
                bitmap1 = TSB3.Properties.Resources.başla2;
            }

            flag = !flag;

            //button1.Image = TSB3.Properties.Resources.başla2;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            label1.Text = "!!!Dünyanın En Zor Testi!!!"; //labela yazı
            button1.Image = TSB3.Properties.Resources.başla;
            
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.Image = TSB3.Properties.Resources.başla2;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Image = TSB3.Properties.Resources.başla;
        }
    }
}

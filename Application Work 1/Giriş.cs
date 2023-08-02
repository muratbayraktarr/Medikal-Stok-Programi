using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Application_Work_1
{
    public partial class Giriş : Form
    {
        public Giriş()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            
        }
        string kullaniciadi = "";
        string şifre = "";
        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string metin;
            metin = textBox2.Text;
            string metin2;
            metin2 = textBox3.Text;
            if(metin==kullaniciadi && metin2 ==şifre)
            {
                label5.Hide();
                label6.Show();
                label6.BackColor = Color.Green;
                   label6.Text = "Başarıyla Giriş Yapıldı ✔️";
                
                 Anasayfa a1 = new Anasayfa();
                a1.Show();
                
            }
            else
            {
                label6.Hide();
                label5.Show();
                label5.Text = "KULLANICI ADI YA DA ŞİFRE YANLIŞ!";
                
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Giriş_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            güvenlicikisonay g2 = new güvenlicikisonay();
            g2.Show();
        }
    }
}

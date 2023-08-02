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
using System.IO;


namespace Application_Work_1
{
    public partial class ÜrünEkle : Form
    {
        public ÜrünEkle()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }
        string imagepath;
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            openFileDialog1.Title = "Resim seç";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                imagepath = openFileDialog1.FileName;
            }
           
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            
        }

       
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand commandAdd = new SqlCommand("Insert into ÜrünTable4 (Ürün,Resim,[Güncellenme Tarihi]) values (@purun,@presim,@ptarih)", SqlOperations.connection);
            SqlOperations.CheckConnection(SqlOperations.connection);
            FileStream ft = new FileStream(imagepath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(ft);
            byte[] resim = br.ReadBytes((int)ft.Length);
            br.Close();
            ft.Close();
            int a=0;

            try
            {
                SqlOperations.CheckConnection(SqlOperations.connection);
                using (DataTable dt1 = new DataTable("Customer"))
                {
                    using (SqlCommand cmd = new SqlCommand("select *from ÜrünTable4 where Ürün = @customerid", SqlOperations.connection))
                    {
                        cmd.Parameters.AddWithValue("customerid", textürünadi.Text);
                        
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt1);
                        dataGridView1.DataSource = dt1;
                        a = dataGridView1.RowCount;
                        Console.WriteLine(a);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            if(a==1)
            {
                try
                {
                    commandAdd.Parameters.AddWithValue("@purun", textürünadi.Text);
                    commandAdd.Parameters.AddWithValue("@ptarih", DateTime.Now);
                    commandAdd.Parameters.Add("@presim", SqlDbType.Image, resim.Length).Value = resim;
                    commandAdd.ExecuteNonQuery();

                    this.Close();
                    
                    

                }
                catch (Exception)
                {

                    MessageBox.Show("Lütfen Tüm Degerleri Giriniz","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Error);

                }
            }
            else if (a!=1)
            {
                MessageBox.Show("Böyle Bir Ürün Zaten Var", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void ÜrünEkle_Load(object sender, EventArgs e)
        {

        }
    }
}

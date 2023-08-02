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


    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
            
        }

        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'stokDBDataSetUrun4.ÜrünTable4' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
           // this.ürünTable4TableAdapter.Fill(this.stokDBDataSetUrun4.ÜrünTable4);
            
            SqlOperations.CheckConnection(SqlOperations.connection);
            SqlCommand commandlist = new SqlCommand("Select *  from ÜrünTable4", SqlOperations.connection);
            SqlDataAdapter adapter = new SqlDataAdapter(commandlist);
            DataTable dt2 = new DataTable();


            adapter.Fill(dt2);
            dataGridView1.DataSource = dt2;






        }
        public void RefreshPage()
        {
            SqlOperations.CheckConnection(SqlOperations.connection);
            SqlCommand commandlist = new SqlCommand("Select *  from ÜrünTable4", SqlOperations.connection);
            SqlDataAdapter adapter = new SqlDataAdapter(commandlist);
            DataTable dt2 = new DataTable();


            adapter.Fill(dt2);
            dataGridView1.DataSource = dt2;



        }


        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
        ÜrünEkle u1;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            u1 = new ÜrünEkle();
            u1.Show();
            
            
            RefreshPage();
            
           
        }

        private void ürünTableBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

        }

        string selectedresim;
        string selectedname;
        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            
        }
        int selectedid;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //SqlOperations.CheckConnection(SqlOperations.connection);
            //selectedresim = Convert.ToString(dataGridView1.CurrentRow.Cells["Resim "].Value);
            
           
            urunresmi.ImageLocation = selectedresim;
            
            
        }
        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            selectedid =  Convert.ToInt32(dataGridView1.Rows[secilen].Cells[0].Value);
           // urunresmi.Image = Image.FromFile(openFileDialog1.FileName);
            //urunresmi.ImageLocation = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            
            textBox1.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            SqlOperations.CheckConnection(SqlOperations.connection);
            SqlCommand komut = new SqlCommand("select * from ÜrünTable4 where Id='" + int.Parse(Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value))+"'",SqlOperations.connection);
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                if(dr["Resim"]!=null)
                {

                    byte[] resim = new byte[0];
                    resim = (byte[])dr["Resim"];
                    MemoryStream mr = new MemoryStream(resim);
                    urunresmi.Image = Image.FromStream(mr);
                    dr.Close();
                    komut.Dispose();


                }
            }


            
          //  textBox2.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            RefreshPage();
            txtSearch.Text = null;
        }
        string silmepass = "asd123";
        string imagepath;
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            
            if(silmepass == textBox3.Text)
            {
               DialogResult result1 =  MessageBox.Show("Silmek İstediğinize Emin misiniz ?", "Ürün Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
               if(result1 == DialogResult.Yes)
               {
                    SqlCommand commandDelete = new SqlCommand("Delete from ÜrünTable4 where ID=@pid", SqlOperations.connection);
                    SqlOperations.CheckConnection(SqlOperations.connection);
                    commandDelete.Parameters.AddWithValue("@pid", selectedid);

                    
                    commandDelete.ExecuteNonQuery();
                    RefreshPage();
               }
               else
               {

               }
            }
            else
            {
                label5.Text = "Şifre Yanlış !";
            }
               
               
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            FileStream ft = new FileStream(imagepath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(ft);
            byte[] resim = br.ReadBytes((int)ft.Length);
            br.Close();
            ft.Close();
            SqlCommand commandEdit = new SqlCommand("Update ÜrünTable4 set Ürün=@pname , Resim=@presim , [Güncellenme Tarihi] = @ptarih where ID = @pid",SqlOperations.connection);
            SqlOperations.CheckConnection(SqlOperations.connection);
            commandEdit.Parameters.AddWithValue("@pname", textBox1.Text);
            commandEdit.Parameters.Add("@presim", SqlDbType.Image, resim.Length).Value = resim;
            commandEdit.Parameters.AddWithValue("@ptarih", DateTime.Now);
            commandEdit.Parameters.AddWithValue("@pid", selectedid);
            
            commandEdit.ExecuteNonQuery();
            MessageBox.Show("Güncellendi ✔️", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshPage();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            try
            {
                SqlOperations.CheckConnection(SqlOperations.connection);
                    using(DataTable dt1 = new DataTable("Customer"))
                    {
                        using(SqlCommand cmd = new SqlCommand("select *from ÜrünTable4 where Ürün = @customerid or Ürün like @contactname", SqlOperations.connection))
                        {
                            cmd.Parameters.AddWithValue("customerid", txtSearch.Text);
                            cmd.Parameters.AddWithValue("contactname", string.Format("%{0}%",txtSearch.Text)); 
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            adapter.Fill(dt1);
                            dataGridView1.DataSource = dt1;
                        }
                    }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = null;
        }

        private void simpleButton2_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void FrmUrunler_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                  RefreshPage();
            }
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            urunresmi.SizeMode = PictureBoxSizeMode.StretchImage;
            openFileDialog1.Title = "Resim seç";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                urunresmi.Image = Image.FromFile(openFileDialog1.FileName);
                imagepath = openFileDialog1.FileName;
            }

            urunresmi.ImageLocation = openFileDialog1.FileName;
        }
    }
}

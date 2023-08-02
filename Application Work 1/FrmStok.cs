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
    public partial class FrmStok : Form
    {
        public FrmStok()
        {
            InitializeComponent();
        }
        int adet;
        private void FrmStok_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'stokDBDataSetstokkk.StokTable' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            RefreshPage();

           

        }
        private void RefreshPage()
        {
            SqlOperations.CheckConnection(SqlOperations.connection);
            SqlCommand commandlist = new SqlCommand("Select *  from StokTable", SqlOperations.connection);
            SqlDataAdapter adapter = new SqlDataAdapter(commandlist);
            DataTable dt2 = new DataTable();
            
            adapter.Fill(dt2);
            dataGridView1.DataSource = dt2;
            txtSearch.Text = "Arama...";
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand commandAdd = new SqlCommand("Insert into StokTable ([Ürün İsmi],Adet,[Güncellenme Tarihi],[Stok Durumu]) values (@purun,@padet,@ptarih,@pstok)", SqlOperations.connection);
                SqlOperations.CheckConnection(SqlOperations.connection);
                commandAdd.Parameters.AddWithValue("@purun", eklead.Text);
                commandAdd.Parameters.AddWithValue("@padet", Convert.ToInt32(ekleadet.Text) );
                commandAdd.Parameters.AddWithValue("@ptarih", DateTime.Now);
                adet = Convert.ToInt32(ekleadet.Text);
                if(adet<=50 && adet > 0)
                {
                    commandAdd.Parameters.AddWithValue("@pstok", "AZ");
                }
                else if(adet > 50)
                {
                    commandAdd.Parameters.AddWithValue("@pstok", "YETERLI");
                }
                else
                {
                    commandAdd.Parameters.AddWithValue("@pstok", "HATALI MIKTAR");
                }
                commandAdd.ExecuteNonQuery();
                RefreshPage();
                 
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Tüm Degerleri Giriniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
               
            
        }
        string silmepass = "asd123";
        int selectedid;
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (silmepass == stoksilme.Text)
            {
                DialogResult result1 = MessageBox.Show("Silmek İstediğinize Emin misiniz ?", "Ürün Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result1 == DialogResult.Yes)
                {
                    SqlCommand commandDelete = new SqlCommand("Delete from StokTable where StokID=@psid", SqlOperations.connection);
                    SqlOperations.CheckConnection(SqlOperations.connection);
                    commandDelete.Parameters.AddWithValue("@psid", selectedid);


                    commandDelete.ExecuteNonQuery();
                    RefreshPage();
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Şifre Yanlış !!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            selectedid = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[0].Value);
            guncellead.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            guncelleadet.Text = Convert.ToString(dataGridView1.Rows[secilen].Cells[2].Value);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand commandEdit = new SqlCommand("Update StokTable set [Ürün İsmi]=@pname , Adet=@padet , [Güncellenme Tarihi] = @ptarih , [Stok Durumu] = @pstok where StokID = @psid", SqlOperations.connection);
                SqlOperations.CheckConnection(SqlOperations.connection);
                commandEdit.Parameters.AddWithValue("@pname", guncellead.Text);
                commandEdit.Parameters.AddWithValue("@padet", Convert.ToInt32(guncelleadet.Text));
                commandEdit.Parameters.AddWithValue("@ptarih", DateTime.Now);
                commandEdit.Parameters.AddWithValue("@psid", selectedid);
                adet = Convert.ToInt32(guncelleadet.Text);
                if (adet <= 50 && adet > 0)
                {
                    commandEdit.Parameters.AddWithValue("@pstok", "AZ");
                }
                else if (adet > 50)
                {
                    commandEdit.Parameters.AddWithValue("@pstok", "YETERLI");
                }
                else
                {
                    commandEdit.Parameters.AddWithValue("@pstok", "HATALI MIKTAR");
                }


                commandEdit.ExecuteNonQuery();
                RefreshPage();
                MessageBox.Show("Güncellendi ✔️", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen Tüm Degerleri Giriniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
           
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            try
            {
                SqlOperations.CheckConnection(SqlOperations.connection);
                using (DataTable dt1 = new DataTable("Customer"))
                {
                    using (SqlCommand cmd = new SqlCommand("select *from StokTable where [Ürün İsmi] = @customerid or [Ürün İsmi] like @contactname", SqlOperations.connection))
                    {
                        cmd.Parameters.AddWithValue("customerid", txtSearch.Text);
                        cmd.Parameters.AddWithValue("contactname", string.Format("%{0}%", txtSearch.Text));
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

        private void FrmStok_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                RefreshPage();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }
    }
}

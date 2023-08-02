using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Application_Work_1
{
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        private void RefreshPage()
        {
            SqlOperations.CheckConnection(SqlOperations.connection);
            SqlCommand commandlist = new SqlCommand("Select *  from PersonelTable", SqlOperations.connection);
            SqlDataAdapter adapter = new SqlDataAdapter(commandlist);
            DataTable dt2 = new DataTable();

            adapter.Fill(dt2);
            dataGridView1.DataSource = dt2;
            txtSearch.Text = "Arama...";
        }
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'stokDBDataSetSiparisÜrün.ÜrünTable4' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.ürünTable4TableAdapter.Fill(this.stokDBDataSetSiparisÜrün.ÜrünTable4);
            // TODO: Bu kod satırı 'stokDBDataSetPersonel.PersonelTable' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.personelTableTableAdapter.Fill(this.stokDBDataSetPersonel.PersonelTable);

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand commandAdd = new SqlCommand("Insert into PersonelTable ([Personel İsmi],[Hazırlanan Ürün],Adet,Tarih,[Güncellenme Tarihi],Açıklama) values (@ppersonel,@purun,@padet,@ptarih,@pgtarih,@paciklama)", SqlOperations.connection);
                SqlOperations.CheckConnection(SqlOperations.connection);
                commandAdd.Parameters.AddWithValue("@ppersonel", isim.Text);
                commandAdd.Parameters.AddWithValue("@purun", ürün.Text);
                commandAdd.Parameters.AddWithValue("@padet", Convert.ToInt32(adet.Text));
                commandAdd.Parameters.AddWithValue("@ptarih", tarih.Value);

                commandAdd.Parameters.AddWithValue("@pgtarih", DateTime.Now);
                commandAdd.Parameters.AddWithValue("@paciklama", açıklama.Text);


               
                commandAdd.ExecuteNonQuery();
                RefreshPage();

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
                    using (SqlCommand cmd = new SqlCommand("select *from PersonelTable where [Personel İsmi] = @customerid or [Personel İsmi] like @contactname", SqlOperations.connection))
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

        private void FrmPersonel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                RefreshPage();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Silmek İstediğinize Emin misiniz ?", "Ürün Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {
                SqlCommand commandDelete = new SqlCommand("Delete from PersonelTable where ID=@pid", SqlOperations.connection);
                SqlOperations.CheckConnection(SqlOperations.connection);
                commandDelete.Parameters.AddWithValue("@pid", selectedid);


                commandDelete.ExecuteNonQuery();
                RefreshPage();
            }
            else
            {

            }
        }
        int secilen;
        int selectedid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            selectedid = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[0].Value);
        }
    }
}

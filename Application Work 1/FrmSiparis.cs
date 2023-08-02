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
    public partial class FrmSiparis : Form
    {
        public FrmSiparis()
        {
            InitializeComponent();
        }

        private void FrmSiparis_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'stokDBDataSetSiparisÜrün.ÜrünTable4' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ürünTable4TableAdapter.Fill(this.stokDBDataSetSiparisÜrün.ÜrünTable4);
            // TODO: Bu kod satırı 'stokDBDataSet.ÜrünTable2' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.

            // TODO: Bu kod satırı 'stokDBDataSetsiparistable2.SiparisTable2' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.siparisTable2TableAdapter.Fill(this.stokDBDataSetsiparistable2.SiparisTable2);
            txtSearch.Text = "Arama...";
        }
        private void RefreshPage()
        {
            SqlOperations.CheckConnection(SqlOperations.connection);
            SqlCommand commandlist = new SqlCommand("Select *  from SiparisTable2", SqlOperations.connection);
            SqlDataAdapter adapter = new SqlDataAdapter(commandlist);
            DataTable dt2 = new DataTable();

            adapter.Fill(dt2);
            dataGridView1.DataSource = dt2;
            txtSearch.Text = "Arama...";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand commandEdit = new SqlCommand("Update SiparisTable2 set [Ürün İsmi]=@pname , [Alıcı Firma]=@palici ,Adet=@padet ,Kalite=@pkalite, [Güncellenme Tarihi] = @ptarih ,[Teslim Tarihi]=@pttarih, Açıklama = @paciklama where ID = @pid", SqlOperations.connection);
                SqlOperations.CheckConnection(SqlOperations.connection);
                commandEdit.Parameters.AddWithValue("@pname", listBoxControl1.Text);
                commandEdit.Parameters.AddWithValue("@palici", sipkalite.Text);
                commandEdit.Parameters.AddWithValue("@padet", Convert.ToInt32(sipadet.Text));
                commandEdit.Parameters.AddWithValue("@pkalite", sipalici.Text);
                commandEdit.Parameters.AddWithValue("@ptarih", DateTime.Now);
                commandEdit.Parameters.AddWithValue("@pttarih", sipteslim.Value);
                commandEdit.Parameters.AddWithValue("@paciklama", sipaciklama.Text);
                commandEdit.Parameters.AddWithValue("@pid", selectedid);


                commandEdit.ExecuteNonQuery();
                RefreshPage();
                MessageBox.Show("Güncellendi ✔️", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen Tüm Degerleri Giriniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand commandAdd = new SqlCommand("Insert into SiparisTable2 ([Ürün İsmi],[Alıcı Firma],Adet,Kalite,[Güncellenme Tarihi],[Teslim Tarihi],Açıklama) values (@purun,@palici,@padet,@pkalite,@pgtarih,@pttarih,@paciklama)", SqlOperations.connection);
                SqlOperations.CheckConnection(SqlOperations.connection);
                commandAdd.Parameters.AddWithValue("@purun", listBoxControl1.Text);
                commandAdd.Parameters.AddWithValue("@palici", sipalici.Text);
                commandAdd.Parameters.AddWithValue("@padet", Convert.ToInt32(sipadet.Text));
                commandAdd.Parameters.AddWithValue("@pkalite", sipkalite.Text);
                commandAdd.Parameters.AddWithValue("@pgtarih", DateTime.Now);
                commandAdd.Parameters.AddWithValue("@pttarih", sipteslim.Value);
                commandAdd.Parameters.AddWithValue("@paciklama", sipaciklama.Text);
                
                commandAdd.ExecuteNonQuery();
                RefreshPage();

            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Tüm Degerleri Giriniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        int secilen;
        int selectedid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            selectedid = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[0].Value);
            listBoxControl1.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            sipalici.Text = Convert.ToString(dataGridView1.Rows[secilen].Cells[2].Value);
            sipadet.Text = Convert.ToString(dataGridView1.Rows[secilen].Cells[3].Value);
            sipkalite.Text = Convert.ToString(dataGridView1.Rows[secilen].Cells[4].Value);
            sipteslim.Text = Convert.ToString(dataGridView1.Rows[secilen].Cells[6].Value);
            sipaciklama.Text = Convert.ToString(dataGridView1.Rows[secilen].Cells[7].Value);
        }

        private void FrmSiparis_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                RefreshPage();
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlOperations.CheckConnection(SqlOperations.connection);
                using (DataTable dt1 = new DataTable("Customer"))
                {
                    using (SqlCommand cmd = new SqlCommand("select *from SiparisTable2 where [Ürün İsmi] = @customerid or [Ürün İsmi] like @contactname", SqlOperations.connection))
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

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Silmek İstediğinize Emin misiniz ?", "Ürün Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {
                SqlCommand commandDelete = new SqlCommand("Delete from SiparisTable2 where ID=@psid", SqlOperations.connection);
                SqlOperations.CheckConnection(SqlOperations.connection);
                commandDelete.Parameters.AddWithValue("@psid", selectedid);


                commandDelete.ExecuteNonQuery();
                RefreshPage();
            }
            else
            {

            }
        }
    }
}

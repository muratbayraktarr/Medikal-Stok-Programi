
namespace Application_Work_1
{
    partial class FrmPersonel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonel));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelİsmiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hazırlananÜrünDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.güncellenmeTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.açıklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stokDBDataSetPersonel = new Application_Work_1.StokDBDataSetPersonel();
            this.personelTableTableAdapter = new Application_Work_1.StokDBDataSetPersonelTableAdapters.PersonelTableTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.isim = new System.Windows.Forms.TextBox();
            this.adet = new System.Windows.Forms.TextBox();
            this.tarih = new System.Windows.Forms.DateTimePicker();
            this.açıklama = new System.Windows.Forms.TextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.ürün = new System.Windows.Forms.ComboBox();
            this.ürünTable4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stokDBDataSetSiparisÜrün = new Application_Work_1.StokDBDataSetSiparisÜrün();
            this.ürünTable4TableAdapter = new Application_Work_1.StokDBDataSetSiparisÜrünTableAdapters.ÜrünTable4TableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokDBDataSetPersonel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ürünTable4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokDBDataSetSiparisÜrün)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.personelİsmiDataGridViewTextBoxColumn,
            this.hazırlananÜrünDataGridViewTextBoxColumn,
            this.adetDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn,
            this.güncellenmeTarihiDataGridViewTextBoxColumn,
            this.açıklamaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personelTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(780, 465);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıDDataGridViewTextBoxColumn.Visible = false;
            // 
            // personelİsmiDataGridViewTextBoxColumn
            // 
            this.personelİsmiDataGridViewTextBoxColumn.DataPropertyName = "Personel İsmi";
            this.personelİsmiDataGridViewTextBoxColumn.HeaderText = "Personel İsmi";
            this.personelİsmiDataGridViewTextBoxColumn.Name = "personelİsmiDataGridViewTextBoxColumn";
            this.personelİsmiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hazırlananÜrünDataGridViewTextBoxColumn
            // 
            this.hazırlananÜrünDataGridViewTextBoxColumn.DataPropertyName = "Hazırlanan Ürün";
            this.hazırlananÜrünDataGridViewTextBoxColumn.HeaderText = "Hazırlanan Ürün";
            this.hazırlananÜrünDataGridViewTextBoxColumn.Name = "hazırlananÜrünDataGridViewTextBoxColumn";
            this.hazırlananÜrünDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adetDataGridViewTextBoxColumn
            // 
            this.adetDataGridViewTextBoxColumn.DataPropertyName = "Adet";
            this.adetDataGridViewTextBoxColumn.HeaderText = "Adet";
            this.adetDataGridViewTextBoxColumn.Name = "adetDataGridViewTextBoxColumn";
            this.adetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "Tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // güncellenmeTarihiDataGridViewTextBoxColumn
            // 
            this.güncellenmeTarihiDataGridViewTextBoxColumn.DataPropertyName = "Güncellenme Tarihi";
            this.güncellenmeTarihiDataGridViewTextBoxColumn.HeaderText = "Güncellenme Tarihi";
            this.güncellenmeTarihiDataGridViewTextBoxColumn.Name = "güncellenmeTarihiDataGridViewTextBoxColumn";
            this.güncellenmeTarihiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // açıklamaDataGridViewTextBoxColumn
            // 
            this.açıklamaDataGridViewTextBoxColumn.DataPropertyName = "Açıklama";
            this.açıklamaDataGridViewTextBoxColumn.HeaderText = "Açıklama";
            this.açıklamaDataGridViewTextBoxColumn.Name = "açıklamaDataGridViewTextBoxColumn";
            this.açıklamaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personelTableBindingSource
            // 
            this.personelTableBindingSource.DataMember = "PersonelTable";
            this.personelTableBindingSource.DataSource = this.stokDBDataSetPersonel;
            // 
            // stokDBDataSetPersonel
            // 
            this.stokDBDataSetPersonel.DataSetName = "StokDBDataSetPersonel";
            this.stokDBDataSetPersonel.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelTableTableAdapter
            // 
            this.personelTableTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(855, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ekle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(836, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Personel İsmi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(828, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hazırlanan Ürün";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(867, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Adet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(865, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tarih";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(850, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Açıklama";
            // 
            // isim
            // 
            this.isim.Location = new System.Drawing.Point(834, 70);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(100, 20);
            this.isim.TabIndex = 7;
            // 
            // adet
            // 
            this.adet.Location = new System.Drawing.Point(835, 185);
            this.adet.Name = "adet";
            this.adet.Size = new System.Drawing.Size(100, 20);
            this.adet.TabIndex = 9;
            // 
            // tarih
            // 
            this.tarih.Location = new System.Drawing.Point(813, 244);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(145, 20);
            this.tarih.TabIndex = 10;
            // 
            // açıklama
            // 
            this.açıklama.Location = new System.Drawing.Point(812, 295);
            this.açıklama.Multiline = true;
            this.açıklama.Name = "açıklama";
            this.açıklama.Size = new System.Drawing.Size(145, 77);
            this.açıklama.TabIndex = 11;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(834, 392);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(102, 46);
            this.simpleButton1.TabIndex = 12;
            this.simpleButton1.Text = "Ekle";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(670, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.Text = "Arama...";
            this.txtSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseClick);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // simpleButton5
            // 
            this.simpleButton5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton5.ImageOptions.SvgImage")));
            this.simpleButton5.Location = new System.Drawing.Point(670, 38);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(100, 41);
            this.simpleButton5.TabIndex = 15;
            this.simpleButton5.Text = "Ara";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // ürün
            // 
            this.ürün.DataSource = this.ürünTable4BindingSource;
            this.ürün.DisplayMember = "Ürün";
            this.ürün.FormattingEnabled = true;
            this.ürün.Location = new System.Drawing.Point(834, 128);
            this.ürün.Name = "ürün";
            this.ürün.Size = new System.Drawing.Size(100, 21);
            this.ürün.TabIndex = 16;
            // 
            // ürünTable4BindingSource
            // 
            this.ürünTable4BindingSource.DataMember = "ÜrünTable4";
            this.ürünTable4BindingSource.DataSource = this.stokDBDataSetSiparisÜrün;
            // 
            // stokDBDataSetSiparisÜrün
            // 
            this.stokDBDataSetSiparisÜrün.DataSetName = "StokDBDataSetSiparisÜrün";
            this.stokDBDataSetSiparisÜrün.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ürünTable4TableAdapter
            // 
            this.ürünTable4TableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(670, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 34);
            this.button1.TabIndex = 17;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 464);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ürün);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.açıklama);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.adet);
            this.Controls.Add(this.isim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.KeyPreview = true;
            this.Name = "FrmPersonel";
            this.Text = "PERSONEL GÜNLÜĞÜ";
            this.Load += new System.EventHandler(this.FrmPersonel_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPersonel_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokDBDataSetPersonel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ürünTable4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokDBDataSetSiparisÜrün)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private StokDBDataSetPersonel stokDBDataSetPersonel;
        private System.Windows.Forms.BindingSource personelTableBindingSource;
        private StokDBDataSetPersonelTableAdapters.PersonelTableTableAdapter personelTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelİsmiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hazırlananÜrünDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn güncellenmeTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn açıklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox isim;
        private System.Windows.Forms.TextBox adet;
        private System.Windows.Forms.DateTimePicker tarih;
        private System.Windows.Forms.TextBox açıklama;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.TextBox txtSearch;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private System.Windows.Forms.ComboBox ürün;
        private StokDBDataSetSiparisÜrün stokDBDataSetSiparisÜrün;
        private System.Windows.Forms.BindingSource ürünTable4BindingSource;
        private StokDBDataSetSiparisÜrünTableAdapters.ÜrünTable4TableAdapter ürünTable4TableAdapter;
        private System.Windows.Forms.Button button1;
    }
}
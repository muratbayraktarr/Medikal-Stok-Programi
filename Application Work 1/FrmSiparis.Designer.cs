
namespace Application_Work_1
{
    partial class FrmSiparis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSiparis));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ürünİsmiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alıcıFirmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kaliteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.güncellenmeTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teslimTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.açıklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparisTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stokDBDataSetsiparistable2 = new Application_Work_1.StokDBDataSetsiparistable2();
            this.siparisTable2TableAdapter = new Application_Work_1.StokDBDataSetsiparistable2TableAdapters.SiparisTable2TableAdapter();
            this.sipalici = new System.Windows.Forms.TextBox();
            this.sipadet = new System.Windows.Forms.TextBox();
            this.sipkalite = new System.Windows.Forms.TextBox();
            this.sipteslim = new System.Windows.Forms.DateTimePicker();
            this.sipaciklama = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.SearchButton = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.ürünTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stokDBDataSet = new Application_Work_1.StokDBDataSet();
            this.ürünTable2TableAdapter = new Application_Work_1.StokDBDataSetTableAdapters.ÜrünTable2TableAdapter();
            this.stokDBDataSetSiparisÜrün = new Application_Work_1.StokDBDataSetSiparisÜrün();
            this.ürünTable4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ürünTable4TableAdapter = new Application_Work_1.StokDBDataSetSiparisÜrünTableAdapters.ÜrünTable4TableAdapter();
            this.listBoxControl1 = new System.Windows.Forms.ComboBox();
            this.ürünTable4BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisTable2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokDBDataSetsiparistable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ürünTable2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokDBDataSetSiparisÜrün)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ürünTable4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ürünTable4BindingSource1)).BeginInit();
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
            this.ürünİsmiDataGridViewTextBoxColumn,
            this.alıcıFirmaDataGridViewTextBoxColumn,
            this.adetDataGridViewTextBoxColumn,
            this.kaliteDataGridViewTextBoxColumn,
            this.güncellenmeTarihiDataGridViewTextBoxColumn,
            this.teslimTarihiDataGridViewTextBoxColumn,
            this.açıklamaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.siparisTable2BindingSource;
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
            this.ıDDataGridViewTextBoxColumn.Width = 20;
            // 
            // ürünİsmiDataGridViewTextBoxColumn
            // 
            this.ürünİsmiDataGridViewTextBoxColumn.DataPropertyName = "Ürün İsmi";
            this.ürünİsmiDataGridViewTextBoxColumn.HeaderText = "Ürün İsmi";
            this.ürünİsmiDataGridViewTextBoxColumn.Name = "ürünİsmiDataGridViewTextBoxColumn";
            this.ürünİsmiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alıcıFirmaDataGridViewTextBoxColumn
            // 
            this.alıcıFirmaDataGridViewTextBoxColumn.DataPropertyName = "Alıcı Firma";
            this.alıcıFirmaDataGridViewTextBoxColumn.HeaderText = "Alıcı Firma";
            this.alıcıFirmaDataGridViewTextBoxColumn.Name = "alıcıFirmaDataGridViewTextBoxColumn";
            this.alıcıFirmaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adetDataGridViewTextBoxColumn
            // 
            this.adetDataGridViewTextBoxColumn.DataPropertyName = "Adet";
            this.adetDataGridViewTextBoxColumn.HeaderText = "Adet";
            this.adetDataGridViewTextBoxColumn.Name = "adetDataGridViewTextBoxColumn";
            this.adetDataGridViewTextBoxColumn.ReadOnly = true;
            this.adetDataGridViewTextBoxColumn.Width = 40;
            // 
            // kaliteDataGridViewTextBoxColumn
            // 
            this.kaliteDataGridViewTextBoxColumn.DataPropertyName = "Kalite";
            this.kaliteDataGridViewTextBoxColumn.HeaderText = "Kalite";
            this.kaliteDataGridViewTextBoxColumn.Name = "kaliteDataGridViewTextBoxColumn";
            this.kaliteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // güncellenmeTarihiDataGridViewTextBoxColumn
            // 
            this.güncellenmeTarihiDataGridViewTextBoxColumn.DataPropertyName = "Güncellenme Tarihi";
            this.güncellenmeTarihiDataGridViewTextBoxColumn.HeaderText = "Güncellenme Tarihi";
            this.güncellenmeTarihiDataGridViewTextBoxColumn.Name = "güncellenmeTarihiDataGridViewTextBoxColumn";
            this.güncellenmeTarihiDataGridViewTextBoxColumn.ReadOnly = true;
            this.güncellenmeTarihiDataGridViewTextBoxColumn.Width = 80;
            // 
            // teslimTarihiDataGridViewTextBoxColumn
            // 
            this.teslimTarihiDataGridViewTextBoxColumn.DataPropertyName = "Teslim Tarihi";
            this.teslimTarihiDataGridViewTextBoxColumn.HeaderText = "Teslim Tarihi";
            this.teslimTarihiDataGridViewTextBoxColumn.Name = "teslimTarihiDataGridViewTextBoxColumn";
            this.teslimTarihiDataGridViewTextBoxColumn.ReadOnly = true;
            this.teslimTarihiDataGridViewTextBoxColumn.Width = 80;
            // 
            // açıklamaDataGridViewTextBoxColumn
            // 
            this.açıklamaDataGridViewTextBoxColumn.DataPropertyName = "Açıklama";
            this.açıklamaDataGridViewTextBoxColumn.HeaderText = "Açıklama";
            this.açıklamaDataGridViewTextBoxColumn.Name = "açıklamaDataGridViewTextBoxColumn";
            this.açıklamaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // siparisTable2BindingSource
            // 
            this.siparisTable2BindingSource.DataMember = "SiparisTable2";
            this.siparisTable2BindingSource.DataSource = this.stokDBDataSetsiparistable2;
            // 
            // stokDBDataSetsiparistable2
            // 
            this.stokDBDataSetsiparistable2.DataSetName = "StokDBDataSetsiparistable2";
            this.stokDBDataSetsiparistable2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // siparisTable2TableAdapter
            // 
            this.siparisTable2TableAdapter.ClearBeforeFill = true;
            // 
            // sipalici
            // 
            this.sipalici.Location = new System.Drawing.Point(872, 191);
            this.sipalici.Name = "sipalici";
            this.sipalici.Size = new System.Drawing.Size(100, 20);
            this.sipalici.TabIndex = 6;
            // 
            // sipadet
            // 
            this.sipadet.Location = new System.Drawing.Point(872, 218);
            this.sipadet.Name = "sipadet";
            this.sipadet.Size = new System.Drawing.Size(100, 20);
            this.sipadet.TabIndex = 7;
            // 
            // sipkalite
            // 
            this.sipkalite.Location = new System.Drawing.Point(872, 244);
            this.sipkalite.Name = "sipkalite";
            this.sipkalite.Size = new System.Drawing.Size(100, 20);
            this.sipkalite.TabIndex = 8;
            // 
            // sipteslim
            // 
            this.sipteslim.Location = new System.Drawing.Point(872, 270);
            this.sipteslim.Name = "sipteslim";
            this.sipteslim.Size = new System.Drawing.Size(100, 20);
            this.sipteslim.TabIndex = 9;
            // 
            // sipaciklama
            // 
            this.sipaciklama.Location = new System.Drawing.Point(795, 320);
            this.sipaciklama.Multiline = true;
            this.sipaciklama.Name = "sipaciklama";
            this.sipaciklama.Size = new System.Drawing.Size(177, 75);
            this.sipaciklama.TabIndex = 10;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(785, 165);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 18);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Ürün İsmi";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(785, 191);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 18);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Alıcı Firma";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(785, 217);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 18);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "Adet";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(785, 243);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(34, 18);
            this.labelControl4.TabIndex = 14;
            this.labelControl4.Text = "Kalite";
            this.labelControl4.Click += new System.EventHandler(this.labelControl4_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(785, 269);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(82, 18);
            this.labelControl5.TabIndex = 15;
            this.labelControl5.Text = "Teslim Tarihi";
            this.labelControl5.Click += new System.EventHandler(this.labelControl5_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(855, 296);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(56, 18);
            this.labelControl6.TabIndex = 16;
            this.labelControl6.Text = "Açıklama";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(811, 126);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(145, 23);
            this.labelControl7.TabIndex = 17;
            this.labelControl7.Text = "Sipariş Bilgileri";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(670, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 18;
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SearchButton.Appearance.Options.UseFont = true;
            this.SearchButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("SearchButton.ImageOptions.SvgImage")));
            this.SearchButton.Location = new System.Drawing.Point(670, 38);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(100, 41);
            this.SearchButton.TabIndex = 19;
            this.SearchButton.Text = "Ara";
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(789, 409);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(89, 42);
            this.simpleButton4.TabIndex = 4;
            this.simpleButton4.Text = "Güncelle";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(795, 59);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(170, 39);
            this.simpleButton3.TabIndex = 3;
            this.simpleButton3.Text = "Sipariş Hazır !";
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(795, 12);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(170, 41);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "Sil";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(884, 409);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(89, 41);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Ekle";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // ürünTable2BindingSource
            // 
            this.ürünTable2BindingSource.DataMember = "ÜrünTable2";
            this.ürünTable2BindingSource.DataSource = this.stokDBDataSet;
            // 
            // stokDBDataSet
            // 
            this.stokDBDataSet.DataSetName = "StokDBDataSet";
            this.stokDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ürünTable2TableAdapter
            // 
            this.ürünTable2TableAdapter.ClearBeforeFill = true;
            // 
            // stokDBDataSetSiparisÜrün
            // 
            this.stokDBDataSetSiparisÜrün.DataSetName = "StokDBDataSetSiparisÜrün";
            this.stokDBDataSetSiparisÜrün.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ürünTable4BindingSource
            // 
            this.ürünTable4BindingSource.DataMember = "ÜrünTable4";
            this.ürünTable4BindingSource.DataSource = this.stokDBDataSetSiparisÜrün;
            // 
            // ürünTable4TableAdapter
            // 
            this.ürünTable4TableAdapter.ClearBeforeFill = true;
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.DataSource = this.ürünTable4BindingSource1;
            this.listBoxControl1.DisplayMember = "Ürün";
            this.listBoxControl1.FormattingEnabled = true;
            this.listBoxControl1.Location = new System.Drawing.Point(872, 162);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(101, 21);
            this.listBoxControl1.TabIndex = 22;
            // 
            // ürünTable4BindingSource1
            // 
            this.ürünTable4BindingSource1.DataMember = "ÜrünTable4";
            this.ürünTable4BindingSource1.DataSource = this.stokDBDataSetSiparisÜrün;
            // 
            // FrmSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 464);
            this.Controls.Add(this.listBoxControl1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.sipaciklama);
            this.Controls.Add(this.sipteslim);
            this.Controls.Add(this.sipkalite);
            this.Controls.Add(this.sipadet);
            this.Controls.Add(this.sipalici);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.dataGridView1);
            this.KeyPreview = true;
            this.Name = "FrmSiparis";
            this.Text = "SİPARİŞLER";
            this.Load += new System.EventHandler(this.FrmSiparis_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmSiparis_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisTable2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokDBDataSetsiparistable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ürünTable2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokDBDataSetSiparisÜrün)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ürünTable4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ürünTable4BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private StokDBDataSetsiparistable2 stokDBDataSetsiparistable2;
        private System.Windows.Forms.BindingSource siparisTable2BindingSource;
        private StokDBDataSetsiparistable2TableAdapters.SiparisTable2TableAdapter siparisTable2TableAdapter;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private System.Windows.Forms.TextBox sipalici;
        private System.Windows.Forms.TextBox sipadet;
        private System.Windows.Forms.TextBox sipkalite;
        private System.Windows.Forms.DateTimePicker sipteslim;
        private System.Windows.Forms.TextBox sipaciklama;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.TextBox txtSearch;
        private DevExpress.XtraEditors.SimpleButton SearchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ürünİsmiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alıcıFirmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kaliteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn güncellenmeTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teslimTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn açıklamaDataGridViewTextBoxColumn;
        private StokDBDataSet stokDBDataSet;
        private System.Windows.Forms.BindingSource ürünTable2BindingSource;
        private StokDBDataSetTableAdapters.ÜrünTable2TableAdapter ürünTable2TableAdapter;
        private StokDBDataSetSiparisÜrün stokDBDataSetSiparisÜrün;
        private System.Windows.Forms.BindingSource ürünTable4BindingSource;
        private StokDBDataSetSiparisÜrünTableAdapters.ÜrünTable4TableAdapter ürünTable4TableAdapter;
        private System.Windows.Forms.ComboBox listBoxControl1;
        private System.Windows.Forms.BindingSource ürünTable4BindingSource1;
    }
}
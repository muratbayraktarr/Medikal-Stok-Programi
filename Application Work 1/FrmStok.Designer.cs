
namespace Application_Work_1
{
    partial class FrmStok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStok));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stokIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ürünİsmiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.güncellenmeTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokDurumuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stokDBDataSetstokkk = new Application_Work_1.StokDBDataSetstokkk();
            this.stokDBDataSet = new Application_Work_1.StokDBDataSet();
            this.ürünTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ürünTable2TableAdapter = new Application_Work_1.StokDBDataSetTableAdapters.ÜrünTable2TableAdapter();
            this.stokDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ürünTable2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ürünTable2BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.stokDBDataSetLaptop = new Application_Work_1.StokDBDataSetLaptop();
            this.ürünTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ürünTableTableAdapter = new Application_Work_1.StokDBDataSetLaptopTableAdapters.ÜrünTableTableAdapter();
            this.ürünTable2BindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.ürünTable2TableAdapter1 = new Application_Work_1.StokDBDataSetLaptopTableAdapters.ÜrünTable2TableAdapter();
            this.stokTableTableAdapter = new Application_Work_1.StokDBDataSetstokkkTableAdapters.StokTableTableAdapter();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.ekleadet = new System.Windows.Forms.TextBox();
            this.eklead = new System.Windows.Forms.TextBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.guncelleadet = new System.Windows.Forms.TextBox();
            this.guncellead = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.stoksilme = new System.Windows.Forms.TextBox();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokDBDataSetstokkk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ürünTable2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ürünTable2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ürünTable2BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokDBDataSetLaptop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ürünTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ürünTable2BindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stokIDDataGridViewTextBoxColumn,
            this.ürünİsmiDataGridViewTextBoxColumn,
            this.adetDataGridViewTextBoxColumn,
            this.güncellenmeTarihiDataGridViewTextBoxColumn,
            this.stokDurumuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stokTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(592, 465);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // stokIDDataGridViewTextBoxColumn
            // 
            this.stokIDDataGridViewTextBoxColumn.DataPropertyName = "StokID";
            this.stokIDDataGridViewTextBoxColumn.HeaderText = "StokID";
            this.stokIDDataGridViewTextBoxColumn.Name = "stokIDDataGridViewTextBoxColumn";
            this.stokIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.stokIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // ürünİsmiDataGridViewTextBoxColumn
            // 
            this.ürünİsmiDataGridViewTextBoxColumn.DataPropertyName = "Ürün İsmi";
            this.ürünİsmiDataGridViewTextBoxColumn.HeaderText = "Ürün İsmi";
            this.ürünİsmiDataGridViewTextBoxColumn.Name = "ürünİsmiDataGridViewTextBoxColumn";
            this.ürünİsmiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adetDataGridViewTextBoxColumn
            // 
            this.adetDataGridViewTextBoxColumn.DataPropertyName = "Adet";
            this.adetDataGridViewTextBoxColumn.HeaderText = "Adet";
            this.adetDataGridViewTextBoxColumn.Name = "adetDataGridViewTextBoxColumn";
            this.adetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // güncellenmeTarihiDataGridViewTextBoxColumn
            // 
            this.güncellenmeTarihiDataGridViewTextBoxColumn.DataPropertyName = "Güncellenme Tarihi";
            this.güncellenmeTarihiDataGridViewTextBoxColumn.HeaderText = "Güncellenme Tarihi";
            this.güncellenmeTarihiDataGridViewTextBoxColumn.Name = "güncellenmeTarihiDataGridViewTextBoxColumn";
            this.güncellenmeTarihiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stokDurumuDataGridViewTextBoxColumn
            // 
            this.stokDurumuDataGridViewTextBoxColumn.DataPropertyName = "Stok Durumu";
            this.stokDurumuDataGridViewTextBoxColumn.HeaderText = "Stok Durumu";
            this.stokDurumuDataGridViewTextBoxColumn.Name = "stokDurumuDataGridViewTextBoxColumn";
            this.stokDurumuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stokTableBindingSource
            // 
            this.stokTableBindingSource.DataMember = "StokTable";
            this.stokTableBindingSource.DataSource = this.stokDBDataSetstokkk;
            // 
            // stokDBDataSetstokkk
            // 
            this.stokDBDataSetstokkk.DataSetName = "StokDBDataSetstokkk";
            this.stokDBDataSetstokkk.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stokDBDataSet
            // 
            this.stokDBDataSet.DataSetName = "StokDBDataSet";
            this.stokDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ürünTable2BindingSource
            // 
            this.ürünTable2BindingSource.DataMember = "ÜrünTable2";
            this.ürünTable2BindingSource.DataSource = this.stokDBDataSet;
            // 
            // ürünTable2TableAdapter
            // 
            this.ürünTable2TableAdapter.ClearBeforeFill = true;
            // 
            // stokDBDataSetBindingSource
            // 
            this.stokDBDataSetBindingSource.DataSource = this.stokDBDataSet;
            this.stokDBDataSetBindingSource.Position = 0;
            // 
            // ürünTable2BindingSource1
            // 
            this.ürünTable2BindingSource1.DataMember = "ÜrünTable2";
            this.ürünTable2BindingSource1.DataSource = this.stokDBDataSet;
            // 
            // ürünTable2BindingSource2
            // 
            this.ürünTable2BindingSource2.DataMember = "ÜrünTable2";
            this.ürünTable2BindingSource2.DataSource = this.stokDBDataSetBindingSource;
            // 
            // stokDBDataSetLaptop
            // 
            this.stokDBDataSetLaptop.DataSetName = "StokDBDataSetLaptop";
            this.stokDBDataSetLaptop.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ürünTableBindingSource
            // 
            this.ürünTableBindingSource.DataMember = "ÜrünTable";
            this.ürünTableBindingSource.DataSource = this.stokDBDataSetLaptop;
            // 
            // ürünTableTableAdapter
            // 
            this.ürünTableTableAdapter.ClearBeforeFill = true;
            // 
            // ürünTable2BindingSource3
            // 
            this.ürünTable2BindingSource3.DataMember = "ÜrünTable2";
            this.ürünTable2BindingSource3.DataSource = this.stokDBDataSetLaptop;
            // 
            // ürünTable2TableAdapter1
            // 
            this.ürünTable2TableAdapter1.ClearBeforeFill = true;
            // 
            // stokTableTableAdapter
            // 
            this.stokTableTableAdapter.ClearBeforeFill = true;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(38, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 19);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Ürün Adı";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(9, 156);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(140, 46);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Ekle";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(58, 89);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 19);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Adet";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.ekleadet);
            this.groupControl1.Controls.Add(this.eklead);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(591, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(154, 216);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Ekle";
            // 
            // ekleadet
            // 
            this.ekleadet.Location = new System.Drawing.Point(26, 114);
            this.ekleadet.Name = "ekleadet";
            this.ekleadet.Size = new System.Drawing.Size(100, 21);
            this.ekleadet.TabIndex = 5;
            // 
            // eklead
            // 
            this.eklead.Location = new System.Drawing.Point(26, 51);
            this.eklead.Name = "eklead";
            this.eklead.Size = new System.Drawing.Size(100, 21);
            this.eklead.TabIndex = 2;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.guncelleadet);
            this.groupControl2.Controls.Add(this.guncellead);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.simpleButton2);
            this.groupControl2.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl2.Location = new System.Drawing.Point(591, 216);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(154, 249);
            this.groupControl2.TabIndex = 7;
            this.groupControl2.Text = "Güncelle";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(38, 26);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(71, 19);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Ürün Adı";
            // 
            // guncelleadet
            // 
            this.guncelleadet.Location = new System.Drawing.Point(26, 114);
            this.guncelleadet.Name = "guncelleadet";
            this.guncelleadet.Size = new System.Drawing.Size(100, 21);
            this.guncelleadet.TabIndex = 5;
            // 
            // guncellead
            // 
            this.guncellead.Location = new System.Drawing.Point(26, 51);
            this.guncellead.Name = "guncellead";
            this.guncellead.Size = new System.Drawing.Size(100, 21);
            this.guncellead.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(58, 89);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(39, 19);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Adet";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(9, 156);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(140, 46);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "Güncelle";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.labelControl5);
            this.groupControl3.Controls.Add(this.stoksilme);
            this.groupControl3.Controls.Add(this.simpleButton3);
            this.groupControl3.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl3.Location = new System.Drawing.Point(743, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(241, 216);
            this.groupControl3.TabIndex = 8;
            this.groupControl3.Text = "Sil";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(9, 49);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(218, 19);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Ürün Silme Şifresini Giriniz";
            // 
            // stoksilme
            // 
            this.stoksilme.Location = new System.Drawing.Point(68, 91);
            this.stoksilme.Name = "stoksilme";
            this.stoksilme.PasswordChar = '*';
            this.stoksilme.Size = new System.Drawing.Size(100, 21);
            this.stoksilme.TabIndex = 2;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(48, 134);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(140, 46);
            this.simpleButton3.TabIndex = 3;
            this.simpleButton3.Text = "Sil";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(469, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.Text = "Arama...";
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // simpleButton5
            // 
            this.simpleButton5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton5.ImageOptions.SvgImage")));
            this.simpleButton5.Location = new System.Drawing.Point(469, 41);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(100, 41);
            this.simpleButton5.TabIndex = 11;
            this.simpleButton5.Text = "Ara";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Application_Work_1.Properties.Resources.indir;
            this.pictureBox1.Location = new System.Drawing.Point(743, 216);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 249);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // FrmStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 464);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dataGridView1);
            this.KeyPreview = true;
            this.Name = "FrmStok";
            this.Text = "STOKLAR";
            this.Load += new System.EventHandler(this.FrmStok_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmStok_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokDBDataSetstokkk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ürünTable2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ürünTable2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ürünTable2BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokDBDataSetLaptop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ürünTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ürünTable2BindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private StokDBDataSet stokDBDataSet;
        private System.Windows.Forms.BindingSource ürünTable2BindingSource;
        private StokDBDataSetTableAdapters.ÜrünTable2TableAdapter ürünTable2TableAdapter;
        private System.Windows.Forms.BindingSource ürünTable2BindingSource2;
        private System.Windows.Forms.BindingSource stokDBDataSetBindingSource;
        private System.Windows.Forms.BindingSource ürünTable2BindingSource1;
        private StokDBDataSetLaptop stokDBDataSetLaptop;
        private System.Windows.Forms.BindingSource ürünTableBindingSource;
        private StokDBDataSetLaptopTableAdapters.ÜrünTableTableAdapter ürünTableTableAdapter;
        private System.Windows.Forms.BindingSource ürünTable2BindingSource3;
        private StokDBDataSetLaptopTableAdapters.ÜrünTable2TableAdapter ürünTable2TableAdapter1;
        private StokDBDataSetstokkk stokDBDataSetstokkk;
        private System.Windows.Forms.BindingSource stokTableBindingSource;
        private StokDBDataSetstokkkTableAdapters.StokTableTableAdapter stokTableTableAdapter;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox guncelleadet;
        private System.Windows.Forms.TextBox guncellead;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.TextBox ekleadet;
        private System.Windows.Forms.TextBox eklead;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.TextBox stoksilme;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ürünİsmiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn güncellenmeTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokDurumuDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtSearch;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
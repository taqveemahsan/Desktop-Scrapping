﻿
namespace Desktop_Scrapping
{
    partial class ScrapperPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScrapperPage));
            this.scrapeTestDataSet = new Desktop_Scrapping.ScrapeTestDataSet();
            this.sellerNameScrapeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellerNameScrapeTableAdapter = new Desktop_Scrapping.ScrapeTestDataSetTableAdapters.SellerNameScrapeTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabScrapCat = new System.Windows.Forms.TabPage();
            this.lblSearchInfo = new System.Windows.Forms.Label();
            this.GroupBoxScrappingLogs = new System.Windows.Forms.GroupBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.lblItemName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnScrapStop = new System.Windows.Forms.Button();
            this.btnScrappingStart = new System.Windows.Forms.Button();
            this.txtProductMaxPrice = new System.Windows.Forms.TextBox();
            this.lblMaxPrice = new System.Windows.Forms.Label();
            this.lblminPrice = new System.Windows.Forms.Label();
            this.txtProductMinPrice = new System.Windows.Forms.TextBox();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.txtSoldValueInput = new System.Windows.Forms.TextBox();
            this.lblEnterSoldPro = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.checkboxListCat = new System.Windows.Forms.CheckedListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnExportExcell = new System.Windows.Forms.Button();
            this.pnlScrapItemByName = new System.Windows.Forms.TabPage();
            this.panel19 = new System.Windows.Forms.Panel();
            this.GrpBoxItemNameScrap = new System.Windows.Forms.GroupBox();
            this.txtMinimumPrice = new System.Windows.Forms.TextBox();
            this.txtSoldItems = new System.Windows.Forms.TextBox();
            this.lblminimumprice = new System.Windows.Forms.Label();
            this.lblMinSold = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnScrpingData = new System.Windows.Forms.Button();
            this.lblItemNam = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblScrapNameItemsInfo = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tabBrands = new System.Windows.Forms.TabPage();
            this.Brands = new System.Windows.Forms.Panel();
            this.lblBrandsSomeDetail = new System.Windows.Forms.Label();
            this.btnBrandSave = new System.Windows.Forms.Button();
            this.btnBrandDel = new System.Windows.Forms.Button();
            this.btnBrandEdit = new System.Windows.Forms.Button();
            this.lblBrandName = new System.Windows.Forms.Label();
            this.lblBrandID = new System.Windows.Forms.Label();
            this.txtBrandName = new System.Windows.Forms.TextBox();
            this.txtBrandID = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.brandIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scrapeTestDataSetBrandTable = new Desktop_Scrapping.ScrapeTestDataSetBrandTable();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tabCategories = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnCatSave = new System.Windows.Forms.Button();
            this.btnCatDelete = new System.Windows.Forms.Button();
            this.btnCatEdit = new System.Windows.Forms.Button();
            this.lblCatName = new System.Windows.Forms.Label();
            this.lblCatID = new System.Windows.Forms.Label();
            this.txtCatName = new System.Windows.Forms.TextBox();
            this.txtCatID = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.GridViewCat = new System.Windows.Forms.DataGridView();
            this.categoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scrapeTestDataSetCategories = new Desktop_Scrapping.ScrapeTestDataSetCategories();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.category_TableTableAdapter = new Desktop_Scrapping.ScrapeTestDataSetCategoriesTableAdapters.Category_TableTableAdapter();
            this.brand_TableTableAdapter = new Desktop_Scrapping.ScrapeTestDataSetBrandTableTableAdapters.Brand_TableTableAdapter();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.scrapeTestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellerNameScrapeBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabScrapCat.SuspendLayout();
            this.panel15.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.pnlScrapItemByName.SuspendLayout();
            this.panel19.SuspendLayout();
            this.GrpBoxItemNameScrap.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel17.SuspendLayout();
            this.tabBrands.SuspendLayout();
            this.Brands.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scrapeTestDataSetBrandTable)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tabCategories.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scrapeTestDataSetCategories)).BeginInit();
            this.tabHome.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // scrapeTestDataSet
            // 
            this.scrapeTestDataSet.DataSetName = "ScrapeTestDataSet";
            this.scrapeTestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sellerNameScrapeBindingSource
            // 
            this.sellerNameScrapeBindingSource.DataMember = "SellerNameScrape";
            this.sellerNameScrapeBindingSource.DataSource = this.scrapeTestDataSet;
            // 
            // sellerNameScrapeTableAdapter
            // 
            this.sellerNameScrapeTableAdapter.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tabControl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(805, 532);
            this.panel3.TabIndex = 13;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabScrapCat);
            this.tabControl.Controls.Add(this.pnlScrapItemByName);
            this.tabControl.Controls.Add(this.tabBrands);
            this.tabControl.Controls.Add(this.tabCategories);
            this.tabControl.Controls.Add(this.tabHome);
            this.tabControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl.Location = new System.Drawing.Point(0, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(805, 529);
            this.tabControl.TabIndex = 14;
            // 
            // tabScrapCat
            // 
            this.tabScrapCat.BackColor = System.Drawing.Color.White;
            this.tabScrapCat.Controls.Add(this.lblSearchInfo);
            this.tabScrapCat.Controls.Add(this.GroupBoxScrappingLogs);
            this.tabScrapCat.Controls.Add(this.panel15);
            this.tabScrapCat.Controls.Add(this.groupBox1);
            this.tabScrapCat.Controls.Add(this.panel14);
            this.tabScrapCat.Controls.Add(this.panel10);
            this.tabScrapCat.Location = new System.Drawing.Point(4, 22);
            this.tabScrapCat.Name = "tabScrapCat";
            this.tabScrapCat.Size = new System.Drawing.Size(797, 503);
            this.tabScrapCat.TabIndex = 3;
            this.tabScrapCat.Text = "Scrap Through Category";
            // 
            // lblSearchInfo
            // 
            this.lblSearchInfo.AutoSize = true;
            this.lblSearchInfo.Location = new System.Drawing.Point(212, 90);
            this.lblSearchInfo.Name = "lblSearchInfo";
            this.lblSearchInfo.Size = new System.Drawing.Size(479, 13);
            this.lblSearchInfo.TabIndex = 31;
            this.lblSearchInfo.Text = "Here You select the Categories which you want to &Scrap and Click on Start after " +
    "Selecting Categries";
            // 
            // GroupBoxScrappingLogs
            // 
            this.GroupBoxScrappingLogs.Location = new System.Drawing.Point(551, 116);
            this.GroupBoxScrappingLogs.Margin = new System.Windows.Forms.Padding(2);
            this.GroupBoxScrappingLogs.Name = "GroupBoxScrappingLogs";
            this.GroupBoxScrappingLogs.Padding = new System.Windows.Forms.Padding(2);
            this.GroupBoxScrappingLogs.Size = new System.Drawing.Size(239, 360);
            this.GroupBoxScrappingLogs.TabIndex = 30;
            this.GroupBoxScrappingLogs.TabStop = false;
            this.GroupBoxScrappingLogs.Text = "Scrapping Logs";
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.lblItemName);
            this.panel15.Location = new System.Drawing.Point(215, 329);
            this.panel15.Margin = new System.Windows.Forms.Padding(2);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(328, 146);
            this.panel15.TabIndex = 29;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(9, 15);
            this.lblItemName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(297, 13);
            this.lblItemName.TabIndex = 1;
            this.lblItemName.Text = "\"Multifunctional Vegetable Cutter Fruit Slicer Grater Shredders";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnScrapStop);
            this.groupBox1.Controls.Add(this.btnScrappingStart);
            this.groupBox1.Controls.Add(this.txtProductMaxPrice);
            this.groupBox1.Controls.Add(this.lblMaxPrice);
            this.groupBox1.Controls.Add(this.lblminPrice);
            this.groupBox1.Controls.Add(this.txtProductMinPrice);
            this.groupBox1.Controls.Add(this.lblProductPrice);
            this.groupBox1.Controls.Add(this.txtSoldValueInput);
            this.groupBox1.Controls.Add(this.lblEnterSoldPro);
            this.groupBox1.Location = new System.Drawing.Point(215, 116);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(328, 206);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Criteria";
            // 
            // btnScrapStop
            // 
            this.btnScrapStop.BackColor = System.Drawing.Color.Crimson;
            this.btnScrapStop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnScrapStop.Location = new System.Drawing.Point(174, 158);
            this.btnScrapStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnScrapStop.Name = "btnScrapStop";
            this.btnScrapStop.Size = new System.Drawing.Size(64, 29);
            this.btnScrapStop.TabIndex = 9;
            this.btnScrapStop.Text = "Stop";
            this.btnScrapStop.UseVisualStyleBackColor = false;
            this.btnScrapStop.Click += new System.EventHandler(this.btnScrapStop_Click);
            // 
            // btnScrappingStart
            // 
            this.btnScrappingStart.BackColor = System.Drawing.Color.SeaGreen;
            this.btnScrappingStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnScrappingStart.Location = new System.Drawing.Point(242, 158);
            this.btnScrappingStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnScrappingStart.Name = "btnScrappingStart";
            this.btnScrappingStart.Size = new System.Drawing.Size(64, 29);
            this.btnScrappingStart.TabIndex = 8;
            this.btnScrappingStart.Text = "&Start";
            this.btnScrappingStart.UseVisualStyleBackColor = false;
            this.btnScrappingStart.Click += new System.EventHandler(this.ScrappingStart_Click);
            // 
            // txtProductMaxPrice
            // 
            this.txtProductMaxPrice.Location = new System.Drawing.Point(44, 128);
            this.txtProductMaxPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtProductMaxPrice.Name = "txtProductMaxPrice";
            this.txtProductMaxPrice.Size = new System.Drawing.Size(123, 20);
            this.txtProductMaxPrice.TabIndex = 7;
            // 
            // lblMaxPrice
            // 
            this.lblMaxPrice.AutoSize = true;
            this.lblMaxPrice.Location = new System.Drawing.Point(13, 131);
            this.lblMaxPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxPrice.Name = "lblMaxPrice";
            this.lblMaxPrice.Size = new System.Drawing.Size(27, 13);
            this.lblMaxPrice.TabIndex = 5;
            this.lblMaxPrice.Text = "Max";
            // 
            // lblminPrice
            // 
            this.lblminPrice.AutoSize = true;
            this.lblminPrice.Location = new System.Drawing.Point(13, 102);
            this.lblminPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblminPrice.Name = "lblminPrice";
            this.lblminPrice.Size = new System.Drawing.Size(24, 13);
            this.lblminPrice.TabIndex = 4;
            this.lblminPrice.Text = "Min";
            // 
            // txtProductMinPrice
            // 
            this.txtProductMinPrice.Location = new System.Drawing.Point(44, 100);
            this.txtProductMinPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtProductMinPrice.Name = "txtProductMinPrice";
            this.txtProductMinPrice.Size = new System.Drawing.Size(123, 20);
            this.txtProductMinPrice.TabIndex = 3;
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Location = new System.Drawing.Point(13, 78);
            this.lblProductPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(71, 13);
            this.lblProductPrice.TabIndex = 2;
            this.lblProductPrice.Text = "Product Price";
            // 
            // txtSoldValueInput
            // 
            this.txtSoldValueInput.Location = new System.Drawing.Point(44, 48);
            this.txtSoldValueInput.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoldValueInput.Name = "txtSoldValueInput";
            this.txtSoldValueInput.Size = new System.Drawing.Size(123, 20);
            this.txtSoldValueInput.TabIndex = 1;
            // 
            // lblEnterSoldPro
            // 
            this.lblEnterSoldPro.AutoSize = true;
            this.lblEnterSoldPro.Location = new System.Drawing.Point(13, 29);
            this.lblEnterSoldPro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnterSoldPro.Name = "lblEnterSoldPro";
            this.lblEnterSoldPro.Size = new System.Drawing.Size(51, 13);
            this.lblEnterSoldPro.TabIndex = 0;
            this.lblEnterSoldPro.Text = "Min. Sold";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.SteelBlue;
            this.panel14.Controls.Add(this.checkboxListCat);
            this.panel14.Controls.Add(this.label15);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel14.Location = new System.Drawing.Point(0, 72);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(198, 431);
            this.panel14.TabIndex = 27;
            // 
            // checkboxListCat
            // 
            this.checkboxListCat.BackColor = System.Drawing.Color.SteelBlue;
            this.checkboxListCat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkboxListCat.ForeColor = System.Drawing.SystemColors.Window;
            this.checkboxListCat.FormattingEnabled = true;
            this.checkboxListCat.Location = new System.Drawing.Point(3, 53);
            this.checkboxListCat.Name = "checkboxListCat";
            this.checkboxListCat.Size = new System.Drawing.Size(192, 375);
            this.checkboxListCat.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(6, 18);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 24);
            this.label15.TabIndex = 17;
            this.label15.Text = "Categories";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.SteelBlue;
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Controls.Add(this.panel12);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(797, 72);
            this.panel10.TabIndex = 26;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            this.panel11.Controls.Add(this.label7);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(198, 72);
            this.panel11.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("LibraryGothicExtraBold", 19F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(10, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 34);
            this.label7.TabIndex = 1;
            this.label7.Text = "SCRAP DATA";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btnExportExcell);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel12.Location = new System.Drawing.Point(644, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(153, 72);
            this.panel12.TabIndex = 1;
            // 
            // btnExportExcell
            // 
            this.btnExportExcell.BackColor = System.Drawing.Color.AliceBlue;
            this.btnExportExcell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportExcell.FlatAppearance.BorderSize = 0;
            this.btnExportExcell.Location = new System.Drawing.Point(32, 21);
            this.btnExportExcell.Name = "btnExportExcell";
            this.btnExportExcell.Size = new System.Drawing.Size(98, 35);
            this.btnExportExcell.TabIndex = 0;
            this.btnExportExcell.Text = "&Export Excel";
            this.btnExportExcell.UseVisualStyleBackColor = false;
            this.btnExportExcell.Click += new System.EventHandler(this.btnExportExcell_Click);
            // 
            // pnlScrapItemByName
            // 
            this.pnlScrapItemByName.Controls.Add(this.panel19);
            this.pnlScrapItemByName.Controls.Add(this.lblScrapNameItemsInfo);
            this.pnlScrapItemByName.Controls.Add(this.panel18);
            this.pnlScrapItemByName.Controls.Add(this.panel9);
            this.pnlScrapItemByName.Location = new System.Drawing.Point(4, 22);
            this.pnlScrapItemByName.Name = "pnlScrapItemByName";
            this.pnlScrapItemByName.Padding = new System.Windows.Forms.Padding(3);
            this.pnlScrapItemByName.Size = new System.Drawing.Size(797, 503);
            this.pnlScrapItemByName.TabIndex = 4;
            this.pnlScrapItemByName.Text = "Scrap Through Name";
            this.pnlScrapItemByName.UseVisualStyleBackColor = true;
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.GrpBoxItemNameScrap);
            this.panel19.Location = new System.Drawing.Point(207, 139);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(564, 358);
            this.panel19.TabIndex = 41;
            // 
            // GrpBoxItemNameScrap
            // 
            this.GrpBoxItemNameScrap.Controls.Add(this.txtMinimumPrice);
            this.GrpBoxItemNameScrap.Controls.Add(this.txtSoldItems);
            this.GrpBoxItemNameScrap.Controls.Add(this.lblminimumprice);
            this.GrpBoxItemNameScrap.Controls.Add(this.lblMinSold);
            this.GrpBoxItemNameScrap.Controls.Add(this.button2);
            this.GrpBoxItemNameScrap.Controls.Add(this.btnScrpingData);
            this.GrpBoxItemNameScrap.Controls.Add(this.lblItemNam);
            this.GrpBoxItemNameScrap.Controls.Add(this.txtItemName);
            this.GrpBoxItemNameScrap.Location = new System.Drawing.Point(0, 0);
            this.GrpBoxItemNameScrap.Name = "GrpBoxItemNameScrap";
            this.GrpBoxItemNameScrap.Size = new System.Drawing.Size(564, 361);
            this.GrpBoxItemNameScrap.TabIndex = 0;
            this.GrpBoxItemNameScrap.TabStop = false;
            this.GrpBoxItemNameScrap.Text = "Scrap Data";
            // 
            // txtMinimumPrice
            // 
            this.txtMinimumPrice.Location = new System.Drawing.Point(159, 113);
            this.txtMinimumPrice.Name = "txtMinimumPrice";
            this.txtMinimumPrice.Size = new System.Drawing.Size(153, 20);
            this.txtMinimumPrice.TabIndex = 48;
            // 
            // txtSoldItems
            // 
            this.txtSoldItems.Location = new System.Drawing.Point(159, 77);
            this.txtSoldItems.Name = "txtSoldItems";
            this.txtSoldItems.Size = new System.Drawing.Size(153, 20);
            this.txtSoldItems.TabIndex = 45;
            // 
            // lblminimumprice
            // 
            this.lblminimumprice.AutoSize = true;
            this.lblminimumprice.Location = new System.Drawing.Point(19, 116);
            this.lblminimumprice.Name = "lblminimumprice";
            this.lblminimumprice.Size = new System.Drawing.Size(109, 13);
            this.lblminimumprice.TabIndex = 47;
            this.lblminimumprice.Text = "Enter Minimum Price: ";
            // 
            // lblMinSold
            // 
            this.lblMinSold.AutoSize = true;
            this.lblMinSold.Location = new System.Drawing.Point(19, 80);
            this.lblMinSold.Name = "lblMinSold";
            this.lblMinSold.Size = new System.Drawing.Size(134, 13);
            this.lblMinSold.TabIndex = 42;
            this.lblMinSold.Text = "Enter Minimum Sold Items: \r\n";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(186, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 31);
            this.button2.TabIndex = 46;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnScrpingData
            // 
            this.btnScrpingData.BackColor = System.Drawing.Color.Green;
            this.btnScrpingData.FlatAppearance.BorderSize = 0;
            this.btnScrpingData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnScrpingData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScrpingData.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScrpingData.ForeColor = System.Drawing.Color.White;
            this.btnScrpingData.Location = new System.Drawing.Point(249, 149);
            this.btnScrpingData.Name = "btnScrpingData";
            this.btnScrpingData.Size = new System.Drawing.Size(63, 31);
            this.btnScrpingData.TabIndex = 46;
            this.btnScrpingData.Text = "Scrap";
            this.btnScrpingData.UseVisualStyleBackColor = false;
            // 
            // lblItemNam
            // 
            this.lblItemNam.AutoSize = true;
            this.lblItemNam.Location = new System.Drawing.Point(19, 45);
            this.lblItemNam.Name = "lblItemNam";
            this.lblItemNam.Size = new System.Drawing.Size(92, 13);
            this.lblItemNam.TabIndex = 43;
            this.lblItemNam.Text = "Enter Item Name: ";
            // 
            // txtItemName
            // 
            this.txtItemName.AllowDrop = true;
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemName.Location = new System.Drawing.Point(159, 42);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(153, 20);
            this.txtItemName.TabIndex = 44;
            // 
            // lblScrapNameItemsInfo
            // 
            this.lblScrapNameItemsInfo.AutoSize = true;
            this.lblScrapNameItemsInfo.Location = new System.Drawing.Point(210, 112);
            this.lblScrapNameItemsInfo.Name = "lblScrapNameItemsInfo";
            this.lblScrapNameItemsInfo.Size = new System.Drawing.Size(351, 13);
            this.lblScrapNameItemsInfo.TabIndex = 40;
            this.lblScrapNameItemsInfo.Text = "Here You enter Items name which you want to Scrap and click on Scrap.";
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.SteelBlue;
            this.panel18.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel18.Location = new System.Drawing.Point(3, 75);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(198, 425);
            this.panel18.TabIndex = 28;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.SteelBlue;
            this.panel9.Controls.Add(this.panel16);
            this.panel9.Controls.Add(this.panel17);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(3, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(791, 72);
            this.panel9.TabIndex = 27;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            this.panel16.Controls.Add(this.label20);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel16.Location = new System.Drawing.Point(0, 0);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(198, 72);
            this.panel16.TabIndex = 2;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("LibraryGothicExtraBold", 19F);
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label20.Location = new System.Drawing.Point(15, 16);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(169, 34);
            this.label20.TabIndex = 1;
            this.label20.Text = "SCRAP DATA";
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.button1);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel17.Location = new System.Drawing.Point(638, 0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(153, 72);
            this.panel17.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateGray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(32, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "&Export Excel";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // tabBrands
            // 
            this.tabBrands.BackColor = System.Drawing.Color.White;
            this.tabBrands.Controls.Add(this.Brands);
            this.tabBrands.Controls.Add(this.dataGridView2);
            this.tabBrands.Controls.Add(this.panel13);
            this.tabBrands.Controls.Add(this.panel7);
            this.tabBrands.Location = new System.Drawing.Point(4, 22);
            this.tabBrands.Name = "tabBrands";
            this.tabBrands.Padding = new System.Windows.Forms.Padding(3);
            this.tabBrands.Size = new System.Drawing.Size(797, 503);
            this.tabBrands.TabIndex = 2;
            this.tabBrands.Text = "Skip Brands KeyWords";
            // 
            // Brands
            // 
            this.Brands.Controls.Add(this.lblBrandsSomeDetail);
            this.Brands.Controls.Add(this.btnBrandSave);
            this.Brands.Controls.Add(this.btnBrandDel);
            this.Brands.Controls.Add(this.btnBrandEdit);
            this.Brands.Controls.Add(this.lblBrandName);
            this.Brands.Controls.Add(this.lblBrandID);
            this.Brands.Controls.Add(this.txtBrandName);
            this.Brands.Controls.Add(this.txtBrandID);
            this.Brands.Location = new System.Drawing.Point(207, 81);
            this.Brands.Name = "Brands";
            this.Brands.Size = new System.Drawing.Size(582, 153);
            this.Brands.TabIndex = 24;
            // 
            // lblBrandsSomeDetail
            // 
            this.lblBrandsSomeDetail.AutoSize = true;
            this.lblBrandsSomeDetail.Location = new System.Drawing.Point(9, 14);
            this.lblBrandsSomeDetail.Name = "lblBrandsSomeDetail";
            this.lblBrandsSomeDetail.Size = new System.Drawing.Size(315, 13);
            this.lblBrandsSomeDetail.TabIndex = 12;
            this.lblBrandsSomeDetail.Text = "Here You Are Add those Brands Which you didn\'t want to Search";
            // 
            // btnBrandSave
            // 
            this.btnBrandSave.BackColor = System.Drawing.Color.Crimson;
            this.btnBrandSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBrandSave.Location = new System.Drawing.Point(96, 100);
            this.btnBrandSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrandSave.Name = "btnBrandSave";
            this.btnBrandSave.Size = new System.Drawing.Size(61, 29);
            this.btnBrandSave.TabIndex = 11;
            this.btnBrandSave.Text = "Save";
            this.btnBrandSave.UseVisualStyleBackColor = false;
            this.btnBrandSave.Click += new System.EventHandler(this.Save_Brands_Click);
            // 
            // btnBrandDel
            // 
            this.btnBrandDel.BackColor = System.Drawing.Color.Crimson;
            this.btnBrandDel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBrandDel.Location = new System.Drawing.Point(161, 100);
            this.btnBrandDel.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrandDel.Name = "btnBrandDel";
            this.btnBrandDel.Size = new System.Drawing.Size(61, 29);
            this.btnBrandDel.TabIndex = 11;
            this.btnBrandDel.Text = "Delete";
            this.btnBrandDel.UseVisualStyleBackColor = false;
            this.btnBrandDel.Click += new System.EventHandler(this.Del_Brand_Btn_Click);
            // 
            // btnBrandEdit
            // 
            this.btnBrandEdit.BackColor = System.Drawing.Color.SeaGreen;
            this.btnBrandEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBrandEdit.Location = new System.Drawing.Point(226, 100);
            this.btnBrandEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrandEdit.Name = "btnBrandEdit";
            this.btnBrandEdit.Size = new System.Drawing.Size(61, 29);
            this.btnBrandEdit.TabIndex = 10;
            this.btnBrandEdit.Text = "Edit";
            this.btnBrandEdit.UseVisualStyleBackColor = false;
            this.btnBrandEdit.Click += new System.EventHandler(this.Brand_Edit_Click);
            // 
            // lblBrandName
            // 
            this.lblBrandName.AutoSize = true;
            this.lblBrandName.Location = new System.Drawing.Point(9, 78);
            this.lblBrandName.Name = "lblBrandName";
            this.lblBrandName.Size = new System.Drawing.Size(72, 13);
            this.lblBrandName.TabIndex = 3;
            this.lblBrandName.Text = "Brand Name: ";
            // 
            // lblBrandID
            // 
            this.lblBrandID.AutoSize = true;
            this.lblBrandID.Location = new System.Drawing.Point(9, 50);
            this.lblBrandID.Name = "lblBrandID";
            this.lblBrandID.Size = new System.Drawing.Size(55, 13);
            this.lblBrandID.TabIndex = 2;
            this.lblBrandID.Text = "Brand ID: ";
            // 
            // txtBrandName
            // 
            this.txtBrandName.Location = new System.Drawing.Point(101, 71);
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.Size = new System.Drawing.Size(185, 20);
            this.txtBrandName.TabIndex = 1;
            // 
            // txtBrandID
            // 
            this.txtBrandID.Location = new System.Drawing.Point(101, 43);
            this.txtBrandID.Name = "txtBrandID";
            this.txtBrandID.Size = new System.Drawing.Size(185, 20);
            this.txtBrandID.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brandIDDataGridViewTextBoxColumn,
            this.brandNameDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.brandTableBindingSource;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView2.Location = new System.Drawing.Point(206, 240);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(583, 254);
            this.dataGridView2.TabIndex = 23;
            // 
            // brandIDDataGridViewTextBoxColumn
            // 
            this.brandIDDataGridViewTextBoxColumn.DataPropertyName = "Brand_ID";
            this.brandIDDataGridViewTextBoxColumn.HeaderText = "Brand_ID";
            this.brandIDDataGridViewTextBoxColumn.Name = "brandIDDataGridViewTextBoxColumn";
            // 
            // brandNameDataGridViewTextBoxColumn
            // 
            this.brandNameDataGridViewTextBoxColumn.DataPropertyName = "Brand_Name";
            this.brandNameDataGridViewTextBoxColumn.HeaderText = "Brand_Name";
            this.brandNameDataGridViewTextBoxColumn.Name = "brandNameDataGridViewTextBoxColumn";
            // 
            // brandTableBindingSource
            // 
            this.brandTableBindingSource.DataMember = "Brand_Table";
            this.brandTableBindingSource.DataSource = this.scrapeTestDataSetBrandTable;
            // 
            // scrapeTestDataSetBrandTable
            // 
            this.scrapeTestDataSetBrandTable.DataSetName = "ScrapeTestDataSetBrandTable";
            this.scrapeTestDataSetBrandTable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.SteelBlue;
            this.panel13.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel13.Location = new System.Drawing.Point(3, 75);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(198, 425);
            this.panel13.TabIndex = 22;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.SteelBlue;
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(791, 72);
            this.panel7.TabIndex = 21;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            this.panel8.Controls.Add(this.label6);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(198, 72);
            this.panel8.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("LibraryGothicExtraBold", 19F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(15, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 34);
            this.label6.TabIndex = 1;
            this.label6.Text = "SCRAP DATA";
            // 
            // tabCategories
            // 
            this.tabCategories.BackColor = System.Drawing.Color.White;
            this.tabCategories.Controls.Add(this.panel5);
            this.tabCategories.Controls.Add(this.panel6);
            this.tabCategories.Controls.Add(this.panel4);
            this.tabCategories.Controls.Add(this.GridViewCat);
            this.tabCategories.Location = new System.Drawing.Point(4, 22);
            this.tabCategories.Name = "tabCategories";
            this.tabCategories.Padding = new System.Windows.Forms.Padding(3);
            this.tabCategories.Size = new System.Drawing.Size(797, 503);
            this.tabCategories.TabIndex = 1;
            this.tabCategories.Text = "Categories";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnCatSave);
            this.panel5.Controls.Add(this.btnCatDelete);
            this.panel5.Controls.Add(this.btnCatEdit);
            this.panel5.Controls.Add(this.lblCatName);
            this.panel5.Controls.Add(this.lblCatID);
            this.panel5.Controls.Add(this.txtCatName);
            this.panel5.Controls.Add(this.txtCatID);
            this.panel5.Location = new System.Drawing.Point(208, 82);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(581, 155);
            this.panel5.TabIndex = 22;
            // 
            // btnCatSave
            // 
            this.btnCatSave.BackColor = System.Drawing.Color.Crimson;
            this.btnCatSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCatSave.Location = new System.Drawing.Point(98, 102);
            this.btnCatSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnCatSave.Name = "btnCatSave";
            this.btnCatSave.Size = new System.Drawing.Size(61, 29);
            this.btnCatSave.TabIndex = 14;
            this.btnCatSave.Text = "&Save";
            this.btnCatSave.UseVisualStyleBackColor = false;
            this.btnCatSave.Click += new System.EventHandler(this.SaveCategory_Click);
            // 
            // btnCatDelete
            // 
            this.btnCatDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnCatDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCatDelete.Location = new System.Drawing.Point(163, 102);
            this.btnCatDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnCatDelete.Name = "btnCatDelete";
            this.btnCatDelete.Size = new System.Drawing.Size(61, 29);
            this.btnCatDelete.TabIndex = 13;
            this.btnCatDelete.Text = "Delete";
            this.btnCatDelete.UseVisualStyleBackColor = false;
            this.btnCatDelete.Click += new System.EventHandler(this.Del_Category_Btn_Click);
            // 
            // btnCatEdit
            // 
            this.btnCatEdit.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCatEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCatEdit.Location = new System.Drawing.Point(228, 102);
            this.btnCatEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnCatEdit.Name = "btnCatEdit";
            this.btnCatEdit.Size = new System.Drawing.Size(61, 29);
            this.btnCatEdit.TabIndex = 12;
            this.btnCatEdit.Text = "Edit";
            this.btnCatEdit.UseVisualStyleBackColor = false;
            this.btnCatEdit.Click += new System.EventHandler(this.Category_Edit_Click);
            // 
            // lblCatName
            // 
            this.lblCatName.AutoSize = true;
            this.lblCatName.Location = new System.Drawing.Point(12, 69);
            this.lblCatName.Name = "lblCatName";
            this.lblCatName.Size = new System.Drawing.Size(86, 13);
            this.lblCatName.TabIndex = 3;
            this.lblCatName.Text = "Category Name: ";
            // 
            // lblCatID
            // 
            this.lblCatID.AutoSize = true;
            this.lblCatID.Location = new System.Drawing.Point(12, 32);
            this.lblCatID.Name = "lblCatID";
            this.lblCatID.Size = new System.Drawing.Size(69, 13);
            this.lblCatID.TabIndex = 2;
            this.lblCatID.Text = "Category ID: ";
            // 
            // txtCatName
            // 
            this.txtCatName.Location = new System.Drawing.Point(104, 62);
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.Size = new System.Drawing.Size(185, 20);
            this.txtCatName.TabIndex = 1;
            // 
            // txtCatID
            // 
            this.txtCatID.Location = new System.Drawing.Point(104, 25);
            this.txtCatID.Name = "txtCatID";
            this.txtCatID.Size = new System.Drawing.Size(185, 20);
            this.txtCatID.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SteelBlue;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(3, 75);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(198, 425);
            this.panel6.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(791, 72);
            this.panel4.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 72);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LibraryGothicExtraBold", 19F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "SCRAP DATA";
            // 
            // GridViewCat
            // 
            this.GridViewCat.AutoGenerateColumns = false;
            this.GridViewCat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridViewCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewCat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryIDDataGridViewTextBoxColumn,
            this.categoryNameDataGridViewTextBoxColumn});
            this.GridViewCat.DataSource = this.categoryTableBindingSource;
            this.GridViewCat.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GridViewCat.Location = new System.Drawing.Point(207, 243);
            this.GridViewCat.Name = "GridViewCat";
            this.GridViewCat.RowHeadersVisible = false;
            this.GridViewCat.Size = new System.Drawing.Size(582, 252);
            this.GridViewCat.TabIndex = 19;
            // 
            // categoryIDDataGridViewTextBoxColumn
            // 
            this.categoryIDDataGridViewTextBoxColumn.DataPropertyName = "CategoryID";
            this.categoryIDDataGridViewTextBoxColumn.HeaderText = "CategoryID";
            this.categoryIDDataGridViewTextBoxColumn.Name = "categoryIDDataGridViewTextBoxColumn";
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "Category_Name";
            this.categoryNameDataGridViewTextBoxColumn.HeaderText = "Category_Name";
            this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            // 
            // categoryTableBindingSource
            // 
            this.categoryTableBindingSource.DataMember = "Category_Table";
            this.categoryTableBindingSource.DataSource = this.scrapeTestDataSetCategories;
            // 
            // scrapeTestDataSetCategories
            // 
            this.scrapeTestDataSetCategories.DataSetName = "ScrapeTestDataSetCategories";
            this.scrapeTestDataSetCategories.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabHome
            // 
            this.tabHome.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tabHome.Controls.Add(this.panel2);
            this.tabHome.Location = new System.Drawing.Point(4, 22);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(797, 503);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(791, 497);
            this.panel2.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Takeout", 40.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(210, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(351, 58);
            this.label5.TabIndex = 1;
            this.label5.Text = "WELCOME";
            // 
            // category_TableTableAdapter
            // 
            this.category_TableTableAdapter.ClearBeforeFill = true;
            // 
            // brand_TableTableAdapter
            // 
            this.brand_TableTableAdapter.ClearBeforeFill = true;
            // 
            // ScrapperPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(805, 532);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScrapperPage";
            this.Text = "Srapper Data";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scrapeTestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellerNameScrapeBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabScrapCat.ResumeLayout(false);
            this.tabScrapCat.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.pnlScrapItemByName.ResumeLayout(false);
            this.pnlScrapItemByName.PerformLayout();
            this.panel19.ResumeLayout(false);
            this.GrpBoxItemNameScrap.ResumeLayout(false);
            this.GrpBoxItemNameScrap.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.tabBrands.ResumeLayout(false);
            this.Brands.ResumeLayout(false);
            this.Brands.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scrapeTestDataSetBrandTable)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.tabCategories.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scrapeTestDataSetCategories)).EndInit();
            this.tabHome.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ScrapeTestDataSet scrapeTestDataSet;
        private System.Windows.Forms.BindingSource sellerNameScrapeBindingSource;
        private ScrapeTestDataSetTableAdapters.SellerNameScrapeTableAdapter sellerNameScrapeTableAdapter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabCategories;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView GridViewCat;
        private System.Windows.Forms.TabPage tabBrands;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TabPage tabScrapCat;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btnExportExcell;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox GroupBoxScrappingLogs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnScrapStop;
        private System.Windows.Forms.Button btnScrappingStart;
        private System.Windows.Forms.TextBox txtProductMaxPrice;
        private System.Windows.Forms.Label lblMaxPrice;
        private System.Windows.Forms.Label lblminPrice;
        private System.Windows.Forms.TextBox txtProductMinPrice;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.TextBox txtSoldValueInput;
        private System.Windows.Forms.Label lblEnterSoldPro;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage pnlScrapItemByName;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblCatName;
        private System.Windows.Forms.Label lblCatID;
        private System.Windows.Forms.TextBox txtCatName;
        private System.Windows.Forms.TextBox txtCatID;
        private System.Windows.Forms.Panel Brands;
        private System.Windows.Forms.Button btnBrandSave;
        private System.Windows.Forms.Button btnBrandDel;
        private System.Windows.Forms.Button btnBrandEdit;
        private System.Windows.Forms.Label lblBrandName;
        private System.Windows.Forms.Label lblBrandID;
        private System.Windows.Forms.TextBox txtBrandName;
        private System.Windows.Forms.TextBox txtBrandID;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnCatSave;
        private System.Windows.Forms.Button btnCatDelete;
        private System.Windows.Forms.Button btnCatEdit;
        private ScrapeTestDataSetCategories scrapeTestDataSetCategories;
        private System.Windows.Forms.BindingSource categoryTableBindingSource;
        private ScrapeTestDataSetCategoriesTableAdapters.Category_TableTableAdapter category_TableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private ScrapeTestDataSetBrandTable scrapeTestDataSetBrandTable;
        private System.Windows.Forms.BindingSource brandTableBindingSource;
        private ScrapeTestDataSetBrandTableTableAdapters.Brand_TableTableAdapter brand_TableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox checkboxListCat;
        private System.Windows.Forms.Label lblSearchInfo;
        private System.Windows.Forms.Label lblScrapNameItemsInfo;
        private System.Windows.Forms.Label lblBrandsSomeDetail;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.GroupBox GrpBoxItemNameScrap;
        private System.Windows.Forms.TextBox txtMinimumPrice;
        private System.Windows.Forms.TextBox txtSoldItems;
        private System.Windows.Forms.Label lblminimumprice;
        private System.Windows.Forms.Label lblMinSold;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnScrpingData;
        private System.Windows.Forms.Label lblItemNam;
        private System.Windows.Forms.TextBox txtItemName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}


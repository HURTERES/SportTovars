namespace СУБД__Спортивные_товары_
{
    partial class FormAddEdit
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
            System.Windows.Forms.Label productArticleNumberLabel;
            System.Windows.Forms.Label productNameLabel;
            System.Windows.Forms.Label productQuantityInStockLabel;
            System.Windows.Forms.Label unitLabel;
            System.Windows.Forms.Label productCostLabel;
            System.Windows.Forms.Label productDescriptionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddEdit));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sporttovBAUDataSet1 = new СУБД__Спортивные_товары_.SporttovBAUDataSet();
            this.BsProduct = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new СУБД__Спортивные_товары_.SporttovBAUDataSetTableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new СУБД__Спортивные_товары_.SporttovBAUDataSetTableAdapters.TableAdapterManager();
            this.categoryTableAdapter = new СУБД__Спортивные_товары_.SporttovBAUDataSetTableAdapters.CategoryTableAdapter();
            this.manufacturerTableAdapter = new СУБД__Спортивные_товары_.SporttovBAUDataSetTableAdapters.ManufacturerTableAdapter();
            this.providerTableAdapter = new СУБД__Спортивные_товары_.SporttovBAUDataSetTableAdapters.ProviderTableAdapter();
            this.TbxArticul = new System.Windows.Forms.TextBox();
            this.TbxName = new System.Windows.Forms.TextBox();
            this.TbxCount = new System.Windows.Forms.TextBox();
            this.TbxUnit = new System.Windows.Forms.TextBox();
            this.TbxCost = new System.Windows.Forms.TextBox();
            this.TbxDescription = new System.Windows.Forms.TextBox();
            this.BtnDel = new System.Windows.Forms.Button();
            this.BtnCansel = new System.Windows.Forms.Button();
            this.PbxPhoto = new System.Windows.Forms.PictureBox();
            this.BtnLoadPhoto = new System.Windows.Forms.Button();
            this.LblPhoto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbCatigori = new System.Windows.Forms.ComboBox();
            this.BsCatigor = new System.Windows.Forms.BindingSource(this.components);
            this.CmbManufacturer = new System.Windows.Forms.ComboBox();
            this.BsManufacturer = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.CmbProvider = new System.Windows.Forms.ComboBox();
            this.BsProvider = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.OfdPhoto = new System.Windows.Forms.OpenFileDialog();
            this.BsProductCheckArticul = new System.Windows.Forms.BindingSource(this.components);
            productArticleNumberLabel = new System.Windows.Forms.Label();
            productNameLabel = new System.Windows.Forms.Label();
            productQuantityInStockLabel = new System.Windows.Forms.Label();
            unitLabel = new System.Windows.Forms.Label();
            productCostLabel = new System.Windows.Forms.Label();
            productDescriptionLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sporttovBAUDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsCatigor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsManufacturer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsProductCheckArticul)).BeginInit();
            this.SuspendLayout();
            // 
            // productArticleNumberLabel
            // 
            productArticleNumberLabel.AutoSize = true;
            productArticleNumberLabel.Location = new System.Drawing.Point(92, 126);
            productArticleNumberLabel.Name = "productArticleNumberLabel";
            productArticleNumberLabel.Size = new System.Drawing.Size(81, 23);
            productArticleNumberLabel.TabIndex = 1;
            productArticleNumberLabel.Text = "Артикул:";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new System.Drawing.Point(88, 162);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new System.Drawing.Size(85, 23);
            productNameLabel.TabIndex = 3;
            productNameLabel.Text = "Название:";
            // 
            // productQuantityInStockLabel
            // 
            productQuantityInStockLabel.AutoSize = true;
            productQuantityInStockLabel.Location = new System.Drawing.Point(27, 198);
            productQuantityInStockLabel.Name = "productQuantityInStockLabel";
            productQuantityInStockLabel.Size = new System.Drawing.Size(146, 23);
            productQuantityInStockLabel.TabIndex = 5;
            productQuantityInStockLabel.Text = "Кол-во на складе:";
            // 
            // unitLabel
            // 
            unitLabel.AutoSize = true;
            unitLabel.Location = new System.Drawing.Point(8, 234);
            unitLabel.Name = "unitLabel";
            unitLabel.Size = new System.Drawing.Size(165, 23);
            unitLabel.TabIndex = 7;
            unitLabel.Text = "Еденица измерения:";
            // 
            // productCostLabel
            // 
            productCostLabel.AutoSize = true;
            productCostLabel.Location = new System.Drawing.Point(76, 270);
            productCostLabel.Name = "productCostLabel";
            productCostLabel.Size = new System.Drawing.Size(97, 23);
            productCostLabel.TabIndex = 9;
            productCostLabel.Text = "Стоимость:";
            // 
            // productDescriptionLabel
            // 
            productDescriptionLabel.AutoSize = true;
            productDescriptionLabel.Location = new System.Drawing.Point(82, 306);
            productDescriptionLabel.Name = "productDescriptionLabel";
            productDescriptionLabel.Size = new System.Drawing.Size(91, 23);
            productDescriptionLabel.TabIndex = 11;
            productDescriptionLabel.Text = "Описание:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.LblText);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1037, 111);
            this.panel1.TabIndex = 1;
            // 
            // LblText
            // 
            this.LblText.AutoSize = true;
            this.LblText.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblText.ForeColor = System.Drawing.Color.White;
            this.LblText.Location = new System.Drawing.Point(430, 29);
            this.LblText.Name = "LblText";
            this.LblText.Size = new System.Drawing.Size(55, 38);
            this.LblText.TabIndex = 1;
            this.LblText.Text = "Lbl";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::СУБД__Спортивные_товары_.Properties.Resources.SportLogo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // sporttovBAUDataSet1
            // 
            this.sporttovBAUDataSet1.DataSetName = "SporttovBAUDataSet";
            this.sporttovBAUDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BsProduct
            // 
            this.BsProduct.DataMember = "Product";
            this.BsProduct.DataSource = this.sporttovBAUDataSet1;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = this.categoryTableAdapter;
            this.tableAdapterManager.ManufacturerTableAdapter = this.manufacturerTableAdapter;
            this.tableAdapterManager.OrderProductTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.PickapPointTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.ProviderTableAdapter = this.providerTableAdapter;
            this.tableAdapterManager.RoleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = СУБД__Спортивные_товары_.SporttovBAUDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // manufacturerTableAdapter
            // 
            this.manufacturerTableAdapter.ClearBeforeFill = true;
            // 
            // providerTableAdapter
            // 
            this.providerTableAdapter.ClearBeforeFill = true;
            // 
            // TbxArticul
            // 
            this.TbxArticul.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxArticul.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsProduct, "ProductArticleNumber", true));
            this.TbxArticul.Location = new System.Drawing.Point(190, 123);
            this.TbxArticul.Name = "TbxArticul";
            this.TbxArticul.Size = new System.Drawing.Size(100, 30);
            this.TbxArticul.TabIndex = 2;
            // 
            // TbxName
            // 
            this.TbxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsProduct, "ProductName", true));
            this.TbxName.Location = new System.Drawing.Point(190, 159);
            this.TbxName.Name = "TbxName";
            this.TbxName.Size = new System.Drawing.Size(334, 30);
            this.TbxName.TabIndex = 4;
            // 
            // TbxCount
            // 
            this.TbxCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxCount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsProduct, "ProductQuantityInStock", true));
            this.TbxCount.Location = new System.Drawing.Point(190, 195);
            this.TbxCount.Name = "TbxCount";
            this.TbxCount.Size = new System.Drawing.Size(100, 30);
            this.TbxCount.TabIndex = 6;
            // 
            // TbxUnit
            // 
            this.TbxUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxUnit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsProduct, "Unit", true));
            this.TbxUnit.Location = new System.Drawing.Point(190, 231);
            this.TbxUnit.Name = "TbxUnit";
            this.TbxUnit.Size = new System.Drawing.Size(100, 30);
            this.TbxUnit.TabIndex = 8;
            // 
            // TbxCost
            // 
            this.TbxCost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxCost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsProduct, "ProductCost", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.TbxCost.Location = new System.Drawing.Point(190, 267);
            this.TbxCost.Name = "TbxCost";
            this.TbxCost.Size = new System.Drawing.Size(100, 30);
            this.TbxCost.TabIndex = 10;
            // 
            // TbxDescription
            // 
            this.TbxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsProduct, "ProductDescription", true));
            this.TbxDescription.Location = new System.Drawing.Point(190, 303);
            this.TbxDescription.Multiline = true;
            this.TbxDescription.Name = "TbxDescription";
            this.TbxDescription.Size = new System.Drawing.Size(334, 149);
            this.TbxDescription.TabIndex = 12;
            // 
            // BtnDel
            // 
            this.BtnDel.BackColor = System.Drawing.Color.SandyBrown;
            this.BtnDel.ForeColor = System.Drawing.Color.White;
            this.BtnDel.Location = new System.Drawing.Point(86, 482);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(306, 36);
            this.BtnDel.TabIndex = 17;
            this.BtnDel.Text = "Сохранить";
            this.BtnDel.UseVisualStyleBackColor = false;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // BtnCansel
            // 
            this.BtnCansel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCansel.BackColor = System.Drawing.Color.SandyBrown;
            this.BtnCansel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCansel.ForeColor = System.Drawing.Color.White;
            this.BtnCansel.Location = new System.Drawing.Point(677, 482);
            this.BtnCansel.Name = "BtnCansel";
            this.BtnCansel.Size = new System.Drawing.Size(304, 36);
            this.BtnCansel.TabIndex = 18;
            this.BtnCansel.Text = "Отменить";
            this.BtnCansel.UseVisualStyleBackColor = false;
            // 
            // PbxPhoto
            // 
            this.PbxPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbxPhoto.Location = new System.Drawing.Point(564, 120);
            this.PbxPhoto.Name = "PbxPhoto";
            this.PbxPhoto.Size = new System.Drawing.Size(209, 209);
            this.PbxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxPhoto.TabIndex = 19;
            this.PbxPhoto.TabStop = false;
            // 
            // BtnLoadPhoto
            // 
            this.BtnLoadPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLoadPhoto.BackColor = System.Drawing.Color.SandyBrown;
            this.BtnLoadPhoto.ForeColor = System.Drawing.Color.White;
            this.BtnLoadPhoto.Location = new System.Drawing.Point(564, 335);
            this.BtnLoadPhoto.Name = "BtnLoadPhoto";
            this.BtnLoadPhoto.Size = new System.Drawing.Size(209, 36);
            this.BtnLoadPhoto.TabIndex = 20;
            this.BtnLoadPhoto.Text = "Загрузить фотографию";
            this.BtnLoadPhoto.UseVisualStyleBackColor = false;
            this.BtnLoadPhoto.Click += new System.EventHandler(this.BtnLoadPhoto_Click);
            // 
            // LblPhoto
            // 
            this.LblPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPhoto.AutoSize = true;
            this.LblPhoto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsProduct, "ProductPhoto", true));
            this.LblPhoto.Location = new System.Drawing.Point(560, 390);
            this.LblPhoto.Name = "LblPhoto";
            this.LblPhoto.Size = new System.Drawing.Size(53, 23);
            this.LblPhoto.TabIndex = 21;
            this.LblPhoto.Text = "label1";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(803, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "Категория:";
            // 
            // CmbCatigori
            // 
            this.CmbCatigori.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbCatigori.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.BsProduct, "ProductCategory", true));
            this.CmbCatigori.DataSource = this.BsCatigor;
            this.CmbCatigori.DisplayMember = "Name";
            this.CmbCatigori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCatigori.FormattingEnabled = true;
            this.CmbCatigori.Location = new System.Drawing.Point(807, 147);
            this.CmbCatigori.Name = "CmbCatigori";
            this.CmbCatigori.Size = new System.Drawing.Size(219, 31);
            this.CmbCatigori.TabIndex = 23;
            this.CmbCatigori.ValueMember = "IdCategori";
            // 
            // BsCatigor
            // 
            this.BsCatigor.DataMember = "Category";
            this.BsCatigor.DataSource = this.sporttovBAUDataSet1;
            // 
            // CmbManufacturer
            // 
            this.CmbManufacturer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbManufacturer.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.BsProduct, "ProductManufacturer", true));
            this.CmbManufacturer.DataSource = this.BsManufacturer;
            this.CmbManufacturer.DisplayMember = "Name";
            this.CmbManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbManufacturer.FormattingEnabled = true;
            this.CmbManufacturer.Location = new System.Drawing.Point(807, 232);
            this.CmbManufacturer.Name = "CmbManufacturer";
            this.CmbManufacturer.Size = new System.Drawing.Size(219, 31);
            this.CmbManufacturer.TabIndex = 25;
            this.CmbManufacturer.ValueMember = "IdManufacturer";
            // 
            // BsManufacturer
            // 
            this.BsManufacturer.DataMember = "Manufacturer";
            this.BsManufacturer.DataSource = this.sporttovBAUDataSet1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(803, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "Производитель:";
            // 
            // CmbProvider
            // 
            this.CmbProvider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbProvider.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.BsProduct, "ProductProvider", true));
            this.CmbProvider.DataSource = this.BsProvider;
            this.CmbProvider.DisplayMember = "Name";
            this.CmbProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbProvider.FormattingEnabled = true;
            this.CmbProvider.Location = new System.Drawing.Point(807, 325);
            this.CmbProvider.Name = "CmbProvider";
            this.CmbProvider.Size = new System.Drawing.Size(219, 31);
            this.CmbProvider.TabIndex = 27;
            this.CmbProvider.ValueMember = "IdProvider";
            // 
            // BsProvider
            // 
            this.BsProvider.DataMember = "Provider";
            this.BsProvider.DataSource = this.sporttovBAUDataSet1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(803, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 23);
            this.label3.TabIndex = 26;
            this.label3.Text = "Поставщик:";
            // 
            // BsProductCheckArticul
            // 
            this.BsProductCheckArticul.DataMember = "Product";
            this.BsProductCheckArticul.DataSource = this.sporttovBAUDataSet1;
            // 
            // FormAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1037, 537);
            this.Controls.Add(this.CmbProvider);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblPhoto);
            this.Controls.Add(this.CmbManufacturer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbCatigori);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PbxPhoto);
            this.Controls.Add(this.BtnLoadPhoto);
            this.Controls.Add(this.BtnCansel);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(productDescriptionLabel);
            this.Controls.Add(this.TbxDescription);
            this.Controls.Add(productCostLabel);
            this.Controls.Add(this.TbxCost);
            this.Controls.Add(unitLabel);
            this.Controls.Add(this.TbxUnit);
            this.Controls.Add(productQuantityInStockLabel);
            this.Controls.Add(this.TbxCount);
            this.Controls.Add(productNameLabel);
            this.Controls.Add(this.TbxName);
            this.Controls.Add(productArticleNumberLabel);
            this.Controls.Add(this.TbxArticul);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FormAddEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "СУБД Спортивные товары";
            this.Load += new System.EventHandler(this.FormAddEdit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sporttovBAUDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsCatigor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsManufacturer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsProductCheckArticul)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private SporttovBAUDataSet sporttovBAUDataSet1;
        private SporttovBAUDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private SporttovBAUDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox TbxArticul;
        private System.Windows.Forms.TextBox TbxName;
        private System.Windows.Forms.TextBox TbxCount;
        private System.Windows.Forms.TextBox TbxUnit;
        private System.Windows.Forms.TextBox TbxCost;
        private System.Windows.Forms.TextBox TbxDescription;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.Button BtnCansel;
        private System.Windows.Forms.Label LblText;
        public System.Windows.Forms.BindingSource BsProduct;
        private System.Windows.Forms.PictureBox PbxPhoto;
        private System.Windows.Forms.Button BtnLoadPhoto;
        private System.Windows.Forms.Label LblPhoto;
        private SporttovBAUDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbCatigori;
        private System.Windows.Forms.ComboBox CmbManufacturer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbProvider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource BsCatigor;
        private System.Windows.Forms.BindingSource BsManufacturer;
        private System.Windows.Forms.BindingSource BsProvider;
        private SporttovBAUDataSetTableAdapters.ManufacturerTableAdapter manufacturerTableAdapter;
        private SporttovBAUDataSetTableAdapters.ProviderTableAdapter providerTableAdapter;
        private System.Windows.Forms.OpenFileDialog OfdPhoto;
        private System.Windows.Forms.BindingSource BsProductCheckArticul;
    }
}
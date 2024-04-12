namespace СУБД__Спортивные_товары_
{
    partial class FormTovar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTovar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblRole = new System.Windows.Forms.Label();
            this.BSUser = new System.Windows.Forms.BindingSource(this.components);
            this.sporttovBAUDataSet1 = new СУБД__Спортивные_товары_.SporttovBAUDataSet();
            this.LblCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblOtch = new System.Windows.Forms.Label();
            this.LblF = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblFam = new System.Windows.Forms.Label();
            this.DgvProduct = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Photo = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TbxFind = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CbxName = new System.Windows.Forms.CheckBox();
            this.CbxTitle = new System.Windows.Forms.CheckBox();
            this.CbxManuf = new System.Windows.Forms.CheckBox();
            this.CbxPrice = new System.Windows.Forms.CheckBox();
            this.CbxCount = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbManuf = new System.Windows.Forms.ComboBox();
            this.AllManuf = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.productTableAdapter = new СУБД__Спортивные_товары_.SporttovBAUDataSetTableAdapters.ProductTableAdapter();
            this.providerTableAdapter = new СУБД__Спортивные_товары_.SporttovBAUDataSetTableAdapters.ProviderTableAdapter();
            this.userTableAdapter = new СУБД__Спортивные_товары_.SporttovBAUDataSetTableAdapters.UserTableAdapter();
            this.BsProduct = new System.Windows.Forms.BindingSource(this.components);
            this.allManufTableAdapter = new СУБД__Спортивные_товары_.SporttovBAUDataSetTableAdapters.AllManufTableAdapter();
            this.RbtVozr = new System.Windows.Forms.RadioButton();
            this.RbtUbiv = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnDel = new System.Windows.Forms.Button();
            this.BsOrderProduct = new System.Windows.Forms.BindingSource(this.components);
            this.orderProductTableAdapter = new СУБД__Спортивные_товары_.SporttovBAUDataSetTableAdapters.OrderProductTableAdapter();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BSUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sporttovBAUDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllManuf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsOrderProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.LblRole);
            this.panel1.Controls.Add(this.LblCount);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LblOtch);
            this.panel1.Controls.Add(this.LblF);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LblName);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.LblFam);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1078, 111);
            this.panel1.TabIndex = 1;
            // 
            // LblRole
            // 
            this.LblRole.AutoSize = true;
            this.LblRole.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BSUser, "UserRole", true));
            this.LblRole.ForeColor = System.Drawing.Color.White;
            this.LblRole.Location = new System.Drawing.Point(974, 41);
            this.LblRole.Name = "LblRole";
            this.LblRole.Size = new System.Drawing.Size(45, 23);
            this.LblRole.TabIndex = 9;
            this.LblRole.Text = "Роль";
            // 
            // BSUser
            // 
            this.BSUser.DataMember = "User";
            this.BSUser.DataSource = this.sporttovBAUDataSet1;
            // 
            // sporttovBAUDataSet1
            // 
            this.sporttovBAUDataSet1.DataSetName = "SporttovBAUDataSet";
            this.sporttovBAUDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LblCount
            // 
            this.LblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblCount.AutoSize = true;
            this.LblCount.ForeColor = System.Drawing.Color.White;
            this.LblCount.Location = new System.Drawing.Point(493, 41);
            this.LblCount.Name = "LblCount";
            this.LblCount.Size = new System.Drawing.Size(88, 23);
            this.LblCount.TabIndex = 8;
            this.LblCount.Text = "CountRows";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(695, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(723, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Имя";
            // 
            // LblOtch
            // 
            this.LblOtch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblOtch.AutoSize = true;
            this.LblOtch.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BSUser, "UserPatronymic", true));
            this.LblOtch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblOtch.ForeColor = System.Drawing.Color.White;
            this.LblOtch.Location = new System.Drawing.Point(786, 74);
            this.LblOtch.Name = "LblOtch";
            this.LblOtch.Size = new System.Drawing.Size(43, 20);
            this.LblOtch.TabIndex = 5;
            this.LblOtch.Text = "Otch";
            // 
            // LblF
            // 
            this.LblF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblF.AutoSize = true;
            this.LblF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblF.ForeColor = System.Drawing.Color.White;
            this.LblF.Location = new System.Drawing.Point(697, 9);
            this.LblF.Name = "LblF";
            this.LblF.Size = new System.Drawing.Size(81, 20);
            this.LblF.TabIndex = 2;
            this.LblF.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(205, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Товары";
            // 
            // LblName
            // 
            this.LblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblName.AutoSize = true;
            this.LblName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BSUser, "UserName", true));
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblName.ForeColor = System.Drawing.Color.White;
            this.LblName.Location = new System.Drawing.Point(786, 41);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(51, 20);
            this.LblName.TabIndex = 4;
            this.LblName.Text = "Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::СУБД__Спортивные_товары_.Properties.Resources.SportLogo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LblFam
            // 
            this.LblFam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblFam.AutoSize = true;
            this.LblFam.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BSUser, "UserSurname", true));
            this.LblFam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblFam.ForeColor = System.Drawing.Color.White;
            this.LblFam.Location = new System.Drawing.Point(786, 9);
            this.LblFam.Name = "LblFam";
            this.LblFam.Size = new System.Drawing.Size(71, 20);
            this.LblFam.TabIndex = 3;
            this.LblFam.Text = "surname";
            // 
            // DgvProduct
            // 
            this.DgvProduct.AllowUserToAddRows = false;
            this.DgvProduct.AllowUserToDeleteRows = false;
            this.DgvProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvProduct.BackgroundColor = System.Drawing.Color.White;
            this.DgvProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProduct.ColumnHeadersVisible = false;
            this.DgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Photo,
            this.Column1,
            this.Count});
            this.DgvProduct.GridColor = System.Drawing.Color.White;
            this.DgvProduct.Location = new System.Drawing.Point(0, 225);
            this.DgvProduct.MultiSelect = false;
            this.DgvProduct.Name = "DgvProduct";
            this.DgvProduct.ReadOnly = true;
            this.DgvProduct.RowHeadersVisible = false;
            this.DgvProduct.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.DgvProduct.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SandyBrown;
            this.DgvProduct.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvProduct.RowTemplate.DividerHeight = 10;
            this.DgvProduct.RowTemplate.Height = 125;
            this.DgvProduct.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvProduct.Size = new System.Drawing.Size(1078, 324);
            this.DgvProduct.TabIndex = 2;
            this.DgvProduct.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProduct_CellDoubleClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Articul";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Photo
            // 
            this.Photo.HeaderText = "Photo";
            this.Photo.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Photo.Name = "Photo";
            this.Photo.ReadOnly = true;
            this.Photo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Photo.Width = 150;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Product";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Count
            // 
            this.Count.HeaderText = "Count";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TbxFind
            // 
            this.TbxFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxFind.Location = new System.Drawing.Point(150, 190);
            this.TbxFind.Name = "TbxFind";
            this.TbxFind.Size = new System.Drawing.Size(247, 30);
            this.TbxFind.TabIndex = 3;
            this.TbxFind.TextChanged += new System.EventHandler(this.TbxFind_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Поиск по:";
            // 
            // CbxName
            // 
            this.CbxName.AutoSize = true;
            this.CbxName.Location = new System.Drawing.Point(124, 117);
            this.CbxName.Name = "CbxName";
            this.CbxName.Size = new System.Drawing.Size(138, 27);
            this.CbxName.TabIndex = 5;
            this.CbxName.Text = "Нименованию";
            this.CbxName.UseVisualStyleBackColor = true;
            this.CbxName.CheckedChanged += new System.EventHandler(this.CbxName_CheckedChanged);
            // 
            // CbxTitle
            // 
            this.CbxTitle.AutoSize = true;
            this.CbxTitle.Location = new System.Drawing.Point(124, 148);
            this.CbxTitle.Name = "CbxTitle";
            this.CbxTitle.Size = new System.Drawing.Size(111, 27);
            this.CbxTitle.TabIndex = 6;
            this.CbxTitle.Text = "Описанию";
            this.CbxTitle.UseVisualStyleBackColor = true;
            this.CbxTitle.CheckedChanged += new System.EventHandler(this.CbxName_CheckedChanged);
            // 
            // CbxManuf
            // 
            this.CbxManuf.AutoSize = true;
            this.CbxManuf.Location = new System.Drawing.Point(268, 117);
            this.CbxManuf.Name = "CbxManuf";
            this.CbxManuf.Size = new System.Drawing.Size(155, 27);
            this.CbxManuf.TabIndex = 7;
            this.CbxManuf.Text = "Производителю";
            this.CbxManuf.UseVisualStyleBackColor = true;
            this.CbxManuf.CheckedChanged += new System.EventHandler(this.CbxName_CheckedChanged);
            // 
            // CbxPrice
            // 
            this.CbxPrice.AutoSize = true;
            this.CbxPrice.Location = new System.Drawing.Point(241, 146);
            this.CbxPrice.Name = "CbxPrice";
            this.CbxPrice.Size = new System.Drawing.Size(66, 27);
            this.CbxPrice.TabIndex = 8;
            this.CbxPrice.Text = "Цене";
            this.CbxPrice.UseVisualStyleBackColor = true;
            this.CbxPrice.CheckedChanged += new System.EventHandler(this.CbxName_CheckedChanged);
            // 
            // CbxCount
            // 
            this.CbxCount.AutoSize = true;
            this.CbxCount.Location = new System.Drawing.Point(313, 146);
            this.CbxCount.Name = "CbxCount";
            this.CbxCount.Size = new System.Drawing.Size(128, 27);
            this.CbxCount.TabIndex = 9;
            this.CbxCount.Text = "Колличеству";
            this.CbxCount.UseVisualStyleBackColor = true;
            this.CbxCount.CheckedChanged += new System.EventHandler(this.CbxName_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Введите строку:";
            // 
            // CmbManuf
            // 
            this.CmbManuf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbManuf.DataSource = this.AllManuf;
            this.CmbManuf.DisplayMember = "ManufName";
            this.CmbManuf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbManuf.FormattingEnabled = true;
            this.CmbManuf.Location = new System.Drawing.Point(497, 144);
            this.CmbManuf.Name = "CmbManuf";
            this.CmbManuf.Size = new System.Drawing.Size(205, 31);
            this.CmbManuf.TabIndex = 11;
            this.CmbManuf.SelectedIndexChanged += new System.EventHandler(this.CmbManuf_SelectedIndexChanged);
            // 
            // AllManuf
            // 
            this.AllManuf.DataMember = "AllManuf";
            this.AllManuf.DataSource = this.sporttovBAUDataSet1;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(493, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Выберите производителя:";
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // providerTableAdapter
            // 
            this.providerTableAdapter.ClearBeforeFill = true;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // BsProduct
            // 
            this.BsProduct.DataMember = "Product";
            this.BsProduct.DataSource = this.sporttovBAUDataSet1;
            // 
            // allManufTableAdapter
            // 
            this.allManufTableAdapter.ClearBeforeFill = true;
            // 
            // RbtVozr
            // 
            this.RbtVozr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RbtVozr.AutoSize = true;
            this.RbtVozr.Checked = true;
            this.RbtVozr.Location = new System.Drawing.Point(737, 148);
            this.RbtVozr.Name = "RbtVozr";
            this.RbtVozr.Size = new System.Drawing.Size(129, 27);
            this.RbtVozr.TabIndex = 13;
            this.RbtVozr.TabStop = true;
            this.RbtVozr.Text = "Возростанию";
            this.RbtVozr.UseVisualStyleBackColor = true;
            // 
            // RbtUbiv
            // 
            this.RbtUbiv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RbtUbiv.AutoSize = true;
            this.RbtUbiv.Location = new System.Drawing.Point(872, 148);
            this.RbtUbiv.Name = "RbtUbiv";
            this.RbtUbiv.Size = new System.Drawing.Size(108, 27);
            this.RbtUbiv.TabIndex = 14;
            this.RbtUbiv.Text = "Убыванию";
            this.RbtUbiv.UseVisualStyleBackColor = true;
            this.RbtUbiv.CheckedChanged += new System.EventHandler(this.RbtUbiv_CheckedChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(733, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(214, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Сортировка стоимости по:";
            // 
            // BtnDel
            // 
            this.BtnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDel.BackColor = System.Drawing.Color.SandyBrown;
            this.BtnDel.ForeColor = System.Drawing.Color.White;
            this.BtnDel.Location = new System.Drawing.Point(497, 186);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(205, 36);
            this.BtnDel.TabIndex = 16;
            this.BtnDel.Text = "Удалить товар";
            this.BtnDel.UseVisualStyleBackColor = false;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // BsOrderProduct
            // 
            this.BsOrderProduct.DataMember = "OrderProduct";
            this.BsOrderProduct.DataSource = this.sporttovBAUDataSet1;
            // 
            // orderProductTableAdapter
            // 
            this.orderProductTableAdapter.ClearBeforeFill = true;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.BackColor = System.Drawing.Color.SandyBrown;
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(737, 186);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(205, 36);
            this.BtnAdd.TabIndex = 17;
            this.BtnAdd.Text = "Добавить товар";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // FormTovar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1078, 549);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RbtUbiv);
            this.Controls.Add(this.RbtVozr);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CmbManuf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CbxCount);
            this.Controls.Add(this.CbxPrice);
            this.Controls.Add(this.CbxManuf);
            this.Controls.Add(this.CbxTitle);
            this.Controls.Add(this.CbxName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbxFind);
            this.Controls.Add(this.DgvProduct);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(1094, 515);
            this.Name = "FormTovar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "СУБД Спортивные товары";
            this.Load += new System.EventHandler(this.FormTovar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BSUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sporttovBAUDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllManuf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsOrderProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label LblF;
        private SporttovBAUDataSet sporttovBAUDataSet1;
        private SporttovBAUDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.Label LblFam;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblOtch;
        private SporttovBAUDataSetTableAdapters.ProviderTableAdapter providerTableAdapter;
        private SporttovBAUDataSetTableAdapters.UserTableAdapter userTableAdapter;
        public System.Windows.Forms.BindingSource BSUser;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DgvProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn Photo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.TextBox TbxFind;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox CbxName;
        private System.Windows.Forms.CheckBox CbxTitle;
        private System.Windows.Forms.CheckBox CbxManuf;
        private System.Windows.Forms.CheckBox CbxPrice;
        private System.Windows.Forms.CheckBox CbxCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblCount;
        private System.Windows.Forms.BindingSource BsProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource AllManuf;
        private SporttovBAUDataSetTableAdapters.AllManufTableAdapter allManufTableAdapter;
        private System.Windows.Forms.ComboBox CmbManuf;
        private System.Windows.Forms.RadioButton RbtVozr;
        private System.Windows.Forms.RadioButton RbtUbiv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.BindingSource BsOrderProduct;
        private SporttovBAUDataSetTableAdapters.OrderProductTableAdapter orderProductTableAdapter;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label LblRole;
    }
}
namespace СУБД__Спортивные_товары_
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbxLog = new System.Windows.Forms.TextBox();
            this.TbxPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnGuest = new System.Windows.Forms.Button();
            this.sporttovBAUDataSet1 = new СУБД__Спортивные_товары_.SporttovBAUDataSet();
            this.BsUser = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new СУБД__Спортивные_товары_.SporttovBAUDataSetTableAdapters.UserTableAdapter();
            this.PanelImputCapcha = new System.Windows.Forms.Panel();
            this.TbxCapcha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sportTovarDataSet = new СУБД__Спортивные_товары_.SportTovarDataSet();
            this.userTableAdapter1 = new СУБД__Спортивные_товары_.SportTovarDataSetTableAdapters.UserTableAdapter();
            this.PanelCapcha = new System.Windows.Forms.Panel();
            this.LblC4 = new System.Windows.Forms.Label();
            this.LblC2 = new System.Windows.Forms.Label();
            this.LblC3 = new System.Windows.Forms.Label();
            this.LblC1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sporttovBAUDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsUser)).BeginInit();
            this.PanelImputCapcha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sportTovarDataSet)).BeginInit();
            this.PanelCapcha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 111);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(203, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Авторизация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Логин";
            // 
            // TbxLog
            // 
            this.TbxLog.Location = new System.Drawing.Point(32, 172);
            this.TbxLog.Name = "TbxLog";
            this.TbxLog.Size = new System.Drawing.Size(195, 30);
            this.TbxLog.TabIndex = 2;
            // 
            // TbxPass
            // 
            this.TbxPass.Location = new System.Drawing.Point(32, 255);
            this.TbxPass.Name = "TbxPass";
            this.TbxPass.Size = new System.Drawing.Size(195, 30);
            this.TbxPass.TabIndex = 4;
            this.TbxPass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Пароль";
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.SandyBrown;
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.Location = new System.Drawing.Point(32, 314);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(75, 36);
            this.BtnLogin.TabIndex = 5;
            this.BtnLogin.Text = "Войти";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnGuest
            // 
            this.BtnGuest.BackColor = System.Drawing.Color.SandyBrown;
            this.BtnGuest.ForeColor = System.Drawing.Color.White;
            this.BtnGuest.Location = new System.Drawing.Point(186, 314);
            this.BtnGuest.Name = "BtnGuest";
            this.BtnGuest.Size = new System.Drawing.Size(145, 36);
            this.BtnGuest.TabIndex = 6;
            this.BtnGuest.Text = "Войти как гость";
            this.BtnGuest.UseVisualStyleBackColor = false;
            this.BtnGuest.Click += new System.EventHandler(this.BtnGuest_Click);
            // 
            // sporttovBAUDataSet1
            // 
            this.sporttovBAUDataSet1.DataSetName = "SporttovBAUDataSet";
            this.sporttovBAUDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BsUser
            // 
            this.BsUser.DataMember = "User";
            this.BsUser.DataSource = this.sportTovarDataSet;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // PanelImputCapcha
            // 
            this.PanelImputCapcha.Controls.Add(this.TbxCapcha);
            this.PanelImputCapcha.Controls.Add(this.label4);
            this.PanelImputCapcha.Controls.Add(this.PanelCapcha);
            this.PanelImputCapcha.Location = new System.Drawing.Point(269, 146);
            this.PanelImputCapcha.Name = "PanelImputCapcha";
            this.PanelImputCapcha.Size = new System.Drawing.Size(243, 139);
            this.PanelImputCapcha.TabIndex = 7;
            this.PanelImputCapcha.Visible = false;
            // 
            // TbxCapcha
            // 
            this.TbxCapcha.Location = new System.Drawing.Point(134, 102);
            this.TbxCapcha.Name = "TbxCapcha";
            this.TbxCapcha.Size = new System.Drawing.Size(100, 30);
            this.TbxCapcha.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Введите капчу:";
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // sportTovarDataSet
            // 
            this.sportTovarDataSet.DataSetName = "SportTovarDataSet";
            this.sportTovarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTableAdapter1
            // 
            this.userTableAdapter1.ClearBeforeFill = true;
            // 
            // PanelCapcha
            // 
            this.PanelCapcha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelCapcha.BackgroundImage")));
            this.PanelCapcha.Controls.Add(this.LblC4);
            this.PanelCapcha.Controls.Add(this.LblC2);
            this.PanelCapcha.Controls.Add(this.LblC3);
            this.PanelCapcha.Controls.Add(this.LblC1);
            this.PanelCapcha.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelCapcha.Location = new System.Drawing.Point(0, 0);
            this.PanelCapcha.Name = "PanelCapcha";
            this.PanelCapcha.Size = new System.Drawing.Size(243, 95);
            this.PanelCapcha.TabIndex = 0;
            this.PanelCapcha.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelCapcha_Paint);
            // 
            // LblC4
            // 
            this.LblC4.AutoSize = true;
            this.LblC4.BackColor = System.Drawing.Color.Transparent;
            this.LblC4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.LblC4.Location = new System.Drawing.Point(196, 36);
            this.LblC4.Name = "LblC4";
            this.LblC4.Size = new System.Drawing.Size(29, 29);
            this.LblC4.TabIndex = 3;
            this.LblC4.Text = "A";
            // 
            // LblC2
            // 
            this.LblC2.AutoSize = true;
            this.LblC2.BackColor = System.Drawing.Color.Transparent;
            this.LblC2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.LblC2.Location = new System.Drawing.Point(76, 61);
            this.LblC2.Name = "LblC2";
            this.LblC2.Size = new System.Drawing.Size(29, 29);
            this.LblC2.TabIndex = 2;
            this.LblC2.Text = "A";
            // 
            // LblC3
            // 
            this.LblC3.AutoSize = true;
            this.LblC3.BackColor = System.Drawing.Color.Transparent;
            this.LblC3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.LblC3.Location = new System.Drawing.Point(130, 26);
            this.LblC3.Name = "LblC3";
            this.LblC3.Size = new System.Drawing.Size(29, 29);
            this.LblC3.TabIndex = 1;
            this.LblC3.Text = "A";
            // 
            // LblC1
            // 
            this.LblC1.AutoSize = true;
            this.LblC1.BackColor = System.Drawing.Color.Transparent;
            this.LblC1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblC1.Location = new System.Drawing.Point(29, 33);
            this.LblC1.Name = "LblC1";
            this.LblC1.Size = new System.Drawing.Size(29, 29);
            this.LblC1.TabIndex = 0;
            this.LblC1.Text = "A";
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
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(540, 374);
            this.Controls.Add(this.PanelImputCapcha);
            this.Controls.Add(this.BtnGuest);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TbxPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbxLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СУБД Спортивные товары";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sporttovBAUDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsUser)).EndInit();
            this.PanelImputCapcha.ResumeLayout(false);
            this.PanelImputCapcha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sportTovarDataSet)).EndInit();
            this.PanelCapcha.ResumeLayout(false);
            this.PanelCapcha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbxLog;
        private System.Windows.Forms.TextBox TbxPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnGuest;
        private SporttovBAUDataSet sporttovBAUDataSet1;
        private System.Windows.Forms.BindingSource BsUser;
        private SporttovBAUDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.Panel PanelImputCapcha;
        private System.Windows.Forms.TextBox TbxCapcha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel PanelCapcha;
        private System.Windows.Forms.Label LblC4;
        private System.Windows.Forms.Label LblC2;
        private System.Windows.Forms.Label LblC3;
        private System.Windows.Forms.Label LblC1;
        private System.Windows.Forms.Timer timer1;
        private SportTovarDataSet sportTovarDataSet;
        private SportTovarDataSetTableAdapters.UserTableAdapter userTableAdapter1;
    }
}


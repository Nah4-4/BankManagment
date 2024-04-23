namespace BankManagmentSystem
{
    partial class user_info
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.Phome = new System.Windows.Forms.Panel();
            this.Blogout = new System.Windows.Forms.Button();
            this.Ptransfer = new System.Windows.Forms.Panel();
            this.TBaccountNum = new System.Windows.Forms.TextBox();
            this.available = new System.Windows.Forms.Label();
            this.BConfirmTransfer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBamount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Lamount = new System.Windows.Forms.Label();
            this.Ltransferfrom = new System.Windows.Forms.Label();
            this.Ltfrom = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Ldate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BseeBalance = new System.Windows.Forms.Button();
            this.Ldisplayaccount = new System.Windows.Forms.Label();
            this.Ldispalybalance = new System.Windows.Forms.Label();
            this.Laccount = new System.Windows.Forms.Label();
            this.Lbalance = new System.Windows.Forms.Label();
            this.Btransfer = new System.Windows.Forms.Button();
            this.Ltransfer = new System.Windows.Forms.Label();
            this.Lname = new System.Windows.Forms.Label();
            this.Lwelcome = new System.Windows.Forms.Label();
            this.tabTransaction = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DGtransactions = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.Phome.SuspendLayout();
            this.Ptransfer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabTransaction.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGtransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabHome);
            this.tabControl1.Controls.Add(this.tabTransaction);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(551, 620);
            this.tabControl1.TabIndex = 1;
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.Phome);
            this.tabHome.Location = new System.Drawing.Point(4, 29);
            this.tabHome.Name = "tabHome";
            this.tabHome.Size = new System.Drawing.Size(543, 587);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // Phome
            // 
            this.Phome.BackColor = System.Drawing.Color.Silver;
            this.Phome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Phome.Controls.Add(this.Blogout);
            this.Phome.Controls.Add(this.Ptransfer);
            this.Phome.Controls.Add(this.panel1);
            this.Phome.Controls.Add(this.Btransfer);
            this.Phome.Controls.Add(this.Ltransfer);
            this.Phome.Controls.Add(this.Lname);
            this.Phome.Controls.Add(this.Lwelcome);
            this.Phome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Phome.Location = new System.Drawing.Point(0, 0);
            this.Phome.Name = "Phome";
            this.Phome.Size = new System.Drawing.Size(543, 587);
            this.Phome.TabIndex = 7;
            this.Phome.Paint += new System.Windows.Forms.PaintEventHandler(this.Phome_Paint);
            // 
            // Blogout
            // 
            this.Blogout.BackgroundImage = global::BankManagmentSystem.Properties.Resources.images__2_;
            this.Blogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Blogout.Location = new System.Drawing.Point(499, 1);
            this.Blogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Blogout.Name = "Blogout";
            this.Blogout.Size = new System.Drawing.Size(38, 42);
            this.Blogout.TabIndex = 0;
            this.Blogout.UseVisualStyleBackColor = true;
            this.Blogout.Click += new System.EventHandler(this.Blogout_Click);
            // 
            // Ptransfer
            // 
            this.Ptransfer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Ptransfer.Controls.Add(this.label5);
            this.Ptransfer.Controls.Add(this.TBaccountNum);
            this.Ptransfer.Controls.Add(this.available);
            this.Ptransfer.Controls.Add(this.BConfirmTransfer);
            this.Ptransfer.Controls.Add(this.label4);
            this.Ptransfer.Controls.Add(this.label3);
            this.Ptransfer.Controls.Add(this.TBamount);
            this.Ptransfer.Controls.Add(this.label2);
            this.Ptransfer.Controls.Add(this.Lamount);
            this.Ptransfer.Controls.Add(this.Ltransferfrom);
            this.Ptransfer.Controls.Add(this.Ltfrom);
            this.Ptransfer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ptransfer.Location = new System.Drawing.Point(0, 0);
            this.Ptransfer.Name = "Ptransfer";
            this.Ptransfer.Size = new System.Drawing.Size(543, 587);
            this.Ptransfer.TabIndex = 6;
            this.Ptransfer.Visible = false;
            this.Ptransfer.Paint += new System.Windows.Forms.PaintEventHandler(this.Ptransfer_Paint);
            // 
            // TBaccountNum
            // 
            this.TBaccountNum.BackColor = System.Drawing.Color.White;
            this.TBaccountNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBaccountNum.Location = new System.Drawing.Point(73, 294);
            this.TBaccountNum.Name = "TBaccountNum";
            this.TBaccountNum.Size = new System.Drawing.Size(192, 26);
            this.TBaccountNum.TabIndex = 4;
            this.TBaccountNum.Click += new System.EventHandler(this.TBaccountNum_Click);
            // 
            // available
            // 
            this.available.AutoSize = true;
            this.available.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.available.Location = new System.Drawing.Point(197, 157);
            this.available.Name = "available";
            this.available.Size = new System.Drawing.Size(36, 17);
            this.available.TabIndex = 10;
            this.available.Text = "0.00";
            this.available.Click += new System.EventHandler(this.available_Click);
            // 
            // BConfirmTransfer
            // 
            this.BConfirmTransfer.BackColor = System.Drawing.Color.White;
            this.BConfirmTransfer.Location = new System.Drawing.Point(178, 494);
            this.BConfirmTransfer.Name = "BConfirmTransfer";
            this.BConfirmTransfer.Size = new System.Drawing.Size(134, 39);
            this.BConfirmTransfer.TabIndex = 8;
            this.BConfirmTransfer.Text = "Confirm";
            this.BConfirmTransfer.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Avaliable balance :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Amount";
            // 
            // TBamount
            // 
            this.TBamount.BackColor = System.Drawing.Color.White;
            this.TBamount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBamount.Location = new System.Drawing.Point(73, 385);
            this.TBamount.Name = "TBamount";
            this.TBamount.Size = new System.Drawing.Size(192, 26);
            this.TBamount.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Transfer To";
            // 
            // Lamount
            // 
            this.Lamount.AutoSize = true;
            this.Lamount.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lamount.Location = new System.Drawing.Point(53, 157);
            this.Lamount.Name = "Lamount";
            this.Lamount.Size = new System.Drawing.Size(35, 16);
            this.Lamount.TabIndex = 2;
            this.Lamount.Text = "1000";
            // 
            // Ltransferfrom
            // 
            this.Ltransferfrom.AutoSize = true;
            this.Ltransferfrom.BackColor = System.Drawing.Color.White;
            this.Ltransferfrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Ltransferfrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ltransferfrom.Location = new System.Drawing.Point(108, 97);
            this.Ltransferfrom.Name = "Ltransferfrom";
            this.Ltransferfrom.Size = new System.Drawing.Size(74, 28);
            this.Ltransferfrom.TabIndex = 1;
            this.Ltransferfrom.Text = "10001";
            this.Ltransferfrom.Click += new System.EventHandler(this.Ltransferfrom_Click);
            // 
            // Ltfrom
            // 
            this.Ltfrom.AutoSize = true;
            this.Ltfrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ltfrom.Location = new System.Drawing.Point(53, 60);
            this.Ltfrom.Name = "Ltfrom";
            this.Ltfrom.Size = new System.Drawing.Size(129, 24);
            this.Ltfrom.TabIndex = 0;
            this.Ltfrom.Text = "Transfer From";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Enabled = false;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(75, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Account Number";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BackgroundImage = global::BankManagmentSystem.Properties.Resources.images__2_1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Ldate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BseeBalance);
            this.panel1.Controls.Add(this.Ldisplayaccount);
            this.panel1.Controls.Add(this.Ldispalybalance);
            this.panel1.Controls.Add(this.Laccount);
            this.panel1.Controls.Add(this.Lbalance);
            this.panel1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Location = new System.Drawing.Point(72, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 196);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Ldate
            // 
            this.Ldate.AutoSize = true;
            this.Ldate.BackColor = System.Drawing.Color.Transparent;
            this.Ldate.ForeColor = System.Drawing.Color.Black;
            this.Ldate.Location = new System.Drawing.Point(129, 160);
            this.Ldate.Name = "Ldate";
            this.Ldate.Size = new System.Drawing.Size(32, 20);
            this.Ldate.TabIndex = 9;
            this.Ldate.Text = "apr";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(81, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "ETB";
            // 
            // BseeBalance
            // 
            this.BseeBalance.BackColor = System.Drawing.Color.Transparent;
            this.BseeBalance.BackgroundImage = global::BankManagmentSystem.Properties.Resources._6803345;
            this.BseeBalance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BseeBalance.FlatAppearance.BorderSize = 0;
            this.BseeBalance.ForeColor = System.Drawing.Color.Black;
            this.BseeBalance.Location = new System.Drawing.Point(263, 62);
            this.BseeBalance.Name = "BseeBalance";
            this.BseeBalance.Size = new System.Drawing.Size(28, 26);
            this.BseeBalance.TabIndex = 7;
            this.BseeBalance.UseVisualStyleBackColor = false;
            this.BseeBalance.Click += new System.EventHandler(this.BseeBalance_Click);
            // 
            // Ldisplayaccount
            // 
            this.Ldisplayaccount.AutoSize = true;
            this.Ldisplayaccount.BackColor = System.Drawing.Color.Transparent;
            this.Ldisplayaccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ldisplayaccount.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ldisplayaccount.ForeColor = System.Drawing.Color.Black;
            this.Ldisplayaccount.Location = new System.Drawing.Point(241, 108);
            this.Ldisplayaccount.Name = "Ldisplayaccount";
            this.Ldisplayaccount.Size = new System.Drawing.Size(65, 23);
            this.Ldisplayaccount.TabIndex = 5;
            this.Ldisplayaccount.Text = "10001";
            this.Ldisplayaccount.Click += new System.EventHandler(this.Ldisplayaccount_Click);
            // 
            // Ldispalybalance
            // 
            this.Ldispalybalance.AutoSize = true;
            this.Ldispalybalance.BackColor = System.Drawing.Color.Transparent;
            this.Ldispalybalance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Ldispalybalance.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ldispalybalance.ForeColor = System.Drawing.Color.Black;
            this.Ldispalybalance.Location = new System.Drawing.Point(127, 61);
            this.Ldispalybalance.Name = "Ldispalybalance";
            this.Ldispalybalance.Size = new System.Drawing.Size(82, 26);
            this.Ldispalybalance.TabIndex = 4;
            this.Ldispalybalance.Text = "*******";
            this.Ldispalybalance.Click += new System.EventHandler(this.Ldispalybalance_Click);
            // 
            // Laccount
            // 
            this.Laccount.AutoSize = true;
            this.Laccount.BackColor = System.Drawing.Color.Transparent;
            this.Laccount.Font = new System.Drawing.Font("Nirmala UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Laccount.ForeColor = System.Drawing.Color.Black;
            this.Laccount.Location = new System.Drawing.Point(63, 107);
            this.Laccount.Name = "Laccount";
            this.Laccount.Size = new System.Drawing.Size(147, 25);
            this.Laccount.TabIndex = 1;
            this.Laccount.Text = "Account Number";
            // 
            // Lbalance
            // 
            this.Lbalance.AutoSize = true;
            this.Lbalance.BackColor = System.Drawing.Color.Transparent;
            this.Lbalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbalance.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbalance.ForeColor = System.Drawing.Color.Black;
            this.Lbalance.Location = new System.Drawing.Point(161, 18);
            this.Lbalance.Name = "Lbalance";
            this.Lbalance.Size = new System.Drawing.Size(80, 27);
            this.Lbalance.TabIndex = 0;
            this.Lbalance.Text = "Balance";
            // 
            // Btransfer
            // 
            this.Btransfer.BackgroundImage = global::BankManagmentSystem.Properties.Resources.dollar_exchange_money_transfer_icon_21;
            this.Btransfer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btransfer.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btransfer.Location = new System.Drawing.Point(46, 326);
            this.Btransfer.Name = "Btransfer";
            this.Btransfer.Size = new System.Drawing.Size(59, 61);
            this.Btransfer.TabIndex = 3;
            this.Btransfer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btransfer.UseVisualStyleBackColor = true;
            this.Btransfer.Click += new System.EventHandler(this.Btransfer_Click);
            // 
            // Ltransfer
            // 
            this.Ltransfer.AutoSize = true;
            this.Ltransfer.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ltransfer.Location = new System.Drawing.Point(43, 390);
            this.Ltransfer.Name = "Ltransfer";
            this.Ltransfer.Size = new System.Drawing.Size(67, 21);
            this.Ltransfer.TabIndex = 5;
            this.Ltransfer.Text = "Transfer";
            // 
            // Lname
            // 
            this.Lname.AutoSize = true;
            this.Lname.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.Lname.Location = new System.Drawing.Point(113, 33);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(47, 23);
            this.Lname.TabIndex = 3;
            this.Lname.Text = "user";
            this.Lname.Click += new System.EventHandler(this.username_Click);
            // 
            // Lwelcome
            // 
            this.Lwelcome.AutoSize = true;
            this.Lwelcome.BackColor = System.Drawing.Color.Transparent;
            this.Lwelcome.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lwelcome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lwelcome.Location = new System.Drawing.Point(28, 34);
            this.Lwelcome.Name = "Lwelcome";
            this.Lwelcome.Size = new System.Drawing.Size(79, 21);
            this.Lwelcome.TabIndex = 2;
            this.Lwelcome.Text = "Welcome";
            // 
            // tabTransaction
            // 
            this.tabTransaction.Controls.Add(this.panel2);
            this.tabTransaction.Controls.Add(this.label7);
            this.tabTransaction.Location = new System.Drawing.Point(4, 29);
            this.tabTransaction.Name = "tabTransaction";
            this.tabTransaction.Padding = new System.Windows.Forms.Padding(3);
            this.tabTransaction.Size = new System.Drawing.Size(543, 475);
            this.tabTransaction.TabIndex = 1;
            this.tabTransaction.Text = "Transactions";
            this.tabTransaction.UseVisualStyleBackColor = true;
            this.tabTransaction.Enter += new System.EventHandler(this.tabTransaction_Enter);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DGtransactions);
            this.panel2.Location = new System.Drawing.Point(14, 70);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(517, 519);
            this.panel2.TabIndex = 1;
            // 
            // DGtransactions
            // 
            this.DGtransactions.AllowUserToAddRows = false;
            this.DGtransactions.AllowUserToDeleteRows = false;
            this.DGtransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGtransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGtransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGtransactions.Location = new System.Drawing.Point(0, 0);
            this.DGtransactions.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DGtransactions.Name = "DGtransactions";
            this.DGtransactions.ReadOnly = true;
            this.DGtransactions.RowHeadersWidth = 25;
            this.DGtransactions.RowTemplate.Height = 24;
            this.DGtransactions.Size = new System.Drawing.Size(517, 519);
            this.DGtransactions.TabIndex = 0;
            this.DGtransactions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGtransactions_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(178, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Transaction";
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(543, 475);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Profile";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // user_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 620);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "user_info";
            this.Text = "user_info";
            this.Load += new System.EventHandler(this.user_info_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.Phome.ResumeLayout(false);
            this.Phome.PerformLayout();
            this.Ptransfer.ResumeLayout(false);
            this.Ptransfer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabTransaction.ResumeLayout(false);
            this.tabTransaction.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGtransactions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Blogout;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabTransaction;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Laccount;
        private System.Windows.Forms.Label Lbalance;
        private System.Windows.Forms.Label Lwelcome;
        private System.Windows.Forms.Label Lname;
        private System.Windows.Forms.Label Ldisplayaccount;
        private System.Windows.Forms.Label Ldispalybalance;
        private System.Windows.Forms.Button BseeBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btransfer;
        private System.Windows.Forms.Label Ltransfer;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel Ptransfer;
        private System.Windows.Forms.Label Ltfrom;
        private System.Windows.Forms.Label Ltransferfrom;
        private System.Windows.Forms.Label Lamount;
        private System.Windows.Forms.TextBox TBaccountNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Phome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBamount;
        private System.Windows.Forms.Button BConfirmTransfer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Ldate;
        private System.Windows.Forms.Label available;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DGtransactions;
    }
}
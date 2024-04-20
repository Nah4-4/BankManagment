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
            this.Blogout = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Ldisplayaccount = new System.Windows.Forms.Label();
            this.Ldispalybalance = new System.Windows.Forms.Label();
            this.Lname = new System.Windows.Forms.Label();
            this.Lwelcome = new System.Windows.Forms.Label();
            this.Laccount = new System.Windows.Forms.Label();
            this.Lbalance = new System.Windows.Forms.Label();
            this.tabTransaction = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.Ltransfer = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Btransfer = new System.Windows.Forms.Button();
            this.BseeBalance = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Blogout
            // 
            this.Blogout.Location = new System.Drawing.Point(465, 0);
            this.Blogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Blogout.Name = "Blogout";
            this.Blogout.Size = new System.Drawing.Size(61, 44);
            this.Blogout.TabIndex = 0;
            this.Blogout.Text = "logout";
            this.Blogout.UseVisualStyleBackColor = true;
            this.Blogout.Click += new System.EventHandler(this.button1_Click);
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
            this.tabControl1.Size = new System.Drawing.Size(534, 591);
            this.tabControl1.TabIndex = 1;
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.Blogout);
            this.tabHome.Controls.Add(this.Ltransfer);
            this.tabHome.Controls.Add(this.Btransfer);
            this.tabHome.Controls.Add(this.panel1);
            this.tabHome.Location = new System.Drawing.Point(4, 29);
            this.tabHome.Name = "tabHome";
            this.tabHome.Size = new System.Drawing.Size(526, 558);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BseeBalance);
            this.panel1.Controls.Add(this.Ldisplayaccount);
            this.panel1.Controls.Add(this.Ldispalybalance);
            this.panel1.Controls.Add(this.Lname);
            this.panel1.Controls.Add(this.Lwelcome);
            this.panel1.Controls.Add(this.Laccount);
            this.panel1.Controls.Add(this.Lbalance);
            this.panel1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Location = new System.Drawing.Point(74, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 158);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Ldisplayaccount
            // 
            this.Ldisplayaccount.AutoSize = true;
            this.Ldisplayaccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ldisplayaccount.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ldisplayaccount.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Ldisplayaccount.Location = new System.Drawing.Point(201, 113);
            this.Ldisplayaccount.Name = "Ldisplayaccount";
            this.Ldisplayaccount.Size = new System.Drawing.Size(54, 23);
            this.Ldisplayaccount.TabIndex = 5;
            this.Ldisplayaccount.Text = "1001";
            this.Ldisplayaccount.Click += new System.EventHandler(this.Ldisplayaccount_Click);
            // 
            // Ldispalybalance
            // 
            this.Ldispalybalance.AutoSize = true;
            this.Ldispalybalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ldispalybalance.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ldispalybalance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Ldispalybalance.Location = new System.Drawing.Point(242, 68);
            this.Ldispalybalance.Name = "Ldispalybalance";
            this.Ldispalybalance.Size = new System.Drawing.Size(50, 23);
            this.Ldispalybalance.TabIndex = 4;
            this.Ldispalybalance.Text = "*****";
            this.Ldispalybalance.Click += new System.EventHandler(this.Ldispalybalance_Click);
            // 
            // Lname
            // 
            this.Lname.AutoSize = true;
            this.Lname.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lname.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Lname.Location = new System.Drawing.Point(201, 26);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(42, 21);
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
            this.Lwelcome.Location = new System.Drawing.Point(107, 26);
            this.Lwelcome.Name = "Lwelcome";
            this.Lwelcome.Size = new System.Drawing.Size(79, 21);
            this.Lwelcome.TabIndex = 2;
            this.Lwelcome.Text = "Welcome";
            // 
            // Laccount
            // 
            this.Laccount.AutoSize = true;
            this.Laccount.BackColor = System.Drawing.Color.Transparent;
            this.Laccount.Font = new System.Drawing.Font("Nirmala UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Laccount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Laccount.Location = new System.Drawing.Point(36, 114);
            this.Laccount.Name = "Laccount";
            this.Laccount.Size = new System.Drawing.Size(147, 25);
            this.Laccount.TabIndex = 1;
            this.Laccount.Text = "Account Number";
            // 
            // Lbalance
            // 
            this.Lbalance.AutoSize = true;
            this.Lbalance.BackColor = System.Drawing.Color.Transparent;
            this.Lbalance.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbalance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbalance.Location = new System.Drawing.Point(36, 66);
            this.Lbalance.Name = "Lbalance";
            this.Lbalance.Size = new System.Drawing.Size(78, 25);
            this.Lbalance.TabIndex = 0;
            this.Lbalance.Text = "Balance";
            // 
            // tabTransaction
            // 
            this.tabTransaction.Location = new System.Drawing.Point(4, 29);
            this.tabTransaction.Name = "tabTransaction";
            this.tabTransaction.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabTransaction.Size = new System.Drawing.Size(526, 558);
            this.tabTransaction.TabIndex = 1;
            this.tabTransaction.Text = "Transactions";
            this.tabTransaction.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(201, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "ETB";
            // 
            // Ltransfer
            // 
            this.Ltransfer.AutoSize = true;
            this.Ltransfer.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ltransfer.Location = new System.Drawing.Point(54, 282);
            this.Ltransfer.Name = "Ltransfer";
            this.Ltransfer.Size = new System.Drawing.Size(67, 21);
            this.Ltransfer.TabIndex = 5;
            this.Ltransfer.Text = "Transfer";
            this.Ltransfer.Click += new System.EventHandler(this.label3_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(526, 558);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Profile";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Btransfer
            // 
            this.Btransfer.BackgroundImage = global::BankManagmentSystem.Properties.Resources.dollar_exchange_money_transfer_icon_21;
            this.Btransfer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btransfer.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btransfer.Location = new System.Drawing.Point(50, 211);
            this.Btransfer.Name = "Btransfer";
            this.Btransfer.Size = new System.Drawing.Size(75, 72);
            this.Btransfer.TabIndex = 3;
            this.Btransfer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btransfer.UseVisualStyleBackColor = true;
            // 
            // BseeBalance
            // 
            this.BseeBalance.BackgroundImage = global::BankManagmentSystem.Properties.Resources._6803345;
            this.BseeBalance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BseeBalance.FlatAppearance.BorderSize = 0;
            this.BseeBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BseeBalance.Location = new System.Drawing.Point(344, 67);
            this.BseeBalance.Name = "BseeBalance";
            this.BseeBalance.Size = new System.Drawing.Size(27, 24);
            this.BseeBalance.TabIndex = 7;
            this.BseeBalance.UseVisualStyleBackColor = true;
            this.BseeBalance.Click += new System.EventHandler(this.BseeBalance_Click);
            // 
            // user_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 591);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "user_info";
            this.Text = "user_info";
            this.Load += new System.EventHandler(this.user_info_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}
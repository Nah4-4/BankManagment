namespace BankManagmentSystem
{
    partial class Form1
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
            this.Blogin = new System.Windows.Forms.Button();
            this.TBname = new System.Windows.Forms.TextBox();
            this.TBpassword = new System.Windows.Forms.TextBox();
            this.Lname = new System.Windows.Forms.Label();
            this.Lpassword = new System.Windows.Forms.Label();
            this.LLcreateaccount = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Blogin
            // 
            this.Blogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Blogin.Location = new System.Drawing.Point(350, 332);
            this.Blogin.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Blogin.Name = "Blogin";
            this.Blogin.Size = new System.Drawing.Size(190, 54);
            this.Blogin.TabIndex = 11;
            this.Blogin.Text = "Log In";
            this.Blogin.UseVisualStyleBackColor = true;
            this.Blogin.Click += new System.EventHandler(this.Blogin_Click);
            // 
            // TBname
            // 
            this.TBname.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TBname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBname.Location = new System.Drawing.Point(282, 111);
            this.TBname.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TBname.Name = "TBname";
            this.TBname.Size = new System.Drawing.Size(376, 30);
            this.TBname.TabIndex = 9;
            this.TBname.Text = "BM-";
            this.TBname.WordWrap = false;
            this.TBname.TextChanged += new System.EventHandler(this.TBname_TextChanged);
            // 
            // TBpassword
            // 
            this.TBpassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TBpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBpassword.Location = new System.Drawing.Point(282, 242);
            this.TBpassword.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TBpassword.Name = "TBpassword";
            this.TBpassword.PasswordChar = '*';
            this.TBpassword.Size = new System.Drawing.Size(376, 33);
            this.TBpassword.TabIndex = 10;
            this.TBpassword.WordWrap = false;
            this.TBpassword.TextChanged += new System.EventHandler(this.TBpassword_TextChanged);
            // 
            // Lname
            // 
            this.Lname.AutoSize = true;
            this.Lname.BackColor = System.Drawing.Color.Transparent;
            this.Lname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lname.Location = new System.Drawing.Point(70, 118);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(143, 28);
            this.Lname.TabIndex = 11;
            this.Lname.Text = "User-Name";
            // 
            // Lpassword
            // 
            this.Lpassword.AutoSize = true;
            this.Lpassword.BackColor = System.Drawing.Color.Transparent;
            this.Lpassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lpassword.Location = new System.Drawing.Point(70, 249);
            this.Lpassword.Name = "Lpassword";
            this.Lpassword.Size = new System.Drawing.Size(128, 28);
            this.Lpassword.TabIndex = 12;
            this.Lpassword.Text = "Password";
            // 
            // LLcreateaccount
            // 
            this.LLcreateaccount.AutoSize = true;
            this.LLcreateaccount.BackColor = System.Drawing.Color.Transparent;
            this.LLcreateaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLcreateaccount.Location = new System.Drawing.Point(376, 409);
            this.LLcreateaccount.Name = "LLcreateaccount";
            this.LLcreateaccount.Size = new System.Drawing.Size(134, 22);
            this.LLcreateaccount.TabIndex = 13;
            this.LLcreateaccount.TabStop = true;
            this.LLcreateaccount.Text = "Create Account";
            this.LLcreateaccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLcreateaccount_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.BackgroundImage = global::BankManagmentSystem.Properties.Resources.images__2_1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Lname);
            this.panel1.Controls.Add(this.TBname);
            this.panel1.Controls.Add(this.Lpassword);
            this.panel1.Controls.Add(this.LLcreateaccount);
            this.panel1.Controls.Add(this.TBpassword);
            this.panel1.Controls.Add(this.Blogin);
            this.panel1.Location = new System.Drawing.Point(250, 255);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 499);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(480, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 75);
            this.label1.TabIndex = 15;
            this.label1.Text = "BANK NAME";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BankManagmentSystem.Properties.Resources.AdobeStock_291217289_copy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 823);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banking Management";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Blogin;
        private System.Windows.Forms.TextBox TBname;
        private System.Windows.Forms.TextBox TBpassword;
        private System.Windows.Forms.Label Lname;
        private System.Windows.Forms.Label Lpassword;
        private System.Windows.Forms.LinkLabel LLcreateaccount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}


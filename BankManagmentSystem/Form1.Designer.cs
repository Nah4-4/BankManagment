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
            this.SuspendLayout();
            // 
            // Blogin
            // 
            this.Blogin.Location = new System.Drawing.Point(325, 419);
            this.Blogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Blogin.Name = "Blogin";
            this.Blogin.Size = new System.Drawing.Size(190, 54);
            this.Blogin.TabIndex = 8;
            this.Blogin.Text = "login";
            this.Blogin.UseVisualStyleBackColor = true;
            this.Blogin.Click += new System.EventHandler(this.Blogin_Click);
            // 
            // TBname
            // 
            this.TBname.Location = new System.Drawing.Point(258, 164);
            this.TBname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TBname.Multiline = true;
            this.TBname.Name = "TBname";
            this.TBname.Size = new System.Drawing.Size(375, 36);
            this.TBname.TabIndex = 9;
            this.TBname.TextChanged += new System.EventHandler(this.TBname_TextChanged);
            // 
            // TBpassword
            // 
            this.TBpassword.Location = new System.Drawing.Point(258, 328);
            this.TBpassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TBpassword.Multiline = true;
            this.TBpassword.Name = "TBpassword";
            this.TBpassword.PasswordChar = '*';
            this.TBpassword.Size = new System.Drawing.Size(375, 36);
            this.TBpassword.TabIndex = 10;
            this.TBpassword.TextChanged += new System.EventHandler(this.TBpassword_TextChanged);
            // 
            // Lname
            // 
            this.Lname.AutoSize = true;
            this.Lname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lname.Location = new System.Drawing.Point(47, 172);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(143, 28);
            this.Lname.TabIndex = 11;
            this.Lname.Text = "User-Name";
            // 
            // Lpassword
            // 
            this.Lpassword.AutoSize = true;
            this.Lpassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lpassword.Location = new System.Drawing.Point(47, 336);
            this.Lpassword.Name = "Lpassword";
            this.Lpassword.Size = new System.Drawing.Size(128, 28);
            this.Lpassword.TabIndex = 12;
            this.Lpassword.Text = "Password";
            // 
            // LLcreateaccount
            // 
            this.LLcreateaccount.AutoSize = true;
            this.LLcreateaccount.Location = new System.Drawing.Point(356, 509);
            this.LLcreateaccount.Name = "LLcreateaccount";
            this.LLcreateaccount.Size = new System.Drawing.Size(120, 20);
            this.LLcreateaccount.TabIndex = 13;
            this.LLcreateaccount.TabStop = true;
            this.LLcreateaccount.Text = "Create Account";
            this.LLcreateaccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLcreateaccount_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 692);
            this.Controls.Add(this.LLcreateaccount);
            this.Controls.Add(this.Lpassword);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.TBpassword);
            this.Controls.Add(this.TBname);
            this.Controls.Add(this.Blogin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Banking Management";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}


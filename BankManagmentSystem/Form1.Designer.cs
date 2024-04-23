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
            this.Blogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Blogin.Location = new System.Drawing.Point(217, 272);
            this.Blogin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Blogin.Name = "Blogin";
            this.Blogin.Size = new System.Drawing.Size(127, 35);
            this.Blogin.TabIndex = 11;
            this.Blogin.Text = "Log In";
            this.Blogin.UseVisualStyleBackColor = true;
            this.Blogin.Click += new System.EventHandler(this.Blogin_Click);
            // 
            // TBname
            // 
            this.TBname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBname.Location = new System.Drawing.Point(172, 107);
            this.TBname.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TBname.Multiline = true;
            this.TBname.Name = "TBname";
            this.TBname.Size = new System.Drawing.Size(251, 25);
            this.TBname.TabIndex = 9;
            this.TBname.Text = "BM-";
            this.TBname.TextChanged += new System.EventHandler(this.TBname_TextChanged);
            // 
            // TBpassword
            // 
            this.TBpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBpassword.Location = new System.Drawing.Point(172, 213);
            this.TBpassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TBpassword.Multiline = true;
            this.TBpassword.Name = "TBpassword";
            this.TBpassword.PasswordChar = '*';
            this.TBpassword.Size = new System.Drawing.Size(251, 25);
            this.TBpassword.TabIndex = 10;
            this.TBpassword.TextChanged += new System.EventHandler(this.TBpassword_TextChanged);
            // 
            // Lname
            // 
            this.Lname.AutoSize = true;
            this.Lname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lname.Location = new System.Drawing.Point(31, 112);
            this.Lname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(97, 18);
            this.Lname.TabIndex = 11;
            this.Lname.Text = "User-Name";
            // 
            // Lpassword
            // 
            this.Lpassword.AutoSize = true;
            this.Lpassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lpassword.Location = new System.Drawing.Point(31, 218);
            this.Lpassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lpassword.Name = "Lpassword";
            this.Lpassword.Size = new System.Drawing.Size(87, 18);
            this.Lpassword.TabIndex = 12;
            this.Lpassword.Text = "Password";
            // 
            // LLcreateaccount
            // 
            this.LLcreateaccount.AutoSize = true;
            this.LLcreateaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLcreateaccount.Location = new System.Drawing.Point(237, 331);
            this.LLcreateaccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LLcreateaccount.Name = "LLcreateaccount";
            this.LLcreateaccount.Size = new System.Drawing.Size(89, 15);
            this.LLcreateaccount.TabIndex = 13;
            this.LLcreateaccount.TabStop = true;
            this.LLcreateaccount.Text = "Create Account";
            this.LLcreateaccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLcreateaccount_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 450);
            this.Controls.Add(this.LLcreateaccount);
            this.Controls.Add(this.Lpassword);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.TBpassword);
            this.Controls.Add(this.TBname);
            this.Controls.Add(this.Blogin);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
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


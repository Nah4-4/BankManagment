﻿namespace BankManagmentSystem
{
    partial class create_account
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
            this.BackButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.firstname = new System.Windows.Forms.Label();
            this.lastname = new System.Windows.Forms.Label();
            this.pnum = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.Fname_field = new System.Windows.Forms.TextBox();
            this.Lname_field = new System.Windows.Forms.TextBox();
            this.Pnum_field = new System.Windows.Forms.TextBox();
            this.Add_field = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.password_field = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(106, 375);
            this.BackButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(155, 45);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateButton.Location = new System.Drawing.Point(309, 375);
            this.CreateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(155, 45);
            this.CreateButton.TabIndex = 1;
            this.CreateButton.Text = "Register";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // firstname
            // 
            this.firstname.AutoSize = true;
            this.firstname.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname.Location = new System.Drawing.Point(101, 82);
            this.firstname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(91, 18);
            this.firstname.TabIndex = 2;
            this.firstname.Text = "First-Name";
            // 
            // lastname
            // 
            this.lastname.AutoSize = true;
            this.lastname.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname.Location = new System.Drawing.Point(101, 141);
            this.lastname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(90, 18);
            this.lastname.TabIndex = 3;
            this.lastname.Text = "Last-Name";
            // 
            // pnum
            // 
            this.pnum.AutoSize = true;
            this.pnum.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnum.Location = new System.Drawing.Point(101, 201);
            this.pnum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pnum.Name = "pnum";
            this.pnum.Size = new System.Drawing.Size(124, 18);
            this.pnum.TabIndex = 4;
            this.pnum.Text = "Phone-Number";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(104, 260);
            this.address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(71, 18);
            this.address.TabIndex = 5;
            this.address.Text = "Address";
            // 
            // Fname_field
            // 
            this.Fname_field.Location = new System.Drawing.Point(227, 84);
            this.Fname_field.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Fname_field.Name = "Fname_field";
            this.Fname_field.Size = new System.Drawing.Size(231, 20);
            this.Fname_field.TabIndex = 6;
            // 
            // Lname_field
            // 
            this.Lname_field.Location = new System.Drawing.Point(227, 144);
            this.Lname_field.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Lname_field.Name = "Lname_field";
            this.Lname_field.Size = new System.Drawing.Size(231, 20);
            this.Lname_field.TabIndex = 7;
            // 
            // Pnum_field
            // 
            this.Pnum_field.Location = new System.Drawing.Point(227, 203);
            this.Pnum_field.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pnum_field.Name = "Pnum_field";
            this.Pnum_field.Size = new System.Drawing.Size(231, 20);
            this.Pnum_field.TabIndex = 8;
            this.Pnum_field.Text = "+251-9";
            // 
            // Add_field
            // 
            this.Add_field.Location = new System.Drawing.Point(227, 262);
            this.Add_field.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Add_field.Name = "Add_field";
            this.Add_field.Size = new System.Drawing.Size(231, 20);
            this.Add_field.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(199, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Registration Form";
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(104, 319);
            this.pass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(84, 18);
            this.pass.TabIndex = 11;
            this.pass.Text = "Password";
            // 
            // password_field
            // 
            this.password_field.Location = new System.Drawing.Point(227, 322);
            this.password_field.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.password_field.Name = "password_field";
            this.password_field.Size = new System.Drawing.Size(231, 20);
            this.password_field.TabIndex = 12;
            this.password_field.TextChanged += new System.EventHandler(this.password_field_TextChanged);
            // 
            // create_account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 472);
            this.ControlBox = false;
            this.Controls.Add(this.password_field);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Add_field);
            this.Controls.Add(this.Pnum_field);
            this.Controls.Add(this.Lname_field);
            this.Controls.Add(this.Fname_field);
            this.Controls.Add(this.address);
            this.Controls.Add(this.pnum);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.BackButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "create_account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "create_account";
            this.Load += new System.EventHandler(this.create_account_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Label firstname;
        private System.Windows.Forms.Label lastname;
        private System.Windows.Forms.Label pnum;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.TextBox Fname_field;
        private System.Windows.Forms.TextBox Lname_field;
        private System.Windows.Forms.TextBox Pnum_field;
        private System.Windows.Forms.TextBox Add_field;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.TextBox password_field;
    }
}
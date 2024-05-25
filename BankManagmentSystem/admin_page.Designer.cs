namespace BankManagmentSystem
{
    partial class admin_page
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
            this.display = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Btntransaction = new System.Windows.Forms.Button();
            this.Btnedit = new System.Windows.Forms.Button();
            this.freeze_btn = new System.Windows.Forms.Button();
            this.Btnexit = new System.Windows.Forms.Button();
            this.Btninfo = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.display)).BeginInit();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.AllowUserToAddRows = false;
            this.display.AllowUserToDeleteRows = false;
            this.display.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.display.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.display.Location = new System.Drawing.Point(40, 92);
            this.display.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.display.MultiSelect = false;
            this.display.Name = "display";
            this.display.RowHeadersWidth = 25;
            this.display.RowTemplate.Height = 24;
            this.display.Size = new System.Drawing.Size(1220, 627);
            this.display.TabIndex = 0;
            this.display.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.display_CellValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 46);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "search by account number";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Btntransaction
            // 
            this.Btntransaction.Location = new System.Drawing.Point(238, 742);
            this.Btntransaction.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Btntransaction.Name = "Btntransaction";
            this.Btntransaction.Size = new System.Drawing.Size(150, 51);
            this.Btntransaction.TabIndex = 2;
            this.Btntransaction.Text = "view transaction";
            this.Btntransaction.UseVisualStyleBackColor = true;
            this.Btntransaction.Click += new System.EventHandler(this.Btntransaction_Click);
            // 
            // Btnedit
            // 
            this.Btnedit.Location = new System.Drawing.Point(477, 742);
            this.Btnedit.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Btnedit.Name = "Btnedit";
            this.Btnedit.Size = new System.Drawing.Size(159, 51);
            this.Btnedit.TabIndex = 3;
            this.Btnedit.Text = "edit";
            this.Btnedit.UseVisualStyleBackColor = true;
            this.Btnedit.Click += new System.EventHandler(this.Btnedit_Click);
            // 
            // freeze_btn
            // 
            this.freeze_btn.Location = new System.Drawing.Point(597, 745);
            this.freeze_btn.Name = "freeze_btn";
            this.freeze_btn.Size = new System.Drawing.Size(202, 51);
            this.freeze_btn.TabIndex = 4;
            this.freeze_btn.Text = "freeze/unfreeze";
            this.freeze_btn.UseVisualStyleBackColor = true;
            this.freeze_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // Btnexit
            // 
            this.Btnexit.Location = new System.Drawing.Point(988, 742);
            this.Btnexit.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Btnexit.Name = "Btnexit";
            this.Btnexit.Size = new System.Drawing.Size(202, 51);
            this.Btnexit.TabIndex = 5;
            this.Btnexit.Text = "back";
            this.Btnexit.UseVisualStyleBackColor = true;
            this.Btnexit.Click += new System.EventHandler(this.Btnexit_Click);
            // 
            // Btninfo
            // 
            this.Btninfo.Location = new System.Drawing.Point(43, 742);
            this.Btninfo.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Btninfo.Name = "Btninfo";
            this.Btninfo.Size = new System.Drawing.Size(144, 51);
            this.Btninfo.TabIndex = 14;
            this.Btninfo.Text = "veiw info";
            this.Btninfo.UseVisualStyleBackColor = true;
            this.Btninfo.Click += new System.EventHandler(this.Btninfo_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(403, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(247, 22);
            this.textBox2.TabIndex = 15;
            this.textBox2.Text = "search by user-name";
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // admin_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 841);
            this.ControlBox = false;
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Btninfo);
            this.Controls.Add(this.Btnexit);
            this.Controls.Add(this.freeze_btn);
            this.Controls.Add(this.Btnedit);
            this.Controls.Add(this.Btntransaction);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.display);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "admin_page";
            this.Text = "admin_page";
            this.Load += new System.EventHandler(this.admin_page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.display)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView display;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Btntransaction;
        private System.Windows.Forms.Button Btnedit;
        private System.Windows.Forms.Button freeze_btn;
        private System.Windows.Forms.Button Btnexit;
        private System.Windows.Forms.Button Btninfo;
        private System.Windows.Forms.TextBox textBox2;
    }
}
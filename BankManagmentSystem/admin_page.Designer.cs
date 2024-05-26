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
            this.label1 = new System.Windows.Forms.Label();
            this.TBtransferTo = new System.Windows.Forms.TextBox();
            this.TBtrasferFrom = new System.Windows.Forms.TextBox();
            this.list = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.display)).BeginInit();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.AllowUserToAddRows = false;
            this.display.AllowUserToDeleteRows = false;
            this.display.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.display.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.display.Location = new System.Drawing.Point(36, 74);
            this.display.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.display.MultiSelect = false;
            this.display.Name = "display";
            this.display.RowHeadersWidth = 25;
            this.display.RowTemplate.Height = 24;
            this.display.Size = new System.Drawing.Size(1059, 502);
            this.display.TabIndex = 0;
            this.display.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.display_CellClick);
            this.display.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.display_CellValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(223, 36);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = " Account Number";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Btntransaction
            // 
            this.Btntransaction.Location = new System.Drawing.Point(283, 597);
            this.Btntransaction.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Btntransaction.Name = "Btntransaction";
            this.Btntransaction.Size = new System.Drawing.Size(133, 41);
            this.Btntransaction.TabIndex = 2;
            this.Btntransaction.Text = "View Transaction";
            this.Btntransaction.UseVisualStyleBackColor = true;
            this.Btntransaction.Click += new System.EventHandler(this.Btntransaction_Click);
            // 
            // Btnedit
            // 
            this.Btnedit.Location = new System.Drawing.Point(492, 597);
            this.Btnedit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Btnedit.Name = "Btnedit";
            this.Btnedit.Size = new System.Drawing.Size(133, 41);
            this.Btnedit.TabIndex = 3;
            this.Btnedit.Text = "Edit";
            this.Btnedit.UseVisualStyleBackColor = true;
            this.Btnedit.Click += new System.EventHandler(this.Btnedit_Click);
            // 
            // freeze_btn
            // 
            this.freeze_btn.Location = new System.Drawing.Point(701, 597);
            this.freeze_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.freeze_btn.Name = "freeze_btn";
            this.freeze_btn.Size = new System.Drawing.Size(133, 41);
            this.freeze_btn.TabIndex = 4;
            this.freeze_btn.Text = "Freeze/Unfreeze";
            this.freeze_btn.UseVisualStyleBackColor = true;
            this.freeze_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // Btnexit
            // 
            this.Btnexit.Location = new System.Drawing.Point(911, 597);
            this.Btnexit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Btnexit.Name = "Btnexit";
            this.Btnexit.Size = new System.Drawing.Size(133, 41);
            this.Btnexit.TabIndex = 5;
            this.Btnexit.Text = "Back";
            this.Btnexit.UseVisualStyleBackColor = true;
            this.Btnexit.Click += new System.EventHandler(this.Btnexit_Click);
            // 
            // Btninfo
            // 
            this.Btninfo.Location = new System.Drawing.Point(73, 597);
            this.Btninfo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Btninfo.Name = "Btninfo";
            this.Btninfo.Size = new System.Drawing.Size(133, 41);
            this.Btninfo.TabIndex = 14;
            this.Btninfo.Text = "Veiw Info";
            this.Btninfo.UseVisualStyleBackColor = true;
            this.Btninfo.Click += new System.EventHandler(this.Btninfo_Click);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(476, 36);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(199, 22);
            this.textBox2.TabIndex = 15;
            this.textBox2.Text = " User-Name";
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Search By";
            // 
            // TBtransferTo
            // 
            this.TBtransferTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBtransferTo.Location = new System.Drawing.Point(476, 36);
            this.TBtransferTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBtransferTo.Name = "TBtransferTo";
            this.TBtransferTo.Size = new System.Drawing.Size(199, 22);
            this.TBtransferTo.TabIndex = 17;
            this.TBtransferTo.Text = "Transferrd To";
            this.TBtransferTo.Visible = false;
            this.TBtransferTo.Click += new System.EventHandler(this.TBtransferTo_Click);
            this.TBtransferTo.TextChanged += new System.EventHandler(this.TBtransferTo_TextChanged);
            // 
            // TBtrasferFrom
            // 
            this.TBtrasferFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBtrasferFrom.Location = new System.Drawing.Point(223, 36);
            this.TBtrasferFrom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBtrasferFrom.Name = "TBtrasferFrom";
            this.TBtrasferFrom.Size = new System.Drawing.Size(199, 22);
            this.TBtrasferFrom.TabIndex = 18;
            this.TBtrasferFrom.Text = "Transferred From";
            this.TBtrasferFrom.Visible = false;
            this.TBtrasferFrom.Click += new System.EventHandler(this.TBtrasferFrom_Click);
            this.TBtrasferFrom.TextChanged += new System.EventHandler(this.TBtrasferFrom_TextChanged);
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.Location = new System.Drawing.Point(939, 36);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(121, 24);
            this.list.TabIndex = 19;
            this.list.SelectedIndexChanged += new System.EventHandler(this.list_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(827, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1050, 606);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // admin_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 654);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.list);
            this.Controls.Add(this.TBtrasferFrom);
            this.Controls.Add(this.TBtransferTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Btninfo);
            this.Controls.Add(this.Btnexit);
            this.Controls.Add(this.freeze_btn);
            this.Controls.Add(this.Btnedit);
            this.Controls.Add(this.Btntransaction);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.display);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "admin_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBtransferTo;
        private System.Windows.Forms.TextBox TBtrasferFrom;
        private System.Windows.Forms.ComboBox list;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}
namespace Library_Management_System
{
    partial class StudentMain
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
            this.books_grid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.stdcredit_label = new System.Windows.Forms.Label();
            this.stdlabel_name = new System.Windows.Forms.Label();
            this.stdlabel_ID = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.search_textbox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.books_grid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // books_grid
            // 
            this.books_grid.AllowUserToAddRows = false;
            this.books_grid.AllowUserToDeleteRows = false;
            this.books_grid.AllowUserToOrderColumns = true;
            this.books_grid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.books_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.books_grid.Location = new System.Drawing.Point(12, 146);
            this.books_grid.Name = "books_grid";
            this.books_grid.ReadOnly = true;
            this.books_grid.Size = new System.Drawing.Size(1047, 408);
            this.books_grid.TabIndex = 0;
            this.books_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.books_grid_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.stdcredit_label);
            this.panel1.Controls.Add(this.stdlabel_name);
            this.panel1.Controls.Add(this.stdlabel_ID);
            this.panel1.Location = new System.Drawing.Point(12, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 105);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // stdcredit_label
            // 
            this.stdcredit_label.AutoSize = true;
            this.stdcredit_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdcredit_label.Location = new System.Drawing.Point(19, 67);
            this.stdcredit_label.Name = "stdcredit_label";
            this.stdcredit_label.Size = new System.Drawing.Size(59, 18);
            this.stdcredit_label.TabIndex = 2;
            this.stdcredit_label.Text = "Credits:";
            // 
            // stdlabel_name
            // 
            this.stdlabel_name.AutoSize = true;
            this.stdlabel_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdlabel_name.Location = new System.Drawing.Point(19, 42);
            this.stdlabel_name.Name = "stdlabel_name";
            this.stdlabel_name.Size = new System.Drawing.Size(106, 18);
            this.stdlabel_name.TabIndex = 1;
            this.stdlabel_name.Text = "Student Name:";
            // 
            // stdlabel_ID
            // 
            this.stdlabel_ID.AutoSize = true;
            this.stdlabel_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdlabel_ID.Location = new System.Drawing.Point(19, 19);
            this.stdlabel_ID.Name = "stdlabel_ID";
            this.stdlabel_ID.Size = new System.Drawing.Size(26, 18);
            this.stdlabel_ID.TabIndex = 0;
            this.stdlabel_ID.Text = "ID:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(873, 572);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Issue Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(671, 572);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 42);
            this.button2.TabIndex = 3;
            this.button2.Text = "My Books";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(960, 74);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 30);
            this.button3.TabIndex = 4;
            this.button3.Text = "Refresh Books";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // search_textbox
            // 
            this.search_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_textbox.Location = new System.Drawing.Point(740, 110);
            this.search_textbox.Multiline = true;
            this.search_textbox.Name = "search_textbox";
            this.search_textbox.Size = new System.Drawing.Size(214, 30);
            this.search_textbox.TabIndex = 5;
            this.search_textbox.TextChanged += new System.EventHandler(this.search_textbox_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(960, 110);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 30);
            this.button4.TabIndex = 6;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // StudentMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 626);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.search_textbox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.books_grid);
            this.Name = "StudentMain";
            this.Text = "Library Management System";
            this.Load += new System.EventHandler(this.StudentMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.books_grid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView books_grid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label stdlabel_name;
        private System.Windows.Forms.Label stdlabel_ID;
        private System.Windows.Forms.Label stdcredit_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox search_textbox;
        private System.Windows.Forms.Button button4;
    }
}
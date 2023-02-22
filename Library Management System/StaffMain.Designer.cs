namespace Library_Management_System
{
    partial class StaffMain
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
            this.button4 = new System.Windows.Forms.Button();
            this.search_textbox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.staffshift_label = new System.Windows.Forms.Label();
            this.stafflabel_name = new System.Windows.Forms.Label();
            this.stafflabel_ID = new System.Windows.Forms.Label();
            this.books_grid = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.books_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(960, 99);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 30);
            this.button4.TabIndex = 13;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // search_textbox
            // 
            this.search_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_textbox.Location = new System.Drawing.Point(740, 99);
            this.search_textbox.Multiline = true;
            this.search_textbox.Name = "search_textbox";
            this.search_textbox.Size = new System.Drawing.Size(214, 30);
            this.search_textbox.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(960, 63);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 30);
            this.button3.TabIndex = 11;
            this.button3.Text = "Refresh Books";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.staffshift_label);
            this.panel1.Controls.Add(this.stafflabel_name);
            this.panel1.Controls.Add(this.stafflabel_ID);
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 118);
            this.panel1.TabIndex = 8;
            // 
            // staffshift_label
            // 
            this.staffshift_label.AutoSize = true;
            this.staffshift_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffshift_label.Location = new System.Drawing.Point(11, 75);
            this.staffshift_label.Name = "staffshift_label";
            this.staffshift_label.Size = new System.Drawing.Size(78, 18);
            this.staffshift_label.TabIndex = 2;
            this.staffshift_label.Text = "Shift Time:";
            this.staffshift_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // stafflabel_name
            // 
            this.stafflabel_name.AutoSize = true;
            this.stafflabel_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stafflabel_name.Location = new System.Drawing.Point(11, 49);
            this.stafflabel_name.Name = "stafflabel_name";
            this.stafflabel_name.Size = new System.Drawing.Size(86, 18);
            this.stafflabel_name.TabIndex = 1;
            this.stafflabel_name.Text = "Staff Name:";
            // 
            // stafflabel_ID
            // 
            this.stafflabel_ID.AutoSize = true;
            this.stafflabel_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stafflabel_ID.Location = new System.Drawing.Point(11, 24);
            this.stafflabel_ID.Name = "stafflabel_ID";
            this.stafflabel_ID.Size = new System.Drawing.Size(26, 18);
            this.stafflabel_ID.TabIndex = 0;
            this.stafflabel_ID.Text = "ID:";
            this.stafflabel_ID.Click += new System.EventHandler(this.stdlabel_ID_Click);
            // 
            // books_grid
            // 
            this.books_grid.AllowUserToAddRows = false;
            this.books_grid.AllowUserToDeleteRows = false;
            this.books_grid.AllowUserToOrderColumns = true;
            this.books_grid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.books_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.books_grid.Location = new System.Drawing.Point(12, 135);
            this.books_grid.Name = "books_grid";
            this.books_grid.ReadOnly = true;
            this.books_grid.Size = new System.Drawing.Size(1047, 408);
            this.books_grid.TabIndex = 7;
            this.books_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.books_grid_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(681, 561);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 42);
            this.button2.TabIndex = 14;
            this.button2.Text = "Add Book";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(873, 561);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(186, 42);
            this.button5.TabIndex = 15;
            this.button5.Text = "Return Book";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(489, 561);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 42);
            this.button1.TabIndex = 16;
            this.button1.Text = "Delete Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StaffMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 615);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.search_textbox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.books_grid);
            this.Name = "StaffMain";
            this.Text = "Library Management System";
            this.Load += new System.EventHandler(this.StaffMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.books_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox search_textbox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label stafflabel_name;
        private System.Windows.Forms.Label stafflabel_ID;
        private System.Windows.Forms.DataGridView books_grid;
        private System.Windows.Forms.Label staffshift_label;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
    }
}
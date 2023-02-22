namespace Library_Management_System
{
    partial class StaffAddBook
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
            this.label1 = new System.Windows.Forms.Label();
            this.bookname = new System.Windows.Forms.TextBox();
            this.pubname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pubdate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.categoryid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Name:";
            // 
            // bookname
            // 
            this.bookname.Location = new System.Drawing.Point(15, 43);
            this.bookname.Name = "bookname";
            this.bookname.Size = new System.Drawing.Size(346, 20);
            this.bookname.TabIndex = 1;
            // 
            // pubname
            // 
            this.pubname.Location = new System.Drawing.Point(15, 92);
            this.pubname.Name = "pubname";
            this.pubname.Size = new System.Drawing.Size(346, 20);
            this.pubname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Publisher Name:";
            // 
            // pubdate
            // 
            this.pubdate.Location = new System.Drawing.Point(15, 141);
            this.pubdate.Name = "pubdate";
            this.pubdate.Size = new System.Drawing.Size(346, 20);
            this.pubdate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Publisher Date:";
            // 
            // categoryid
            // 
            this.categoryid.Location = new System.Drawing.Point(15, 187);
            this.categoryid.Name = "categoryid";
            this.categoryid.Size = new System.Drawing.Size(346, 20);
            this.categoryid.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Category ID:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(345, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StaffAddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 277);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.categoryid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pubdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pubname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bookname);
            this.Controls.Add(this.label1);
            this.Name = "StaffAddBook";
            this.Text = "Add Book";
            this.Load += new System.EventHandler(this.StaffAddBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bookname;
        private System.Windows.Forms.TextBox pubname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pubdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox categoryid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}
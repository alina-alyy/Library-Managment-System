namespace Library_Management_System
{
    partial class StudentMyBooks
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
            this.issuedBooks_grid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.issuedBooks_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // issuedBooks_grid
            // 
            this.issuedBooks_grid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.issuedBooks_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.issuedBooks_grid.Location = new System.Drawing.Point(12, 12);
            this.issuedBooks_grid.Name = "issuedBooks_grid";
            this.issuedBooks_grid.Size = new System.Drawing.Size(644, 597);
            this.issuedBooks_grid.TabIndex = 0;
            // 
            // StudentMyBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 618);
            this.Controls.Add(this.issuedBooks_grid);
            this.Name = "StudentMyBooks";
            this.Text = "Issued Books";
            this.Load += new System.EventHandler(this.StudentMyBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.issuedBooks_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView issuedBooks_grid;
    }
}
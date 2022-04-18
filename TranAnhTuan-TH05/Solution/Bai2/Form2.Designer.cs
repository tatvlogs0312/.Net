
namespace TranAnhTuan_TH05.Solution.Bai2
{
    partial class Form2
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
            this.dgvCongDan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongDan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCongDan
            // 
            this.dgvCongDan.AllowUserToAddRows = false;
            this.dgvCongDan.AllowUserToDeleteRows = false;
            this.dgvCongDan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCongDan.Location = new System.Drawing.Point(12, 12);
            this.dgvCongDan.Name = "dgvCongDan";
            this.dgvCongDan.ReadOnly = true;
            this.dgvCongDan.RowHeadersWidth = 51;
            this.dgvCongDan.RowTemplate.Height = 24;
            this.dgvCongDan.Size = new System.Drawing.Size(776, 414);
            this.dgvCongDan.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 438);
            this.Controls.Add(this.dgvCongDan);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongDan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCongDan;
    }
}
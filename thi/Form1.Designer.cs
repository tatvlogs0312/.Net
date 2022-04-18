
namespace thi
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
            this.dgvSim = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdsim = new System.Windows.Forms.TextBox();
            this.txtSosim = new System.Windows.Forms.TextBox();
            this.txtMang = new System.Windows.Forms.TextBox();
            this.txtNKH = new System.Windows.Forms.MaskedTextBox();
            this.txtNHH = new System.Windows.Forms.MaskedTextBox();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSim)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSim
            // 
            this.dgvSim.AllowUserToAddRows = false;
            this.dgvSim.AllowUserToDeleteRows = false;
            this.dgvSim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSim.Location = new System.Drawing.Point(502, 25);
            this.dgvSim.Name = "dgvSim";
            this.dgvSim.ReadOnly = true;
            this.dgvSim.RowHeadersWidth = 51;
            this.dgvSim.RowTemplate.Height = 24;
            this.dgvSim.Size = new System.Drawing.Size(736, 522);
            this.dgvSim.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id sim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số sim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Id mạng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày kích hoạt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ngày hết hạn";
            // 
            // txtIdsim
            // 
            this.txtIdsim.Location = new System.Drawing.Point(205, 77);
            this.txtIdsim.Name = "txtIdsim";
            this.txtIdsim.Size = new System.Drawing.Size(182, 22);
            this.txtIdsim.TabIndex = 1;
            // 
            // txtSosim
            // 
            this.txtSosim.Location = new System.Drawing.Point(205, 120);
            this.txtSosim.Name = "txtSosim";
            this.txtSosim.Size = new System.Drawing.Size(182, 22);
            this.txtSosim.TabIndex = 2;
            // 
            // txtMang
            // 
            this.txtMang.Location = new System.Drawing.Point(205, 166);
            this.txtMang.Name = "txtMang";
            this.txtMang.Size = new System.Drawing.Size(182, 22);
            this.txtMang.TabIndex = 3;
            // 
            // txtNKH
            // 
            this.txtNKH.Location = new System.Drawing.Point(205, 213);
            this.txtNKH.Mask = "0000-00-00";
            this.txtNKH.Name = "txtNKH";
            this.txtNKH.Size = new System.Drawing.Size(182, 22);
            this.txtNKH.TabIndex = 4;
            // 
            // txtNHH
            // 
            this.txtNHH.Location = new System.Drawing.Point(205, 268);
            this.txtNHH.Mask = "0000-00-00";
            this.txtNHH.Name = "txtNHH";
            this.txtNHH.Size = new System.Drawing.Size(182, 22);
            this.txtNHH.TabIndex = 5;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(156, 402);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(113, 44);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 588);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtNHH);
            this.Controls.Add(this.txtNKH);
            this.Controls.Add(this.txtMang);
            this.Controls.Add(this.txtSosim);
            this.Controls.Add(this.txtIdsim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdsim;
        private System.Windows.Forms.TextBox txtSosim;
        private System.Windows.Forms.TextBox txtMang;
        private System.Windows.Forms.MaskedTextBox txtNKH;
        private System.Windows.Forms.MaskedTextBox txtNHH;
        private System.Windows.Forms.Button btnThem;
    }
}


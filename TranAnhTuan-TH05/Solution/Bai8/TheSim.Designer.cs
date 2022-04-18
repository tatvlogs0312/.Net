
namespace TranAnhTuan_TH05.Solution.Bai8
{
    partial class TheSim
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
            this.txtSo = new System.Windows.Forms.TextBox();
            this.btnKT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số sim";
            // 
            // txtSo
            // 
            this.txtSo.Location = new System.Drawing.Point(230, 148);
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(197, 22);
            this.txtSo.TabIndex = 1;
            // 
            // btnKT
            // 
            this.btnKT.Location = new System.Drawing.Point(196, 257);
            this.btnKT.Name = "btnKT";
            this.btnKT.Size = new System.Drawing.Size(104, 40);
            this.btnKT.TabIndex = 2;
            this.btnKT.Text = "Kiểm tra";
            this.btnKT.UseVisualStyleBackColor = true;
            this.btnKT.Click += new System.EventHandler(this.btnKT_Click);
            // 
            // TheSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 360);
            this.Controls.Add(this.btnKT);
            this.Controls.Add(this.txtSo);
            this.Controls.Add(this.label1);
            this.Name = "TheSim";
            this.Text = "TheSim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.Button btnKT;
    }
}
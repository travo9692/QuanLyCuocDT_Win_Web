namespace QuanLyDT.Winform
{
    partial class MainThanhToan
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
            this.btnAddEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaSim = new System.Windows.Forms.TextBox();
            this.btnThemSim = new System.Windows.Forms.Button();
            this.txtCuocThueBao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddEdit
            // 
            this.btnAddEdit.Location = new System.Drawing.Point(148, 147);
            this.btnAddEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddEdit.Name = "btnAddEdit";
            this.btnAddEdit.Size = new System.Drawing.Size(100, 28);
            this.btnAddEdit.TabIndex = 0;
            this.btnAddEdit.Text = "Cập nhật";
            this.btnAddEdit.UseVisualStyleBackColor = true;
            this.btnAddEdit.Click += new System.EventHandler(this.btnAddEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(256, 147);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã Sim";
            // 
            // txtMaSim
            // 
            this.txtMaSim.Location = new System.Drawing.Point(148, 64);
            this.txtMaSim.Name = "txtMaSim";
            this.txtMaSim.Size = new System.Drawing.Size(178, 22);
            this.txtMaSim.TabIndex = 12;
            // 
            // btnThemSim
            // 
            this.btnThemSim.Location = new System.Drawing.Point(333, 63);
            this.btnThemSim.Name = "btnThemSim";
            this.btnThemSim.Size = new System.Drawing.Size(22, 23);
            this.btnThemSim.TabIndex = 13;
            this.btnThemSim.Text = "...";
            this.btnThemSim.UseVisualStyleBackColor = true;
            this.btnThemSim.Click += new System.EventHandler(this.btnThemSim_Click);
            // 
            // txtCuocThueBao
            // 
            this.txtCuocThueBao.Location = new System.Drawing.Point(147, 105);
            this.txtCuocThueBao.Name = "txtCuocThueBao";
            this.txtCuocThueBao.Size = new System.Drawing.Size(208, 22);
            this.txtCuocThueBao.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "Cước thuê bao";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(147, 21);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(208, 22);
            this.txtMaHD.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Mã hóa đơn";
            // 
            // MainThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 192);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCuocThueBao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnThemSim);
            this.Controls.Add(this.txtMaSim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddEdit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh toán";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaSim;
        private System.Windows.Forms.Button btnThemSim;
        private System.Windows.Forms.TextBox txtCuocThueBao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label1;
    }
}
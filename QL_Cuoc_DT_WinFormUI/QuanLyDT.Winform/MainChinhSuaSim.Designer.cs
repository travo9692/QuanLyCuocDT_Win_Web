namespace QuanLyDT.Winform
{
    partial class MainChinhSuaSim
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
            this.bttAddEdit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttAddEdit
            // 
            this.bttAddEdit.Location = new System.Drawing.Point(55, 59);
            this.bttAddEdit.Name = "bttAddEdit";
            this.bttAddEdit.Size = new System.Drawing.Size(75, 23);
            this.bttAddEdit.TabIndex = 7;
            this.bttAddEdit.Text = "Lưu";
            this.bttAddEdit.UseVisualStyleBackColor = true;
            this.bttAddEdit.Click += new System.EventHandler(this.bttAddEdit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Hủy bỏ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSim
            // 
            this.txtSim.Location = new System.Drawing.Point(76, 12);
            this.txtSim.Name = "txtSim";
            this.txtSim.Size = new System.Drawing.Size(135, 20);
            this.txtSim.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Số SIM";
            // 
            // MainChinhSuaSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 95);
            this.Controls.Add(this.bttAddEdit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSim);
            this.Controls.Add(this.label1);
            this.Name = "MainChinhSuaSim";
            this.Text = "Chỉnh sửa sim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttAddEdit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSim;
        private System.Windows.Forms.Label label1;
    }
}
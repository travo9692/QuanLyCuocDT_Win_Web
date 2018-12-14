namespace QuanLyDT.Winform
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsubj = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtmess = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nội dung";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 55);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Subject";
            // 
            // txtsubj
            // 
            this.txtsubj.Location = new System.Drawing.Point(120, 51);
            this.txtsubj.Margin = new System.Windows.Forms.Padding(4);
            this.txtsubj.Name = "txtsubj";
            this.txtsubj.Size = new System.Drawing.Size(440, 20);
            this.txtsubj.TabIndex = 0;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(120, 83);
            this.txtusername.Margin = new System.Windows.Forms.Padding(4);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(440, 20);
            this.txtusername.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtmess);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtto);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtpass);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtsubj);
            this.panel1.Controls.Add(this.txtusername);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 372);
            this.panel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "To";
            // 
            // txtto
            // 
            this.txtto.Location = new System.Drawing.Point(120, 21);
            this.txtto.Margin = new System.Windows.Forms.Padding(4);
            this.txtto.Name = "txtto";
            this.txtto.Size = new System.Drawing.Size(383, 20);
            this.txtto.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Mật khẩu";
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(120, 119);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '@';
            this.txtpass.Size = new System.Drawing.Size(440, 20);
            this.txtpass.TabIndex = 35;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(302, 333);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 28);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(446, 333);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(117, 28);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "Gửi";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtmess
            // 
            this.txtmess.Location = new System.Drawing.Point(120, 161);
            this.txtmess.Multiline = true;
            this.txtmess.Name = "txtmess";
            this.txtmess.Size = new System.Drawing.Size(440, 151);
            this.txtmess.TabIndex = 39;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 377);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsubj;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtmess;
    }
}
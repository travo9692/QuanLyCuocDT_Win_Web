using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace QuanLyDT.Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string title, string btnText)
        {
            InitializeComponent();
            this.Text = title;
            btnSend.Text = btnText;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            GuiMail(txtusername.Text, txtto.Text, txtsubj.Text, txtmess.Text);
        }

        /// <summary>
        /// gửi mail
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="subject"></param>
        /// <param name="message"></param>
        void GuiMail (string from, string to, string subject, string mess)
        {

                MailMessage message = new MailMessage("huongvi57751@gmail.com", to, subject, mess);
                SmtpClient client = new SmtpClient("smtp.gmail.com");

                client.Port = 587;
                client.Credentials = new System.Net.NetworkCredential("hoangtam75331@gmail.com", "8448921@gmail.com");
                client.EnableSsl = true;

                client.Send(message);
                MessageBox.Show("mail Send");
              
        }
    }
}

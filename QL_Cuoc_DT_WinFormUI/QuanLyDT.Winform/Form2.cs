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
using System.IO;

namespace QuanLyDT.Winform
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = openFileDialog1.ShowDialog();
            if (dialog == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }


        void GuiMail(string from, string to, string subject, string mess)
        {

            MailMessage message = new MailMessage(from, to, subject, mess);
            SmtpClient client = new SmtpClient("smtp.gmail.com");

            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential( txtusername.Text, txtpass.Text);
            client.EnableSsl = true;

            client.Send(message);
            MessageBox.Show("Thành công");

        }

        private void btnSend_Click(object sender, EventArgs e)
        {

            StreamReader reader = new StreamReader(textBox1.Text);
            string email;
            while((email = reader.ReadLine()) != null)
            {
                GuiMail(txtusername.Text, email, txtsubj.Text, txtmess.Text);
            }
            
        }
    }
}

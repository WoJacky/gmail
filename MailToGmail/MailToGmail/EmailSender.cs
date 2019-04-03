using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Mail;

namespace MailToGmail
{
	public partial class EmailSender : Form
	{
		string password, email;
		MailMessage mail = new MailMessage();
		SmtpClient smtsever = new SmtpClient("smtp.gmail.com",587);
		public EmailSender(string email ,string password)
		{
			InitializeComponent();
			this.password = password;
			this.email = email;
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void EmailSender_Load(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btn_To_Click(object sender, EventArgs e)
		{
			try
			{
				mail.From = new MailAddress(email);
				mail.To.Add(txt_To.Text);
				mail.Subject = txt_subject.Text;
				mail.Body = txt_msg.Text;
				smtsever.Credentials = new System.Net.NetworkCredential(email, password);
				smtsever.EnableSsl = true;
				smtsever.Send(mail);
				MessageBox.Show("Mail has benn Sended", "Congrates", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				throw;
			}
		}
	}
}

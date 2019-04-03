using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailToGmail
{
	public partial class SingPassword : Form
	{
		string email = "";
		public SingPassword(string email)
		{
			InitializeComponent();
			this.email = email;
		}

		private void txtPassword_Enter(object sender, EventArgs e)
		{
			txtPassword.isPassword = true;
		}

		private void btn_Next_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(txtPassword.Text))
			{
				new EmailSender(email, txtPassword.Text).Show();
				this.Close();
			}
			else {
				errorProvider1.SetError(txtPassword, "Enter the f.. password");
				}
		}
	}
}

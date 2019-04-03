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
	public partial class SignUp : Form
	{
		public SignUp()
		{
			InitializeComponent();
		}

		private void SignUp_Load(object sender, EventArgs e)
		{
			lbl_Email.Visible = false;
		}

		private void txt_Email_Enter(object sender, EventArgs e)
		{
			lbl_Email.Visible = true;
		}

		private void btn_Next_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(txt_Email.Text))
			{
				string email = txt_Email.Text;
				new SingPassword(email).Show();
				this.Close();
			}
			else
			{
				errorProvider1.SetError(txt_Email, "Enter email or phone");
			}
		}

		private void txt_Email_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txt_Email.Text))
			{
				lbl_Email.Visible = false;
			}
		}
	}
}

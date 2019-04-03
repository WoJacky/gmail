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
	public partial class SignEmail : Form
	{
		public SignEmail()
		{
			InitializeComponent();
		}
		int n = 1;
		private void timer1_Tick(object sender, EventArgs e)
		{
			if (n == 3)
			{
				timer1.Stop();
				new SignUp().Show();
				this.Hide();
			}
			n++;
		}

		private void SignEmail_Load(object sender, EventArgs e)
		{

		}
	}
}

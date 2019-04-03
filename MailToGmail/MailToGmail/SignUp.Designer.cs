namespace MailToGmail
{
	partial class SignUp
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_Email = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.lbl_Email = new System.Windows.Forms.Label();
			this.btn_Next = new System.Windows.Forms.Button();
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.btn_Next);
			this.panel1.Controls.Add(this.lbl_Email);
			this.panel1.Controls.Add(this.txt_Email);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(188, 34);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(431, 457);
			this.panel1.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(131, 33);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(180, 45);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(178, 93);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 26);
			this.label1.TabIndex = 1;
			this.label1.Text = "Sign In";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(152, 119);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(122, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "to connect to Gmail";
			// 
			// txt_Email
			// 
			this.txt_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_Email.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.txt_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txt_Email.HintForeColor = System.Drawing.Color.Empty;
			this.txt_Email.HintText = "Email";
			this.txt_Email.isPassword = false;
			this.txt_Email.LineFocusedColor = System.Drawing.Color.Blue;
			this.txt_Email.LineIdleColor = System.Drawing.Color.Gray;
			this.txt_Email.LineMouseHoverColor = System.Drawing.Color.Blue;
			this.txt_Email.LineThickness = 1;
			this.txt_Email.Location = new System.Drawing.Point(26, 224);
			this.txt_Email.Margin = new System.Windows.Forms.Padding(4);
			this.txt_Email.Name = "txt_Email";
			this.txt_Email.Size = new System.Drawing.Size(329, 33);
			this.txt_Email.TabIndex = 3;
			this.txt_Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txt_Email.Enter += new System.EventHandler(this.txt_Email_Enter);
			this.txt_Email.Leave += new System.EventHandler(this.txt_Email_Leave);
			// 
			// lbl_Email
			// 
			this.lbl_Email.AutoSize = true;
			this.lbl_Email.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Email.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.lbl_Email.Location = new System.Drawing.Point(31, 176);
			this.lbl_Email.Name = "lbl_Email";
			this.lbl_Email.Size = new System.Drawing.Size(115, 21);
			this.lbl_Email.TabIndex = 4;
			this.lbl_Email.Text = "Email or Phone";
			// 
			// btn_Next
			// 
			this.btn_Next.BackColor = System.Drawing.Color.DodgerBlue;
			this.btn_Next.FlatAppearance.BorderSize = 0;
			this.btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Next.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btn_Next.ForeColor = System.Drawing.Color.White;
			this.btn_Next.Location = new System.Drawing.Point(270, 338);
			this.btn_Next.Name = "btn_Next";
			this.btn_Next.Size = new System.Drawing.Size(111, 41);
			this.btn_Next.TabIndex = 5;
			this.btn_Next.Text = "Next";
			this.btn_Next.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btn_Next.UseVisualStyleBackColor = false;
			this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 5;
			this.bunifuElipse1.TargetControl = this;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// SignUp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(803, 503);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "SignUp";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SignUp";
			this.Load += new System.EventHandler(this.SignUp_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Email;
		private System.Windows.Forms.Button btn_Next;
		private System.Windows.Forms.Label lbl_Email;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}
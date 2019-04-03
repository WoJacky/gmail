namespace MailToGmail
{
	partial class EmailSender
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailSender));
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.txt_To = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txt_msg = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btn_To = new System.Windows.Forms.Button();
			this.txt_subject = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 5;
			this.bunifuElipse1.TargetControl = this;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(296, 92);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(443, 44);
			this.label1.TabIndex = 0;
			this.label1.Text = "Welcome To .NET Gmail";
			// 
			// txt_To
			// 
			this.txt_To.Location = new System.Drawing.Point(210, 32);
			this.txt_To.Name = "txt_To";
			this.txt_To.Size = new System.Drawing.Size(550, 33);
			this.txt_To.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Firebrick;
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(803, 46);
			this.panel1.TabIndex = 3;
			// 
			// button2
			// 
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(745, 0);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(46, 46);
			this.button2.TabIndex = 4;
			this.button2.Text = "X";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.Location = new System.Drawing.Point(693, 0);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(46, 46);
			this.button3.TabIndex = 5;
			this.button3.Text = "-";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(39, 64);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(236, 100);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(160, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(33, 26);
			this.label2.TabIndex = 5;
			this.label2.Text = "To";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txt_subject);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.btn_To);
			this.groupBox1.Controls.Add(this.txt_msg);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txt_To);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(0, 170);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(791, 321);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Compose Message";
			// 
			// txt_msg
			// 
			this.txt_msg.Location = new System.Drawing.Point(210, 133);
			this.txt_msg.Multiline = true;
			this.txt_msg.Name = "txt_msg";
			this.txt_msg.Size = new System.Drawing.Size(550, 187);
			this.txt_msg.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(118, 136);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 26);
			this.label3.TabIndex = 7;
			this.label3.Text = "Message";
			// 
			// btn_To
			// 
			this.btn_To.BackColor = System.Drawing.Color.DodgerBlue;
			this.btn_To.FlatAppearance.BorderSize = 0;
			this.btn_To.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_To.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btn_To.ForeColor = System.Drawing.Color.White;
			this.btn_To.Location = new System.Drawing.Point(49, 247);
			this.btn_To.Name = "btn_To";
			this.btn_To.Size = new System.Drawing.Size(109, 40);
			this.btn_To.TabIndex = 8;
			this.btn_To.Text = "Send";
			this.btn_To.UseVisualStyleBackColor = false;
			this.btn_To.Click += new System.EventHandler(this.btn_To_Click);
			// 
			// txt_subject
			// 
			this.txt_subject.Location = new System.Drawing.Point(210, 78);
			this.txt_subject.Name = "txt_subject";
			this.txt_subject.Size = new System.Drawing.Size(550, 33);
			this.txt_subject.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(130, 81);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(74, 26);
			this.label4.TabIndex = 10;
			this.label4.Text = "Subject";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(12, 3);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(207, 46);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 6;
			this.pictureBox2.TabStop = false;
			// 
			// EmailSender
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(803, 503);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "EmailSender";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "EmailSender";
			this.Load += new System.EventHandler(this.EmailSender_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txt_To;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btn_To;
		private System.Windows.Forms.TextBox txt_msg;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_subject;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pictureBox2;
	}
}
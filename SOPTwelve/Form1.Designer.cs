namespace SOPTwelve
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			button1 = new Button();
			webForm = new WebBrowser();
			webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
			button2 = new Button();
			button3 = new Button();
			txInstance = new TextBox();
			tbUser = new TextBox();
			tbPassword = new TextBox();
			richTextBox1 = new RichTextBox();
			((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new Point(380, 25);
			button1.Name = "button1";
			button1.Size = new Size(188, 58);
			button1.TabIndex = 0;
			button1.Text = "Add Text";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// webForm
			// 
			webForm.Location = new Point(0, 0);
			webForm.Name = "webForm";
			webForm.Size = new Size(250, 250);
			webForm.TabIndex = 0;
			// 
			// webView21
			// 
			webView21.AllowExternalDrop = true;
			webView21.CreationProperties = null;
			webView21.DefaultBackgroundColor = Color.White;
			webView21.Location = new Point(25, 240);
			webView21.Name = "webView21";
			webView21.Size = new Size(2353, 1260);
			webView21.Source = new Uri("https://hackathon.acumatica.com/Theta", UriKind.Absolute);
			webView21.TabIndex = 1;
			webView21.ZoomFactor = 1D;
			webView21.Click += webView21_Click;
			// 
			// button2
			// 
			button2.Location = new Point(1355, 1542);
			button2.Name = "button2";
			button2.Size = new Size(188, 58);
			button2.TabIndex = 2;
			button2.Text = "button2";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button3
			// 
			button3.Location = new Point(25, 25);
			button3.Name = "button3";
			button3.Size = new Size(349, 58);
			button3.TabIndex = 3;
			button3.Text = "Add info";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// txInstance
			// 
			txInstance.Location = new Point(25, 1520);
			txInstance.Name = "txInstance";
			txInstance.Size = new Size(754, 47);
			txInstance.TabIndex = 4;
			txInstance.Text = "https://hackathon.acumatica.com/Theta";
			// 
			// tbUser
			// 
			tbUser.Location = new Point(811, 1520);
			tbUser.Name = "tbUser";
			tbUser.Size = new Size(250, 47);
			tbUser.TabIndex = 5;
			tbUser.Text = "admin";
			// 
			// tbPassword
			// 
			tbPassword.Location = new Point(1085, 1520);
			tbPassword.Name = "tbPassword";
			tbPassword.Size = new Size(250, 47);
			tbPassword.TabIndex = 6;
			tbPassword.Text = "team12corn";
			// 
			// richTextBox1
			// 
			richTextBox1.Location = new Point(25, 89);
			richTextBox1.Name = "richTextBox1";
			richTextBox1.Size = new Size(1985, 130);
			richTextBox1.TabIndex = 7;
			richTextBox1.Text = "";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(17F, 41F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(2368, 1612);
			Controls.Add(richTextBox1);
			Controls.Add(tbPassword);
			Controls.Add(tbUser);
			Controls.Add(txInstance);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(webView21);
			Controls.Add(button1);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)webView21).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button1;
		private WebBrowser webForm;
		private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
		private Button button2;
		private Button button3;
		private TextBox txInstance;
		private TextBox tbUser;
		private TextBox tbPassword;
		private RichTextBox richTextBox1;
	}
}

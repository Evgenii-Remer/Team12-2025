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
			((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new Point(113, 25);
			button1.Name = "button1";
			button1.Size = new Size(188, 58);
			button1.TabIndex = 0;
			button1.Text = "button1";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			webView21.AllowExternalDrop = true;
			webView21.CreationProperties = null;
			webView21.DefaultBackgroundColor = Color.White;
			webView21.Location = new Point(25, 118);
			webView21.Name = "webView21";
			webView21.Size = new Size(3092, 1782);
			webView21.Source = new Uri("https://hackathon.acumatica.com/Theta", UriKind.Absolute);
			webView21.TabIndex = 1;
			webView21.ZoomFactor = 1D;
			webView21.Click += webView21_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(17F, 41F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(3129, 1912);
			Controls.Add(webView21);
			Controls.Add(button1);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)webView21).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Button button1;
		private WebBrowser webForm;
		private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
	}
}

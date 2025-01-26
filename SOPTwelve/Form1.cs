namespace SOPTwelve
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void webView21_Click(object sender, EventArgs e)
		{

		}

		private async void button1_Click(object sender, EventArgs e)
		{
			//var ms = new MemoryStream();
			//var devData = webView21.CoreWebView2.CapturePreviewAsync(Microsoft.Web.WebView2.Core.CoreWebView2CapturePreviewImageFormat.Jpeg, ms);



			//var bitmap = (Bitmap)Image.FromStream(ms.);
			//bitmap.Save("c:\\temp\\screenshot.png");
			//webView21.CoreWebView2.PrintToPdfAsync("c:\\temp\\File.pdf");
			FileStream fs = File.Create("c:\\temp\\capture2.jpg");
		
			Task t =	webView21.CoreWebView2.CapturePreviewAsync(Microsoft.Web.WebView2.Core.CoreWebView2CapturePreviewImageFormat.Jpeg, fs);
			await t;
			fs.Close();
			
		}
	}
}

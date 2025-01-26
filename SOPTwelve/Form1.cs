using Acumatica.Default_24_200_001.Model;
using Acumatica.RESTClient.AuthApi;
using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.FileApi;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace SOPTwelve
{
	public partial class Form1 : Form
	{
		ApiClient client = null;

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
			if (client == null)
			{
				client = new ApiClient(txInstance.Text,
					 ignoreSslErrors: true // this is here to allow testing with self-signed certificates
					);
			}

			client.Login(tbUser.Text, tbPassword.Text);
			try
			{
				//var order = client.GetById<WikiPage>(new Guid("47F3EBB4-E459-4009-9DA3-CDD917C968B3"));
				//var order = client.GetByKeys<WikiPage>(new List<string>() { "47F3EBB4-E459-4009-9DA3-CDD917C968B3" }, expand: "files");

				//var order = client.GetByKeys<SalesOrder>(new List<string>() { "SO", "SO008319" }, expand: "files");

				////System.Threading.Tasks.Task t = webView21.CoreWebView2.CapturePreviewAsync(Microsoft.Web.WebView2.Core.CoreWebView2CapturePreviewImageFormat.Jpeg, memoryStream);
				////await t;

				////string fileName = "capture" + (order?.Files?.Count + 1).ToString() ?? "" + ".jpg";
				////string fileDesc = "It is a capture";
				////Obsolete
				////client.PutFile<SalesOrder>("SO/SO005207", fileName, initialData);

				////client.PutFile(order, fileName, memoryStream.ToArray(), fileDesc);

				////order = client.GetByKeys<SalesOrder>(new List<string>() { "SO", "SO008320" }, expand: "files");

				var revision = client.GetByKeys<WikiRevision>(new List<string>() { "47f3ebb4-e459-4009-9da3-cdd917c968b3", "en-US", "5" });
				var sb = new StringBuilder(revision.Content);
				sb.AppendLine(richTextBox1.Text);
				revision.Content = sb.ToString();

				client.Put(revision);

			}
			finally
			{
				client.Logout();
			}

		}
		private async void button2_Click(object sender, EventArgs e)
		{
			var client = new ApiClient("http://localhost/ClearSite",
				 //requestInterceptor: RequestLogger.LogRequest,
				 //responseInterceptor: RequestLogger.LogResponse,
				 ignoreSslErrors: true // this is here to allow testing with self-signed certificates
				);

			client.Login("admin", "123");

			var order = client.GetByKeys<SalesOrder>(new List<string>() { "SO", "SO008320" }, expand: "files");

			byte[] initialData = Encoding.UTF8.GetBytes("Acumatica is awesome");

			MemoryStream memoryStream = new MemoryStream();
			System.Threading.Tasks.Task t = webView21.CoreWebView2.CapturePreviewAsync(Microsoft.Web.WebView2.Core.CoreWebView2CapturePreviewImageFormat.Jpeg, memoryStream);
			await t;


			string fileName = "capture2.jpg";
			string fileDesc = "It is a capture";
			//Obsolete
			//client.PutFile<SalesOrder>("SO/SO005207", fileName, initialData);

			client.PutFile(order, fileName, memoryStream.ToArray(), fileDesc);
			memoryStream.Close();
		}

		private async void button3_Click(object sender, EventArgs e)
		{
			if (client == null)
			{
				client = new ApiClient(txInstance.Text,
					 ignoreSslErrors: true // this is here to allow testing with self-signed certificates
					);
			}

			client.Login(tbUser.Text, tbPassword.Text);

			MemoryStream memoryStream = new MemoryStream();

			try
			{
				//var order = client.GetById<WikiPage>(new Guid("47F3EBB4-E459-4009-9DA3-CDD917C968B3"));
				//var order = client.GetByKeys<WikiPage>(new List<string>() { "47F3EBB4-E459-4009-9DA3-CDD917C968B3" }, expand: "files");

				var order = client.GetByKeys<SalesOrder>(new List<string>() { "SO", "SO008319" }, expand: "files");

				System.Threading.Tasks.Task t = webView21.CoreWebView2.CapturePreviewAsync(Microsoft.Web.WebView2.Core.CoreWebView2CapturePreviewImageFormat.Jpeg, memoryStream);
				await t;

				string fileName = "capture" + (order?.Files?.Count + 1).ToString() ?? "" + ".jpg";
				string fileDesc = "It is a capture";
				//Obsolete
				//client.PutFile<SalesOrder>("SO/SO005207", fileName, initialData);

				client.PutFile(order, fileName, memoryStream.ToArray(), fileDesc);

				order = client.GetByKeys<SalesOrder>(new List<string>() { "SO", "SO008320" }, expand: "files");

				var revision = client.GetByKeys<WikiRevision>(new List<string>() { "47f3ebb4-e459-4009-9da3-cdd917c968b3", "en-US", "4" });


			}
			finally
			{
				memoryStream.Close();
				client.Logout();
			}
		}
	}
}

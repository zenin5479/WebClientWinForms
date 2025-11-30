using System.IO;
using System.Net;
using System.Windows.Forms;

namespace WebClientWinForms
{
   public partial class FormOne : Form
   {
      public FormOne()
      {
         InitializeComponent();

         WebRequest wrq = WebRequest.Create("https://example.com"); WebResponse wrs = wrq.GetResponse();
         Stream strm = wrs.GetResponseStream();
         if (strm != null)
         {
            StreamReader sr = new StreamReader(strm);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
               listBox1.Items.Add(line);
            }

            sr.Close();
            strm.Close();
         }
      }

      private void ButtonWebClient_Click(object sender, System.EventArgs e)
      {
         WebClient client = new WebClient();
         Stream scanner = client.OpenRead("https://example.com");
         if (scanner != null)
         {
            StreamReader reader = new StreamReader(scanner);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
               TextBoxReader.Text = line;
               listBox1.Items.Add(line);
            }

            scanner.Close();
         }




         WebRequest wrq = WebRequest.Create("https://example.com"); HttpWebRequest hwrq = (HttpWebRequest)wrq;
         listBox1.Items.Add("Request Timeout (ms) = " + wrq.Timeout);
         listBox1.Items.Add("Request Keep Alive = " + hwrq.KeepAlive);
         listBox1.Items.Add("Request AllowAutoRedirect = " + hwrq.AllowAutoRedirect);
      }
   }
}
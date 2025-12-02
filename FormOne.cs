using System;
using System.Drawing;
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

         string lineone = ("Request Timeout (ms) = " + wrq.Timeout);
         TextBoxReader.Text = lineone;
         TextBoxReader.Text = Environment.NewLine;
         string linetwo = ("Request Keep Alive = " + hwrq.KeepAlive);
         TextBoxReader.Text = linetwo;
         string linethree = ("Request AllowAutoRedirect = " + hwrq.AllowAutoRedirect);
         TextBoxReader.Text = linethree;

         TextBoxReader.Text = string.Format("{0:f2}", 1.0 / 3.0);
         TextBoxReader.Text = "First line" + Environment.NewLine;
         TextBoxReader.Text = "Second line" + Environment.NewLine;
         TextBoxReader.Text = "Third line";
         TextBoxReader.Text = (string.Format("Header {0}: {1}", wrq.Timeout, hwrq.KeepAlive)); //

         RichTextBoxSavelog.AppendText(lineone + "\n");
         RichTextBoxSavelog.AppendText(Environment.NewLine + linetwo);
         RichTextBoxSavelog.AppendText(Environment.NewLine + linethree);
         RichTextBoxSavelog.AppendText(string.Format("Header {0}: {1}", wrq.Timeout, hwrq.KeepAlive)); //

         RichTextBoxSavelog.ScrollToCaret();

         listBox1.Items.Add("Request Timeout (ms) = " + wrq.Timeout);
         listBox1.Items.Add("Request Keep Alive = " + hwrq.KeepAlive);
         listBox1.Items.Add("Request AllowAutoRedirect = " + hwrq.AllowAutoRedirect);
         listBox1.Items.Add(string.Format("Header {0}: {1}", wrq.Timeout, hwrq.KeepAlive));
      }
   }
}
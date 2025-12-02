using System;
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
      }

      private void ButtonWebClient_Click(object sender, EventArgs e)
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
               ListBoxReader.Items.Add(line);
               RichTextBoxReader.AppendText(line);
            }
            
            scanner.Close();
         }
      }

      private void ButtonWebRequest_Click(object sender, EventArgs e)
      {
         WebRequest request = WebRequest.Create("https://example.com");
         WebResponse response = request.GetResponse();
         Stream scanner = response.GetResponseStream();
         if (scanner != null)
         {
            StreamReader reader = new StreamReader(scanner);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
               ListBoxReader.Items.Add(line);
            }

            reader.Close();
            scanner.Close();
         }

         WebRequest ask = WebRequest.Create("https://example.com");
         HttpWebRequest httpask = (HttpWebRequest)ask;
         string lineone = ("Время ожидания запроса (мс) = " + ask.Timeout);
         TextBoxReader.Text = lineone;
         TextBoxReader.Text = Environment.NewLine;

         // Задает значение, указывающее, следует ли выполнять постоянное подключение к интернет-ресурсу
         string linetwo = ("Запрос постоянно поддерживать= " + httpask.KeepAlive);
         TextBoxReader.Text = linetwo;
         // Задает значение, указывающее, должен ли запрос следовать ответам перенаправления
         string linethree = ("Запрос поддерживает перенаправление = " + httpask.AllowAutoRedirect);
         TextBoxReader.Text = linethree;

         TextBoxReader.Text = string.Format("{0:f2}", 1.0 / 3.0);
         TextBoxReader.Text = "First line" + Environment.NewLine;
         TextBoxReader.Text = "Second line" + Environment.NewLine;
         TextBoxReader.Text = "Third line";
         TextBoxReader.Text = (string.Format("Header {0}: {1}", ask.Timeout, httpask.KeepAlive)); //

         RichTextBoxReader.AppendText(lineone + "\n");
         RichTextBoxReader.AppendText(Environment.NewLine + linetwo);
         RichTextBoxReader.AppendText(Environment.NewLine + linethree);
         RichTextBoxReader.AppendText(string.Format("Header {0}: {1}", ask.Timeout, httpask.KeepAlive)); //

         RichTextBoxReader.ScrollToCaret();

         ListBoxReader.Items.Add("Время ожидания запроса (мс) = " + ask.Timeout);
         ListBoxReader.Items.Add("Request Keep Alive = " + httpask.KeepAlive);
         ListBoxReader.Items.Add("Request AllowAutoRedirect = " + httpask.AllowAutoRedirect);
         ListBoxReader.Items.Add(string.Format("Header {0}: {1}", ask.Timeout, httpask.KeepAlive));
      }

      private void ButtonClear_Click(object sender, EventArgs e)
      {
         TextBoxReader.Clear();
         RichTextBoxReader.Clear();
         ListBoxReader.Items.Clear();
      }
   }
}
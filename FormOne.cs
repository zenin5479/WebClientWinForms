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
         Stream scanner = client.OpenRead("http://127.0.0.1:8888/connection/");
         //Stream scanner = client.OpenRead("http://localhost:8080/");
         //Stream scanner = client.OpenRead("https://example.com");
         if (scanner != null)
         {
            StreamReader reader = new StreamReader(scanner);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
               // TextBox
               // Добавляет строку стирая предыдущие
               //TextBoxReader.Text = one;
               // Добавляет строку оставляя предыдущие
               TextBoxReader.AppendText(line);
               // Переход на следующую строку
               TextBoxReader.AppendText(Environment.NewLine);
               TextBoxReader.ScrollToCaret();

               // ListBox
               ListBoxReader.Items.Add(line);
               // Прокрутка ListBox вниз
               ListBoxReader.TopIndex = ListBoxReader.Items.Count - 1;

               // RichTextBox
               RichTextBoxReader.AppendText(line);
               RichTextBoxReader.AppendText(Environment.NewLine);
               RichTextBoxReader.ScrollToCaret();
            }

            reader.Close();
            scanner.Close();
         }
      }

      private void ButtonWebRequest_Click(object sender, EventArgs e)
      {
         WebRequest request = WebRequest.Create("http://localhost:8080/");
         //WebRequest request = WebRequest.Create("https://example.com");
         WebResponse response = request.GetResponse();
         Stream scanner = response.GetResponseStream();
         if (scanner != null)
         {
            StreamReader reader = new StreamReader(scanner);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
               // TextBox
               // Добавляет строку стирая предыдущие
               //TextBoxReader.Text = one;
               // Добавляет строку оставляя предыдущие
               TextBoxReader.AppendText(line);
               // Переход на следующую строку
               TextBoxReader.AppendText(Environment.NewLine);
               TextBoxReader.ScrollToCaret();

               // ListBox
               ListBoxReader.Items.Add(line);
               // Прокрутка ListBox вниз
               ListBoxReader.TopIndex = ListBoxReader.Items.Count - 1;

               // RichTextBox
               RichTextBoxReader.AppendText(line);
               RichTextBoxReader.AppendText(Environment.NewLine);
               RichTextBoxReader.ScrollToCaret();
            }

            reader.Close();
            scanner.Close();
         }
      }

      private void ButtonHttpWebRequest_Click(object sender, EventArgs e)
      {
         WebRequest ask = WebRequest.Create("http://localhost:8080/");
         //WebRequest ask = WebRequest.Create("https://example.com");
         HttpWebRequest httpask = (HttpWebRequest)ask;
         string lineone = ("Время ожидания запроса (мс) = " + ask.Timeout);
         // Задает значение, указывающее, следует ли выполнять постоянное подключение к интернет-ресурсу
         string linetwo = ("Запрос постоянно поддерживать = " + httpask.KeepAlive);
         // Задает значение, указывающее, должен ли запрос следовать ответам перенаправления
         string linethree = ("Запрос поддерживает перенаправление = " + httpask.AllowAutoRedirect);
         TextBoxReader.AppendText(lineone);
         TextBoxReader.AppendText(Environment.NewLine);
         TextBoxReader.AppendText(linetwo);
         TextBoxReader.AppendText(Environment.NewLine);
         TextBoxReader.AppendText(linethree);
         TextBoxReader.AppendText(Environment.NewLine);
         TextBoxReader.ScrollToCaret();

         ListBoxReader.Items.Add(lineone);
         ListBoxReader.Items.Add(linetwo);
         ListBoxReader.Items.Add(linethree);
         // Прокрутка ListBox вниз
         ListBoxReader.TopIndex = ListBoxReader.Items.Count - 1;

         RichTextBoxReader.AppendText(lineone);
         RichTextBoxReader.AppendText(Environment.NewLine);
         RichTextBoxReader.AppendText(linetwo);
         RichTextBoxReader.AppendText(Environment.NewLine);
         RichTextBoxReader.AppendText(linethree);
         RichTextBoxReader.AppendText(Environment.NewLine);
         RichTextBoxReader.ScrollToCaret();
      }

      private void ButtonClear_Click(object sender, EventArgs e)
      {
         TextBoxReader.Clear();
         RichTextBoxReader.Clear();
         ListBoxReader.Items.Clear();
      }
   }
}
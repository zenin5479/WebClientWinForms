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
         WebRequest request = WebRequest.Create("https://example.com");
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
         string one = "Первая строка:";
         string two = "Вторая строка:";
         string three = "Третья строка:";
         string four = "Четвертая строка:";
         WebRequest ask = WebRequest.Create("https://example.com");
         HttpWebRequest httpask = (HttpWebRequest)ask;
         string lineone = ("Время ожидания запроса (мс) = " + ask.Timeout);
         // Задает значение, указывающее, следует ли выполнять постоянное подключение к интернет-ресурсу
         string linetwo = ("Запрос постоянно поддерживать = " + httpask.KeepAlive);
         // Задает значение, указывающее, должен ли запрос следовать ответам перенаправления
         string linethree = ("Запрос поддерживает перенаправление = " + httpask.AllowAutoRedirect);
         // Вывод значения разных переменных
         string linefour = string.Format("Значения переменных: double - {0:f4}; int - {1}; bool - {2};", 8.1234, 25, false);
         TextBoxReader.AppendText(one);
         TextBoxReader.AppendText(Environment.NewLine);
         TextBoxReader.AppendText(lineone);
         TextBoxReader.AppendText(Environment.NewLine);
         TextBoxReader.AppendText(two);
         TextBoxReader.AppendText(Environment.NewLine);
         TextBoxReader.AppendText(linetwo);
         TextBoxReader.AppendText(Environment.NewLine);
         TextBoxReader.AppendText(three);
         TextBoxReader.AppendText(Environment.NewLine);
         TextBoxReader.AppendText(linethree);
         TextBoxReader.AppendText(Environment.NewLine);
         TextBoxReader.AppendText(four);
         TextBoxReader.AppendText(Environment.NewLine);
         TextBoxReader.AppendText(linefour);
         TextBoxReader.AppendText(Environment.NewLine);
         TextBoxReader.ScrollToCaret();

         ListBoxReader.Items.Add(one);
         ListBoxReader.Items.Add(lineone);
         ListBoxReader.Items.Add(two);
         ListBoxReader.Items.Add(linetwo);
         ListBoxReader.Items.Add(three);
         ListBoxReader.Items.Add(linethree);
         ListBoxReader.Items.Add(four);
         ListBoxReader.Items.Add(linefour);
         // Прокрутка ListBox вниз
         ListBoxReader.TopIndex = ListBoxReader.Items.Count - 1;

         RichTextBoxReader.AppendText(one);
         RichTextBoxReader.AppendText(Environment.NewLine);
         RichTextBoxReader.AppendText(lineone);
         RichTextBoxReader.AppendText(Environment.NewLine);
         RichTextBoxReader.AppendText(two);
         RichTextBoxReader.AppendText(Environment.NewLine);
         RichTextBoxReader.AppendText(linetwo);
         RichTextBoxReader.AppendText(Environment.NewLine);
         RichTextBoxReader.AppendText(three);
         RichTextBoxReader.AppendText(Environment.NewLine);
         RichTextBoxReader.AppendText(linethree);
         RichTextBoxReader.AppendText(Environment.NewLine);
         RichTextBoxReader.AppendText(four);
         RichTextBoxReader.AppendText(Environment.NewLine);
         RichTextBoxReader.AppendText(linefour);
         RichTextBoxReader.AppendText(Environment.NewLine);
         RichTextBoxReader.ScrollToCaret();
      }

      private void ButtonClear_Click(object sender, EventArgs e)
      {
         TextBoxReader.Clear();
         RichTextBoxReader.Clear();
         ListBoxReader.Items.Clear();
      }

      private void FormOne_Load(object sender, EventArgs e)
      {

      }
   }
}
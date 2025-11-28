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

         WebClient client = new WebClient();
         Stream scanner = client.OpenRead("https://api.binance.com/api/v3/time");
         if (scanner != null)
         {
            StreamReader reader = new StreamReader(scanner);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
               ListBoxReader.Items.Add(line);
            }

            scanner.Close();
         }
      }
   }
}
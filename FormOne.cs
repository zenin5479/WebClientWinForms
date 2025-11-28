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
         Stream scanner = client.OpenRead("http://www.reuters.com");
         StreamReader reader = new StreamReader(scanner);
         string line;
         while ((line = reader.ReadLine()) != null)
         {
            listBox1.Items.Add(line);
         }

         scanner.Close();
      }
   }
}
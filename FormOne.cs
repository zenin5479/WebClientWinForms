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

         System.Net.WebClient Client = new WebClient();
         Stream strm = Client.OpenRead("http://www.reuters.com");
         StreamReader sr = new StreamReader(strm);
         string line;
         while ((line = sr.ReadLine()) != null)
         {
            listBox1.Items.Add(line);
         }

         strm.Close();
      }
   }
}
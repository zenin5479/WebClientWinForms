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
         Stream strm = client.OpenRead("http://www.reuters.com");
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
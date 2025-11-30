namespace WebClientWinForms
{
   partial class FormOne
   {
      /// <summary>
      ///  Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      ///  Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      ///  Required method for Designer support - do not modify
      ///  the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         TextBoxReader = new System.Windows.Forms.TextBox();
         ButtonWebClient = new System.Windows.Forms.Button();
         listBox1 = new System.Windows.Forms.ListBox();
         SuspendLayout();
         // 
         // TextBoxReader
         // 
         TextBoxReader.Location = new System.Drawing.Point(12, 41);
         TextBoxReader.Multiline = true;
         TextBoxReader.Name = "TextBoxReader";
         TextBoxReader.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         TextBoxReader.Size = new System.Drawing.Size(384, 311);
         TextBoxReader.TabIndex = 1;
         // 
         // ButtonWebClient
         // 
         ButtonWebClient.Location = new System.Drawing.Point(12, 12);
         ButtonWebClient.Name = "ButtonWebClient";
         ButtonWebClient.Size = new System.Drawing.Size(75, 23);
         ButtonWebClient.TabIndex = 2;
         ButtonWebClient.Text = "WebClient";
         ButtonWebClient.UseVisualStyleBackColor = true;
         ButtonWebClient.Click += ButtonWebClient_Click;
         // 
         // listBox1
         // 
         listBox1.FormattingEnabled = true;
         listBox1.ItemHeight = 15;
         listBox1.Location = new System.Drawing.Point(402, 41);
         listBox1.Name = "listBox1";
         listBox1.Size = new System.Drawing.Size(357, 304);
         listBox1.TabIndex = 3;
         // 
         // FormOne
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(771, 364);
         Controls.Add(listBox1);
         Controls.Add(ButtonWebClient);
         Controls.Add(TextBoxReader);
         Name = "FormOne";
         StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         Text = "Класс WebClient";
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion
      private System.Windows.Forms.TextBox TextBoxReader;
      private System.Windows.Forms.Button ButtonWebClient;
      private System.Windows.Forms.ListBox listBox1;
   }
}

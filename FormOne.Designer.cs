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
         RichTextBoxSavelog = new System.Windows.Forms.RichTextBox();
         ButtonWebRequest = new System.Windows.Forms.Button();
         SuspendLayout();
         // 
         // TextBoxReader
         // 
         TextBoxReader.Location = new System.Drawing.Point(12, 41);
         TextBoxReader.Multiline = true;
         TextBoxReader.Name = "TextBoxReader";
         TextBoxReader.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         TextBoxReader.Size = new System.Drawing.Size(384, 180);
         TextBoxReader.TabIndex = 1;
         // 
         // ButtonWebClient
         // 
         ButtonWebClient.Location = new System.Drawing.Point(12, 12);
         ButtonWebClient.Name = "ButtonWebClient";
         ButtonWebClient.Size = new System.Drawing.Size(90, 23);
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
         listBox1.Size = new System.Drawing.Size(357, 184);
         listBox1.TabIndex = 3;
         // 
         // RichTextBoxSavelog
         // 
         RichTextBoxSavelog.Location = new System.Drawing.Point(12, 227);
         RichTextBoxSavelog.Name = "RichTextBoxSavelog";
         RichTextBoxSavelog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
         RichTextBoxSavelog.Size = new System.Drawing.Size(384, 261);
         RichTextBoxSavelog.TabIndex = 4;
         RichTextBoxSavelog.Text = "";
         // 
         // ButtonWebRequest
         // 
         ButtonWebRequest.Location = new System.Drawing.Point(108, 12);
         ButtonWebRequest.Name = "ButtonWebRequest";
         ButtonWebRequest.Size = new System.Drawing.Size(90, 23);
         ButtonWebRequest.TabIndex = 5;
         ButtonWebRequest.Text = "WebRequest";
         ButtonWebRequest.UseVisualStyleBackColor = true;
         ButtonWebRequest.Click += ButtonWebRequest_Click;
         // 
         // FormOne
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(771, 500);
         Controls.Add(ButtonWebRequest);
         Controls.Add(RichTextBoxSavelog);
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
      private System.Windows.Forms.RichTextBox RichTextBoxSavelog;
      private System.Windows.Forms.Button ButtonWebRequest;
   }
}

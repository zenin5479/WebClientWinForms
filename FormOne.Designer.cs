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
         ListBoxReader = new System.Windows.Forms.ListBox();
         RichTextBoxReader = new System.Windows.Forms.RichTextBox();
         ButtonWebRequest = new System.Windows.Forms.Button();
         ButtonClear = new System.Windows.Forms.Button();
         ButtonHttpWebRequest = new System.Windows.Forms.Button();
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
         // ListBoxReader
         // 
         ListBoxReader.FormattingEnabled = true;
         ListBoxReader.ItemHeight = 15;
         ListBoxReader.Location = new System.Drawing.Point(402, 41);
         ListBoxReader.Name = "ListBoxReader";
         ListBoxReader.ScrollAlwaysVisible = true;
         ListBoxReader.Size = new System.Drawing.Size(357, 184);
         ListBoxReader.TabIndex = 3;
         // 
         // RichTextBoxReader
         // 
         RichTextBoxReader.Location = new System.Drawing.Point(12, 227);
         RichTextBoxReader.Name = "RichTextBoxReader";
         RichTextBoxReader.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
         RichTextBoxReader.Size = new System.Drawing.Size(384, 180);
         RichTextBoxReader.TabIndex = 4;
         RichTextBoxReader.Text = "";
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
         // ButtonClear
         // 
         ButtonClear.Location = new System.Drawing.Point(669, 12);
         ButtonClear.Name = "ButtonClear";
         ButtonClear.Size = new System.Drawing.Size(90, 23);
         ButtonClear.TabIndex = 6;
         ButtonClear.Text = "Clear";
         ButtonClear.UseVisualStyleBackColor = true;
         ButtonClear.Click += ButtonClear_Click;
         // 
         // ButtonHttpWebRequest
         // 
         ButtonHttpWebRequest.Location = new System.Drawing.Point(204, 12);
         ButtonHttpWebRequest.Name = "ButtonHttpWebRequest";
         ButtonHttpWebRequest.Size = new System.Drawing.Size(110, 23);
         ButtonHttpWebRequest.TabIndex = 7;
         ButtonHttpWebRequest.Text = "HttpWebRequest";
         ButtonHttpWebRequest.UseVisualStyleBackColor = true;
         ButtonHttpWebRequest.Click += ButtonHttpWebRequest_Click;
         // 
         // FormOne
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(771, 495);
         Controls.Add(ButtonHttpWebRequest);
         Controls.Add(ButtonClear);
         Controls.Add(ButtonWebRequest);
         Controls.Add(RichTextBoxReader);
         Controls.Add(ListBoxReader);
         Controls.Add(ButtonWebClient);
         Controls.Add(TextBoxReader);
         Name = "FormOne";
         StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         Text = "Класс WebClient";
         Load += FormOne_Load;
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion
      private System.Windows.Forms.TextBox TextBoxReader;
      private System.Windows.Forms.Button ButtonWebClient;
      private System.Windows.Forms.ListBox ListBoxReader;
      private System.Windows.Forms.RichTextBox RichTextBoxReader;
      private System.Windows.Forms.Button ButtonWebRequest;
      private System.Windows.Forms.Button ButtonClear;
      private System.Windows.Forms.Button ButtonHttpWebRequest;
   }
}

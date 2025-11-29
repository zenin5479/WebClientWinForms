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
         button1 = new System.Windows.Forms.Button();
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
         // button1
         // 
         button1.Location = new System.Drawing.Point(12, 12);
         button1.Name = "button1";
         button1.Size = new System.Drawing.Size(75, 23);
         button1.TabIndex = 2;
         button1.Text = "button1";
         button1.UseVisualStyleBackColor = true;
         // 
         // FormOne
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(408, 364);
         Controls.Add(button1);
         Controls.Add(TextBoxReader);
         Name = "FormOne";
         StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         Text = "Класс WebClient";
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion
      private System.Windows.Forms.TextBox TextBoxReader;
      private System.Windows.Forms.Button button1;
   }
}

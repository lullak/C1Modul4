namespace DemoInterfaceStatic
{
    partial class FormFileHandling
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxText = new TextBox();
            buttonWriteTextToFile = new Button();
            SuspendLayout();
            // 
            // textBoxText
            // 
            textBoxText.Location = new Point(217, 90);
            textBoxText.Name = "textBoxText";
            textBoxText.Size = new Size(228, 27);
            textBoxText.TabIndex = 0;
            // 
            // buttonWriteTextToFile
            // 
            buttonWriteTextToFile.Location = new Point(351, 155);
            buttonWriteTextToFile.Name = "buttonWriteTextToFile";
            buttonWriteTextToFile.Size = new Size(94, 29);
            buttonWriteTextToFile.TabIndex = 1;
            buttonWriteTextToFile.Text = "Spara";
            buttonWriteTextToFile.UseVisualStyleBackColor = true;
            buttonWriteTextToFile.Click += buttonWriteTextToFile_Click;
            // 
            // FormFileHandling
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonWriteTextToFile);
            Controls.Add(textBoxText);
            Name = "FormFileHandling";
            Text = "Använd en statisk filehandler";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxText;
        private Button buttonWriteTextToFile;
    }
}
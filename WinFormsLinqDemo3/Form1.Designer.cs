namespace WinFormsLinqDemo3
{
    partial class Form1
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
            comboBoxSelection = new ComboBox();
            textBoxSearchConditions = new TextBox();
            buttonSearch = new Button();
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            listBoxSearchResults = new ListBox();
            SuspendLayout();
            // 
            // comboBoxSelection
            // 
            comboBoxSelection.FormattingEnabled = true;
            comboBoxSelection.Location = new Point(47, 49);
            comboBoxSelection.Name = "comboBoxSelection";
            comboBoxSelection.Size = new Size(151, 28);
            comboBoxSelection.TabIndex = 0;
            // 
            // textBoxSearchConditions
            // 
            textBoxSearchConditions.Location = new Point(246, 51);
            textBoxSearchConditions.Name = "textBoxSearchConditions";
            textBoxSearchConditions.Size = new Size(249, 27);
            textBoxSearchConditions.TabIndex = 1;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(694, 51);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(94, 29);
            buttonSearch.TabIndex = 2;
            buttonSearch.Text = "Sök";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(47, 106);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(250, 27);
            dateTimePickerStart.TabIndex = 3;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(326, 106);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(250, 27);
            dateTimePickerEnd.TabIndex = 4;
            // 
            // listBoxSearchResults
            // 
            listBoxSearchResults.FormattingEnabled = true;
            listBoxSearchResults.Location = new Point(47, 180);
            listBoxSearchResults.Name = "listBoxSearchResults";
            listBoxSearchResults.Size = new Size(618, 224);
            listBoxSearchResults.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxSearchResults);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(dateTimePickerStart);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSearchConditions);
            Controls.Add(comboBoxSelection);
            Name = "Form1";
            Text = "Sök Formulär";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxSelection;
        private TextBox textBoxSearchConditions;
        private Button buttonSearch;
        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private ListBox listBoxSearchResults;
    }
}

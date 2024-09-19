namespace OO1
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
            radioButtonMonkey = new RadioButton();
            radioButtonDog = new RadioButton();
            radioButtonCow = new RadioButton();
            radioButtonCat = new RadioButton();
            listViewAnimals = new ListView();
            label1 = new Label();
            buttonAdd = new Button();
            buttonSound = new Button();
            SuspendLayout();
            // 
            // radioButtonMonkey
            // 
            radioButtonMonkey.AutoSize = true;
            radioButtonMonkey.Location = new Point(99, 82);
            radioButtonMonkey.Name = "radioButtonMonkey";
            radioButtonMonkey.Size = new Size(57, 24);
            radioButtonMonkey.TabIndex = 0;
            radioButtonMonkey.TabStop = true;
            radioButtonMonkey.Text = "Apa";
            radioButtonMonkey.UseVisualStyleBackColor = true;
            // 
            // radioButtonDog
            // 
            radioButtonDog.AutoSize = true;
            radioButtonDog.Location = new Point(99, 112);
            radioButtonDog.Name = "radioButtonDog";
            radioButtonDog.Size = new Size(66, 24);
            radioButtonDog.TabIndex = 1;
            radioButtonDog.TabStop = true;
            radioButtonDog.Text = "Hund";
            radioButtonDog.UseVisualStyleBackColor = true;
            // 
            // radioButtonCow
            // 
            radioButtonCow.AutoSize = true;
            radioButtonCow.Location = new Point(99, 142);
            radioButtonCow.Name = "radioButtonCow";
            radioButtonCow.Size = new Size(48, 24);
            radioButtonCow.TabIndex = 2;
            radioButtonCow.TabStop = true;
            radioButtonCow.Text = "Ko";
            radioButtonCow.UseVisualStyleBackColor = true;
            // 
            // radioButtonCat
            // 
            radioButtonCat.AutoSize = true;
            radioButtonCat.Location = new Point(99, 172);
            radioButtonCat.Name = "radioButtonCat";
            radioButtonCat.Size = new Size(57, 24);
            radioButtonCat.TabIndex = 3;
            radioButtonCat.TabStop = true;
            radioButtonCat.Text = "Katt";
            radioButtonCat.UseVisualStyleBackColor = true;
            // 
            // listViewAnimals
            // 
            listViewAnimals.Location = new Point(346, 71);
            listViewAnimals.Name = "listViewAnimals";
            listViewAnimals.Size = new Size(206, 253);
            listViewAnimals.TabIndex = 4;
            listViewAnimals.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 45);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 5;
            label1.Text = "Lägg till djur";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(98, 226);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Lägg till";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonSound
            // 
            buttonSound.Location = new Point(458, 330);
            buttonSound.Name = "buttonSound";
            buttonSound.Size = new Size(94, 29);
            buttonSound.TabIndex = 7;
            buttonSound.Text = "Visa läten";
            buttonSound.UseVisualStyleBackColor = true;
            buttonSound.Click += buttonSound_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 424);
            Controls.Add(buttonSound);
            Controls.Add(buttonAdd);
            Controls.Add(label1);
            Controls.Add(listViewAnimals);
            Controls.Add(radioButtonCat);
            Controls.Add(radioButtonCow);
            Controls.Add(radioButtonDog);
            Controls.Add(radioButtonMonkey);
            Name = "Form1";
            Text = "Djur Zoo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButtonMonkey;
        private RadioButton radioButtonDog;
        private RadioButton radioButtonCow;
        private RadioButton radioButtonCat;
        private ListView listViewAnimals;
        private Label label1;
        private Button buttonAdd;
        private Button buttonSound;
    }
}

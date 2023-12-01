/* Name: Barbara Friesen
 * ID#: T00721475
 * */

namespace Comp2211_A4_Q13
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
            numberPrompt = new Label();
            numberAmt = new TextBox();
            generateBtn = new Button();
            description = new Label();
            saveFile = new SaveFileDialog();
            SuspendLayout();
            // 
            // numberPrompt
            // 
            numberPrompt.AutoSize = true;
            numberPrompt.Location = new Point(55, 101);
            numberPrompt.Name = "numberPrompt";
            numberPrompt.Size = new Size(317, 20);
            numberPrompt.TabIndex = 0;
            numberPrompt.Text = "Enter number of random numbers to generate:";
            // 
            // numberAmt
            // 
            numberAmt.Location = new Point(378, 98);
            numberAmt.Name = "numberAmt";
            numberAmt.Size = new Size(125, 27);
            numberAmt.TabIndex = 1;
            // 
            // generateBtn
            // 
            generateBtn.Location = new Point(215, 156);
            generateBtn.Name = "generateBtn";
            generateBtn.Size = new Size(157, 41);
            generateBtn.TabIndex = 2;
            generateBtn.Text = "Generate Numbers";
            generateBtn.UseVisualStyleBackColor = true;
            generateBtn.Click += generateBtn_Click;
            // 
            // description
            // 
            description.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            description.Location = new Point(12, 23);
            description.Name = "description";
            description.Size = new Size(581, 48);
            description.TabIndex = 3;
            description.Text = "This program generates a list of random numbers and writes them to a file, with a specified name and location";
            // 
            // saveFile
            // 
            saveFile.FileOk += saveFileDialog1_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 226);
            Controls.Add(description);
            Controls.Add(generateBtn);
            Controls.Add(numberAmt);
            Controls.Add(numberPrompt);
            Name = "Form1";
            Text = "Random Number File Writer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label numberPrompt;
        private TextBox numberAmt;
        private Button generateBtn;
        private Label description;
        private SaveFileDialog saveFile;
    }
}
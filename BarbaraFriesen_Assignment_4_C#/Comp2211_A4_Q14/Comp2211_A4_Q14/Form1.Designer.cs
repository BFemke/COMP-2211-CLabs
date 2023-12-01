/* Name: Barbara Friesen
 * ID#: T00721475
 * */

namespace Comp2211_A4_Q14
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
            description = new Label();
            listBox = new ListBox();
            countLabel = new Label();
            totalLabel = new Label();
            countText = new Label();
            totalText = new Label();
            getFileBtn = new Button();
            openFile = new OpenFileDialog();
            SuspendLayout();
            // 
            // description
            // 
            description.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            description.Location = new Point(12, 18);
            description.Name = "description";
            description.Size = new Size(776, 79);
            description.TabIndex = 0;
            description.Text = "This program allows you to open the previously made file of numbers and disply them in a list view. This program will also the total count of numbers and the total sum of the numbers.";
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 20;
            listBox.Location = new Point(30, 99);
            listBox.Name = "listBox";
            listBox.Size = new Size(401, 184);
            listBox.TabIndex = 1;
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Location = new Point(460, 147);
            countLabel.Name = "countLabel";
            countLabel.Size = new Size(144, 20);
            countLabel.TabIndex = 2;
            countLabel.Text = "Total numbers read: ";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new Point(460, 207);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(120, 20);
            totalLabel.TabIndex = 3;
            totalLabel.Text = "Sum of numbers:";
            // 
            // countText
            // 
            countText.BackColor = SystemColors.HighlightText;
            countText.BorderStyle = BorderStyle.FixedSingle;
            countText.Location = new Point(621, 141);
            countText.Name = "countText";
            countText.Size = new Size(154, 32);
            countText.TabIndex = 4;
            countText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // totalText
            // 
            totalText.BackColor = SystemColors.HighlightText;
            totalText.BorderStyle = BorderStyle.FixedSingle;
            totalText.Location = new Point(621, 206);
            totalText.Name = "totalText";
            totalText.Size = new Size(154, 32);
            totalText.TabIndex = 5;
            totalText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // getFileBtn
            // 
            getFileBtn.Location = new Point(355, 318);
            getFileBtn.Name = "getFileBtn";
            getFileBtn.Size = new Size(107, 38);
            getFileBtn.TabIndex = 6;
            getFileBtn.Text = "Get File";
            getFileBtn.UseVisualStyleBackColor = true;
            getFileBtn.Click += getFileBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 392);
            Controls.Add(getFileBtn);
            Controls.Add(totalText);
            Controls.Add(countText);
            Controls.Add(totalLabel);
            Controls.Add(countLabel);
            Controls.Add(listBox);
            Controls.Add(description);
            Name = "Form1";
            Text = "Random Number File Reader";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label description;
        private ListBox listBox;
        private Label countLabel;
        private Label totalLabel;
        private Label countText;
        private Label totalText;
        private Button getFileBtn;
        private OpenFileDialog openFile;
    }
}
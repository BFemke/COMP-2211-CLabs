﻿namespace Comp2211_A5
{
    partial class CustInformation
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            nameLabel = new TextBox();
            addressLabel = new TextBox();
            phoneLabel = new TextBox();
            amountLabel = new TextBox();
            checkBox = new CheckBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            newAmount = new TextBox();
            button1 = new Button();
            IdLabel = new Label();
            discountLabel = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 112);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 0;
            label1.Text = "Customer Name: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 185);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 1;
            label2.Text = "Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 227);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Phone #: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 267);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 3;
            label4.Text = "Amount Spent:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 310);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 4;
            label5.Text = "Discount:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 148);
            label6.Name = "label6";
            label6.Size = new Size(27, 20);
            label6.TabIndex = 5;
            label6.Text = "ID:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(47, 355);
            label7.Name = "label7";
            label7.Size = new Size(115, 20);
            label7.TabIndex = 6;
            label7.Text = "On Mailing List: ";
            // 
            // nameLabel
            // 
            nameLabel.Location = new Point(205, 109);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(176, 27);
            nameLabel.TabIndex = 7;
            nameLabel.TextChanged += nameLabel_TextChanged;
            // 
            // addressLabel
            // 
            addressLabel.Location = new Point(205, 182);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(176, 27);
            addressLabel.TabIndex = 9;
            addressLabel.TextChanged += addressLabel_TextChanged;
            // 
            // phoneLabel
            // 
            phoneLabel.Location = new Point(205, 224);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(176, 27);
            phoneLabel.TabIndex = 10;
            phoneLabel.TextChanged += phoneLabel_TextChanged;
            // 
            // amountLabel
            // 
            amountLabel.Location = new Point(205, 264);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(176, 27);
            amountLabel.TabIndex = 11;
            amountLabel.TextChanged += amountLabel_TextChanged;
            // 
            // checkBox
            // 
            checkBox.AutoSize = true;
            checkBox.Location = new Point(205, 354);
            checkBox.Name = "checkBox";
            checkBox.Size = new Size(52, 24);
            checkBox.TabIndex = 13;
            checkBox.Text = "Yes";
            checkBox.UseVisualStyleBackColor = true;
            checkBox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(462, 41);
            label8.Name = "label8";
            label8.Size = new Size(151, 28);
            label8.TabIndex = 14;
            label8.Text = "New Purchase:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(47, 41);
            label9.Name = "label9";
            label9.Size = new Size(151, 28);
            label9.TabIndex = 15;
            label9.Text = "Customer Info:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(462, 109);
            label10.Name = "label10";
            label10.Size = new Size(127, 20);
            label10.TabIndex = 16;
            label10.Text = "Purchase Amount:";
            // 
            // newAmount
            // 
            newAmount.Location = new Point(618, 105);
            newAmount.Name = "newAmount";
            newAmount.Size = new Size(125, 27);
            newAmount.TabIndex = 17;
            // 
            // button1
            // 
            button1.Location = new Point(523, 173);
            button1.Name = "button1";
            button1.Size = new Size(144, 44);
            button1.TabIndex = 18;
            button1.Text = "Submit Purchase";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // IdLabel
            // 
            IdLabel.BackColor = SystemColors.ControlLightLight;
            IdLabel.Location = new Point(205, 148);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(176, 25);
            IdLabel.TabIndex = 19;
            // 
            // discountLabel
            // 
            discountLabel.BackColor = SystemColors.ControlLightLight;
            discountLabel.Location = new Point(205, 310);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new Size(176, 25);
            discountLabel.TabIndex = 20;
            // 
            // button2
            // 
            button2.Location = new Point(544, 248);
            button2.Name = "button2";
            button2.Size = new Size(100, 39);
            button2.TabIndex = 21;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // CustInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(discountLabel);
            Controls.Add(IdLabel);
            Controls.Add(button1);
            Controls.Add(newAmount);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(checkBox);
            Controls.Add(amountLabel);
            Controls.Add(phoneLabel);
            Controls.Add(addressLabel);
            Controls.Add(nameLabel);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CustInformation";
            Text = "Customer Information";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox nameLabel;
        private TextBox addressLabel;
        private TextBox phoneLabel;
        private TextBox amountLabel;
        private CheckBox checkBox;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox newAmount;
        private Button button1;
        private Label IdLabel;
        private Label discountLabel;
        private Button button2;
    }
}
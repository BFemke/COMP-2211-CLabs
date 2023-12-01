namespace Comp2211_A5
{
    partial class newCustomerForm
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
            submitBtn = new Button();
            cancelBtn = new Button();
            nameLabel = new Label();
            addressLabel = new Label();
            phnLabel = new Label();
            mailingLabel = new Label();
            checkBox = new CheckBox();
            phnNum = new TextBox();
            address = new TextBox();
            custName = new TextBox();
            SuspendLayout();
            // 
            // submitBtn
            // 
            submitBtn.Location = new Point(192, 262);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(94, 29);
            submitBtn.TabIndex = 0;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += submitBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(404, 262);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(94, 29);
            cancelBtn.TabIndex = 1;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(124, 41);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(123, 20);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Customer Name: ";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(124, 80);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(69, 20);
            addressLabel.TabIndex = 3;
            addressLabel.Text = "Address: ";
            // 
            // phnLabel
            // 
            phnLabel.AutoSize = true;
            phnLabel.Location = new Point(124, 118);
            phnLabel.Name = "phnLabel";
            phnLabel.Size = new Size(70, 20);
            phnLabel.TabIndex = 4;
            phnLabel.Text = "Phone #: ";
            // 
            // mailingLabel
            // 
            mailingLabel.AutoSize = true;
            mailingLabel.Location = new Point(124, 178);
            mailingLabel.Name = "mailingLabel";
            mailingLabel.Size = new Size(178, 20);
            mailingLabel.TabIndex = 5;
            mailingLabel.Text = "Subscribe to Mailing List?";
            // 
            // checkBox
            // 
            checkBox.AutoSize = true;
            checkBox.Location = new Point(504, 174);
            checkBox.Name = "checkBox";
            checkBox.Size = new Size(52, 24);
            checkBox.TabIndex = 6;
            checkBox.Text = "Yes";
            checkBox.UseVisualStyleBackColor = true;
            // 
            // phnNum
            // 
            phnNum.Location = new Point(363, 118);
            phnNum.Name = "phnNum";
            phnNum.Size = new Size(193, 27);
            phnNum.TabIndex = 7;
            // 
            // address
            // 
            address.Location = new Point(363, 80);
            address.Name = "address";
            address.Size = new Size(193, 27);
            address.TabIndex = 8;
            // 
            // custName
            // 
            custName.Location = new Point(363, 41);
            custName.Name = "custName";
            custName.Size = new Size(193, 27);
            custName.TabIndex = 9;
            // 
            // newCustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 324);
            Controls.Add(custName);
            Controls.Add(address);
            Controls.Add(phnNum);
            Controls.Add(checkBox);
            Controls.Add(mailingLabel);
            Controls.Add(phnLabel);
            Controls.Add(addressLabel);
            Controls.Add(nameLabel);
            Controls.Add(cancelBtn);
            Controls.Add(submitBtn);
            Name = "newCustomerForm";
            Text = "Add a New Customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button submitBtn;
        private Button cancelBtn;
        private Label nameLabel;
        private Label addressLabel;
        private Label phnLabel;
        private Label mailingLabel;
        private CheckBox checkBox;
        private TextBox phnNum;
        private TextBox address;
        private TextBox custName;
    }
}
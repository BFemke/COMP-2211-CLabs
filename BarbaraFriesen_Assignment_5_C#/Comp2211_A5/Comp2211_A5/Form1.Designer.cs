namespace Comp2211_A5
{
    partial class homeForm
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
            listLabel = new Label();
            custList = new ListBox();
            IDLabel = new Label();
            nameLabel = new Label();
            amountLabel = new Label();
            discountLabel = new Label();
            newCustomerBtn = new Button();
            description = new Label();
            SuspendLayout();
            // 
            // listLabel
            // 
            listLabel.AutoSize = true;
            listLabel.Location = new Point(21, 20);
            listLabel.Name = "listLabel";
            listLabel.Size = new Size(122, 20);
            listLabel.TabIndex = 0;
            listLabel.Text = "List of Customers";
            // 
            // custList
            // 
            custList.FormattingEnabled = true;
            custList.ItemHeight = 20;
            custList.Location = new Point(21, 70);
            custList.Name = "custList";
            custList.Size = new Size(561, 184);
            custList.TabIndex = 1;
            custList.SelectedIndexChanged += custList_SelectedIndexChanged;
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Location = new Point(21, 47);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(24, 20);
            IDLabel.TabIndex = 2;
            IDLabel.Text = "ID";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(163, 47);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(49, 20);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new Point(329, 47);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(84, 20);
            amountLabel.TabIndex = 4;
            amountLabel.Text = "Total Spent";
            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.Location = new Point(474, 47);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new Size(67, 20);
            discountLabel.TabIndex = 5;
            discountLabel.Text = "Discount";
            // 
            // newCustomerBtn
            // 
            newCustomerBtn.Location = new Point(214, 318);
            newCustomerBtn.Name = "newCustomerBtn";
            newCustomerBtn.Size = new Size(199, 46);
            newCustomerBtn.TabIndex = 6;
            newCustomerBtn.Text = "Add New Customer";
            newCustomerBtn.UseVisualStyleBackColor = true;
            newCustomerBtn.Click += button1_Click;
            // 
            // description
            // 
            description.AutoSize = true;
            description.Location = new Point(21, 271);
            description.Name = "description";
            description.Size = new Size(466, 20);
            description.TabIndex = 7;
            description.Text = "Select a customer to see more information or to add a new purchase.";
            // 
            // homeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 450);
            Controls.Add(description);
            Controls.Add(newCustomerBtn);
            Controls.Add(discountLabel);
            Controls.Add(amountLabel);
            Controls.Add(nameLabel);
            Controls.Add(IDLabel);
            Controls.Add(custList);
            Controls.Add(listLabel);
            Name = "homeForm";
            Text = "Preferred Customer Index";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label listLabel;
        private ListBox custList;
        private Label IDLabel;
        private Label nameLabel;
        private Label amountLabel;
        private Label discountLabel;
        private Button newCustomerBtn;
        private Label description;
    }
}
/*  Name: Barbara Friesen
 *  Id: T00721475
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp2211_A5
{
    public partial class CustInformation : Form
    {

        private int index;
        public CustInformation(int index)
        {
            this.index = index;     //sets index value
            InitializeComponent();
            populateTextBoxes();
        }

        /*  Purpose: Sets the current values for the particular customer in the editable fields in the form
         */
        private void populateTextBoxes()
        {
            nameLabel.Text = Globals.customers[index].name;
            addressLabel.Text = Globals.customers[index].address;
            phoneLabel.Text = Globals.customers[index].phnNum;
            IdLabel.Text = Globals.customers[index].customerNum.ToString();     //Cannot be edited
            amountLabel.Text = Globals.customers[index].amountSpent.ToString();
            discountLabel.Text = Globals.customers[index].discount.ToString("p");   //Cannot be edited
            checkBox.Checked = Globals.customers[index].onMailingList;
        }

        /*  Purpose: Listens for changes made to the mailing list check box and sets the customers attribute accordingly
         */
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Sets new value to boolean on maling list field
            Globals.customers[index].onMailingList = checkBox.Checked;

        }

        /*  Purpose: Listens for changes made to the address text box and sets the customers attribute accordingly
         */
        private void addressLabel_TextChanged(object sender, EventArgs e)
        {
            //Sets new customer address in customer object
            Globals.customers[index].address = addressLabel.Text;
        }

        /*  Purpose: Listens for changes made to the name text box and sets the customers attribute accordingly
         */
        private void nameLabel_TextChanged(object sender, EventArgs e)
        {
            //Sets new customer name in customer object
            Globals.customers[index].name = nameLabel.Text;
        }

        /*  Purpose: Listens for changes made to the phone number text box and sets the customers attribute accordingly
         */
        private void phoneLabel_TextChanged(object sender, EventArgs e)
        {
            //Sets new customer phone number in customer object
            Globals.customers[index].phnNum = phoneLabel.Text;
        }

        /*  Purpose: Listens for changes made to the amount spent text box and sets the customers attribute accordingly, also 
         *          calls method to update discount in case new discounts apply
         */
        private void amountLabel_TextChanged(object sender, EventArgs e)
        {
            //Try block to prevent wrong data type exceptions
            try
            {
                //Ensures no negative value is input
                if(double.Parse(amountLabel.Text) >= 0)
                {
                    //Parses new amount spent into a double number
                    Globals.customers[index].amountSpent = double.Parse(amountLabel.Text);
                }
                else
                {
                    //Alerts users that negative totals are not allowed
                    MessageBox.Show("You cannot have a negative total amount spent..");
                }

                Globals.customers[index].setDiscount(); //Calls set discount

                discountLabel.Text = Globals.customers[index].discount.ToString();  //Updates new discount on form
            }
            catch (Exception ex)
            {
                //Alerts user that incorrect input was given
                MessageBox.Show("Invalid change for amount spent..");

                //resets amount spent to orginal value
                amountLabel.Text = Globals.customers[index].amountSpent.ToString();
            }
        }
        /*  Purpose: Listens for button "Add Purchase" to be pressed and will add the amount specified to the total amount spent 
         *          and update the discount if needed
         */
        private void button1_Click(object sender, EventArgs e)
        {
            //Try block to prevent wrong data type exceptions
            try
            {
                //Parses new amount purchased into a double number
                double purchaseAmount = double.Parse(newAmount.Text);

                Globals.customers[index].purchase(purchaseAmount);  //Calls method to add purchase amount

                amountLabel.Text = Globals.customers[index].amountSpent.ToString(); //updates total amount spent on form
                discountLabel.Text = Globals.customers[index].discount.ToString("p");   //updates discoutn on form
            }
            catch (Exception ex)
            {
                //Alerts user of invalid input
                MessageBox.Show("Purchase amount must be a number..");
            }
        }

        //Listens for "Back" button click which closes the form
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();   //Closes form
        }
    }
}

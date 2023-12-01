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
    public partial class newCustomerForm : Form
    {
        public newCustomerForm()
        {
            InitializeComponent();
        }

        /*  Purpose: Listens for the clicking of the "Cancel" button and closes form with no changes being made to the 
         *          customer list
         */
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();   //closes form
        }

        /*  Purpose: Listns for "Submit" button to be clicked and creates new preferred customer object and adds it to the 
         *          global list
         */
        private void submitBtn_Click(object sender, EventArgs e)
        {
            string cName, cAddress, cPhn;

            //Checks of any of the text fields are left blank and dsplays error message if they are
            if (custName.Text == "" || address.Text == "" || phnNum.Text == "")
            {
                MessageBox.Show("You can not leave a field  blank..");
                return;
            }

            //If none are blank then their text gets extracted into the following variables
            cName = custName.Text;
            cAddress = address.Text;
            cPhn = phnNum.Text;

            bool cMail = checkBox.Checked;  //grabs status of checkbox

            //creates new preferredCustomer object with the information gathered from the form
            PreferredCustomer c = new PreferredCustomer(cName, cAddress, cPhn, cMail);

            Globals.customers.Add(c); //Adds new preferred customer to global customer list
            this.Close();   //closes form
        }

    }
}

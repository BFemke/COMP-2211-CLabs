/*  Name: Barbara Friesen
 *  Id: T00721475
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp2211_A5
{
    internal class PreferredCustomer : Customer
    {
        public double amountSpent { get; set; } = 0;
        public double discount { get; set; } = 0;

        /*  Contstructor: Calls base class constructor to populate the name, address, phone number, id, and mailing 
         *          list variables
         */
        public PreferredCustomer(string name, string address, string phn, bool mail) 
            : base(name, address, phn, mail) { }

        public void setDiscount()
        {
            //Sets discount to 10% if they have spent more than $2000
            if(amountSpent >= 2000)
            {
                discount = 0.1;
            }
            //Sets discount to 7% if they have spent more than $1500
            else if (amountSpent >= 1500){
                discount = 0.07;
            }
            //Sets discount to 6% if they have spent more than $1000
            else if (amountSpent >= 1000)
            {
                discount = 0.06;
            }
            //Sets discount to 5% if they have spent more than $500
            else if (amountSpent >= 500)
            {
                discount = 0.05;
            }
            //Sets discount to 0 if they have spent under $500
            else
            {
                discount = 0;
            }
        }

        /*  Purpose: Adds new purchase amount to total amount spent by customer
         *  Input: amount purchased (double)
         *  Output: none
         */ 
        public void purchase(double amount)
        {
            double temp = amountSpent;
            temp += amount;  //updates new total spent in temp

            //Checks if the amount is valid
            if(temp >= 0)
            {
                amountSpent = temp;     //updates total amount spent
            }
            else
            {
                //Alerts user that the purchase amount resulted in an invalid total amount
                MessageBox.Show("You cannot end up with a negative total amount spent..");
            }
            setDiscount();      //Sets discount if applicable
        }

        /*  Purpose: Overrides the ToString() method so that it can be used to print out the preferred customer object with
         *          the desired information which adds the amount spent and discount to the customer object string
         *  Inputs: None
         *  Outputs: string representation of preferred customer object
         */
        public override string ToString()
        {
            //Calls the overloaded ToString() method in the base class and adds it to its information to be printed and returns a string
            return base.ToString() + "\t\t"+amountSpent.ToString("c")+"\t\t"+discount.ToString("p");
        }
    }
}

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
    internal class Customer : Person    //Customer is a Person
    {
        //Declares member variables and provide auto get and set
        public int customerNum { get; set;}
        public bool onMailingList { get; set; }

        /*  Contstructor: Calls base class constructor to populate the name, address, and phone number variables
         *  and then sets the ID for the customer using our global variable to make sure each one is unique
         */
        public Customer(string name, string address, string phn, bool mail) 
        : base(name, address, phn)
        { 
            this.customerNum = Globals.nextID;  //Sets next available id
            this.onMailingList = mail;

            Globals.nextID++;   //increments to next id
        }

        /*  Purpose: Overrides the ToString() method so that it can be used to print out the customer object with
         *          the desired information
         *  Inputs: None
         *  Outputs: string representation of customer object
         */
        public override string ToString()
        {
            //Calls the overloaded ToString() method in the base class and adds it to its information to be printed and returns a string
            return customerNum + "\t\t" + base.ToString();
        }
    }
}

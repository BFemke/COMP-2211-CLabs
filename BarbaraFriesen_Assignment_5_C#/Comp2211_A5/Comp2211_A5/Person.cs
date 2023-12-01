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
    internal class Person
    {
        //Declares member variables and provide auto get and set
        public string name { get; set; }
        public string address { get; set; }
        public string phnNum { get; set; }

        /*  Contstructor: Sets the name, phone number, and address of the Person
         */
        public Person(string name, string address, string phnNum)
        {
            this.name = name;
            this.address = address;
            this.phnNum = phnNum;
        }

        /*  Purpose: Overrides the ToString() method so that it can be used to print out the Person object and print its name
         *  Inputs: None
         *  Outputs: string representation of Person object
         */
        public override string ToString()
        {
            return name;
        }
    }
}

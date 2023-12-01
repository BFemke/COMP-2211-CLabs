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
    internal class Globals
    {
        public static int nextID { get; set; } = 1001;
        public static List<PreferredCustomer> customers = new List<PreferredCustomer>();

        /*  Purpose: Initilaizes global customer list with sample customers and their information.
         */
        public static void initializeCustomers()
        {
            //Creates new preferred customers
            PreferredCustomer a = new PreferredCustomer("John Jenkins", "1234 5th Rd", "888-888-8888", false);
            PreferredCustomer b = new PreferredCustomer("Peggy Carter", "457 8th Ave", "111-111-1111", true);
            PreferredCustomer c = new PreferredCustomer("Betty Smith", "156 7th St", "355-684-8587", false);
            PreferredCustomer d = new PreferredCustomer("George Ruth", "15678 9th Ave", "658-547-6715", true);
            PreferredCustomer e = new PreferredCustomer("Patty Tinks", "458 1st Ave", "544-254-5424", false);

            //Adds customers to the customer list
            customers.Add(a);
            customers.Add(b);
            customers.Add(c);
            customers.Add(d);
            customers.Add(e);

            //sets purchases for some of the customers
            customers[1].purchase(1302.5);
            customers[2].purchase(500);
            customers[3].purchase(1675.09);
            customers[4].purchase(3020.86);
        }
    }
}

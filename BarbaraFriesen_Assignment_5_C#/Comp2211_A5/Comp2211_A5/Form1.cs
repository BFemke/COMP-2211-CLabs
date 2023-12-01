/*  Name: Barbara Friesen
 *  Id: T00721475
 */

namespace Comp2211_A5
{
    public partial class homeForm : Form
    {
        public homeForm()
        {
            InitializeComponent();
            Globals.initializeCustomers();  //Initializes the sample customers in our global list of customers
            initializeCustomers();          
        }
        /*  Purpose: Populate the list box in the form with the global list of customers
         *  Input: None
         *  Output: None
         */
        private void initializeCustomers()
        {
            custList.Items.Clear(); //Clear previous items in the list box
           
            //Loops through every customer in the global list of customers
            for(int i = 0; i < Globals.customers.Count; i++)
            {
                //Adds each customer to the list box on the form
                custList.Items.Add(Globals.customers[i]);
            }

        }

        /*  Purpose: Listens for "Add new Customer" button click and opens new dialog to add new customer
         */
        private void button1_Click(object sender, EventArgs e)
        {
            //creates new instance of then add customer form
            newCustomerForm form = new newCustomerForm();

            form.ShowDialog();  //Displays form

            initializeCustomers();  //Re-intilializes customer list with new customer
        }

        /*  Purpose: Listen for a customer from the list box to be selected and opens a new form with that customer's
         *          information, and allows new transactions
         */
        private void custList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = custList.SelectedIndex;     //Gets index of customer selected

            //Checks if a valid selcection was made
            if (index != -1)
            {
                //creates new instance of the customer information form and passed the index of the customer selected
                CustInformation infoFrom = new CustInformation(index);

                infoFrom.ShowDialog();  //displays form

                initializeCustomers();  //Re-intilializes customer list with new changes added
            }
        }
    }
}
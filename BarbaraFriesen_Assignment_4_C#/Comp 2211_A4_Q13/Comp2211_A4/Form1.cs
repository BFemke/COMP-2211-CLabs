/* Name: Barbara Friesen
 * ID#: T00721475
 * */

using System.Diagnostics.Eventing.Reader;

namespace Comp2211_A4_Q13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        /*  
         *  Purpose: generates specified number of random numbers and writes them to a file
         */
        private void generateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //parses number of random nubers to generate into an integer
                int numRandom = int.Parse(numberAmt.Text);

                //Creates new streamwriter Object
                StreamWriter output;

                //Creates new random number object reference
                Random rand = new Random();

                //Opens a save file dialog to allow user to set a location and name for the file 
                //Executes if save is selected
                if(saveFile.ShowDialog() == DialogResult.OK)
                {
                    //Sets file writer output to the selected file name
                    output = new StreamWriter(saveFile.FileName);

                    //Loops the number of times entered by the user
                    for(int i = 0; i < numRandom; i++)
                    {
                        //Writes a new line containing a random number
                        output.WriteLine(rand.Next(100) + 1);
                    }
                    
                    //closes file writer
                    output.Close();

                    //Alerts user of success in making file
                    MessageBox.Show("File ctreated successfully!");
                }
                //Executes if cancel is selected
                else
                {
                    //Alerts user that no file was made
                    MessageBox.Show("File not created.");
                }
            }
            //Catches any exceptions
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
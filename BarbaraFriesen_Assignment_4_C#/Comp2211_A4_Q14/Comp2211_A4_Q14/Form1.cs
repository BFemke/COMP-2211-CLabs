/* Name: Barbara Friesen
 * ID#: T00721475
 * */

namespace Comp2211_A4_Q14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getFileBtn_Click(object sender, EventArgs e)
        {
            //creates new streamreader object
            StreamReader input;

            int ranNum, count = 0, total = 0;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                //clears previous list box and text results
                listBox.Items.Clear();
                countText.Text = "";
                totalText.Text = "";

                //opens chosen file
                input = File.OpenText(openFile.FileName);

                //Loops until the end of the file is reached
                while (!input.EndOfStream)
                {
                    try
                    {
                        //reads next random number in the file
                        ranNum = int.Parse(input.ReadLine());

                        listBox.Items.Add(ranNum);  //Adds number to list box
                        count++;                    //increments count of numbers in the file
                        total += ranNum;            //adds number to running total of numbers in the file

                    }
                    //Catches potential excetpions
                    catch (Exception ex)
                    {
                        //Alerts user that unexpected data is in file
                        MessageBox.Show(ex.Message + ". Try a different File..");
                        return;
                    }
                }

                countText.Text = count.ToString();  //Sets count of numbers in the file
                totalText.Text = total.ToString();  //Sets sum of numbers in the file
            }
            else
            {
                //Alerts user that no file was selected
                MessageBox.Show("No file selected.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
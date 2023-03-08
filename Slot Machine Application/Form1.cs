using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slot_Machine_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //display the total amount of money entered into the slot machine and the total amount won.
            MessageBox.Show("Total Output: $" + totalOutput + "\n" + "Total Input: $" + totalInput);
            //set input and output back to zero
           totalInput = 0;
           totalOutput = 0;


            this.Close();
        }

        Random rand = new Random();
        //global variables 
        int totalOutput = 0; 
        int output = 0;
        int totalInput = 0;

        private void spinButton_Click(object sender, EventArgs e)
        {
           
            try
            {
                //get the amount inserted from the textbox
                int input = int.Parse(moneyInsertedTextBox.Text);
                
                totalInput += input;
                

                //generate random number 0-10
                int n = rand.Next(0, 10);
                int o = rand.Next(0, 10);
                int p = rand.Next(0, 10);

                //use the random number to display picture boxes 
                picBox1.Image = imageList1.Images[n];
                picBox2.Image = imageList1.Images[o];
                picBox3.Image = imageList1.Images[p];

                //compare n,o & p to see if a match occured
                if(n == o && o == p && n == p) //make sure all three images match
                {
                    output = input * 3;
                    MessageBox.Show("You win 3X amount entered: \n" + output.ToString("c"));
                    totalOutput += output;
                    


                }
                else if(n == o || o == p || n == p) // making sure that two images match
                {
                    output = input * 2;
                    MessageBox.Show("You win 2X amount entered: \n" + output.ToString("c"));
                    totalOutput += output;
                }
               else  //none match
                {
                    output = 0;
                    MessageBox.Show("You lose. Try again! \n" + output.ToString("c"));
                    totalOutput += output;
                }
                //MessageBox.Show("You win: \n" + output.ToString("c"));

                //code to check if my total input and output are coreect 
                //MessageBox.Show(totalOutput.ToString("c"));
                //MessageBox.Show(totalInput.ToString("c"));


            }
            catch (Exception)
            {
                MessageBox.Show("Enter a valid input");
            }

          
           
            //below is if i want to see if the input is being recorded correctly 
            //MessageBox.Show(input.ToString());

            //keep running total of input and output amounts 
            
        }
    }
}

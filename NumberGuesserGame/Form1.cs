using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGuesserGame
{
    public partial class NumberGuesser : Form
    {
        public NumberGuesser()
        {
            InitializeComponent();
        }

        Random random = new Random();
        int correctNumber;
        int guessedNumber;

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateRandomNumber();
        }
                
        
       
        private void btnCheck_Click(object sender, EventArgs e)
        {           
            CheckGuess();
        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        //Method to Generate Random Number
        private void GenerateRandomNumber()
        {
            correctNumber = random.Next(1, 10);
            inputBox.Clear();
        }

        //Method to Check User Input
        private void CheckGuess()
        {
            if (inputBox.Text != "")
            {
                try
                {
                    guessedNumber = int.Parse(inputBox.Text);
                }

                catch
                {
                    MessageBox.Show("Please enter an integer between 1 and 10!", "Wrong Guess");
                }



                if (guessedNumber >= 1 && guessedNumber <= 10)
                {
                    if (guessedNumber == correctNumber)
                    {
                        DialogResult result;
                        MessageBox.Show("Yippee!!! Your Guess was correct", "Congratulations");
                        result = MessageBox.Show("Would You Like To Play Again?", "Replay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            GenerateRandomNumber();
                        }
                        else
                        {
                            Application.Exit();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Ooops...Wrong Guess, Try again","Wrong");
                        inputBox.Clear();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Please enter a number between 1 and 10!", "Out of Range");
                }


            }
            else
            {
                MessageBox.Show("Enter a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

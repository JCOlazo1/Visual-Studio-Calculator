using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        public int firstValue; // First value in the calculator.
        public int nextValue; // The next value after the firstValue. (Can be overwritten).
        public bool operandPressed = false;

        public bool plusPressed = false;
        public bool minusPressed = false;
        public bool multiplyPressed = false;
        public bool dividePressed = false;

        public bool newEquation = false;

        public int opCounter = 0;
        public int opTrigger = 0; // 1(+), 2(-), 3(*), 4( / )

        /*** NUMBER BUTTONS ***/
        private void button1_Click(object sender, EventArgs e)
        {   
            if (newEquation == true)
            {
                calculationTextBox.Text = "";
                newEquation = false;
            }

            if (operandPressed == true)
            {
                calculationTextBox.Text = "";
                calculationTextBox.Text = calculationTextBox.Text + "1";
                // set operandPressed back to FALSE because you don't want to continually clear after pressing an operand.
                operandPressed = false;
            }
            else
            {
                calculationTextBox.Text = calculationTextBox.Text + "1";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (newEquation == true)
            {
                calculationTextBox.Text = "";
                newEquation = false;
            }

            if (operandPressed == true)
            {
                calculationTextBox.Text = "";
                calculationTextBox.Text = calculationTextBox.Text + "2";
                operandPressed = false;
            }
            else
            {
                calculationTextBox.Text = calculationTextBox.Text + "2";
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (newEquation == true)
            {
                calculationTextBox.Text = "";
                newEquation = false;
            }

            if (operandPressed == true)
            {
                calculationTextBox.Text = "";
                calculationTextBox.Text = calculationTextBox.Text + "3";
                operandPressed = false;
            }
            else
            {
                calculationTextBox.Text = calculationTextBox.Text + "3";
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (newEquation == true)
            {
                calculationTextBox.Text = "";
                newEquation = false;
            }

            if (operandPressed == true)
            {
                calculationTextBox.Text = "";
                calculationTextBox.Text = calculationTextBox.Text + "4";
                operandPressed = false;
            }
            else
            {
                calculationTextBox.Text = calculationTextBox.Text + "4";
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (newEquation == true)
            {
                calculationTextBox.Text = "";
                newEquation = false;
            }

            if (operandPressed == true)
            {
                calculationTextBox.Text = "";
                calculationTextBox.Text = calculationTextBox.Text + "5";
                operandPressed = false;
            }
            else
            {
                calculationTextBox.Text = calculationTextBox.Text + "5";
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (newEquation == true)
            {
                calculationTextBox.Text = "";
                newEquation = false;
            }

            if (operandPressed == true)
            {
                calculationTextBox.Text = "";
                calculationTextBox.Text = calculationTextBox.Text + "6";
                operandPressed = false;
            }
            else
            {
                calculationTextBox.Text = calculationTextBox.Text + "6";
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (newEquation == true)
            {
                calculationTextBox.Text = "";
                newEquation = false;
            } 

            if (operandPressed == true)
            {
                calculationTextBox.Text = "";
                calculationTextBox.Text = calculationTextBox.Text + "7";
                operandPressed = false;
            }
            else
            {
                calculationTextBox.Text = calculationTextBox.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (newEquation == true)
            {
                calculationTextBox.Text = "";
                newEquation = false;
            }

            if (operandPressed == true)
            {
                calculationTextBox.Text = "";
                calculationTextBox.Text = calculationTextBox.Text + "8";
                operandPressed = false;
            }
            else
            {
                calculationTextBox.Text = calculationTextBox.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (newEquation == true)
            {
                calculationTextBox.Text = "";
                newEquation = false;
            }

            if (operandPressed == true)
            {
                calculationTextBox.Text = "";
                calculationTextBox.Text = calculationTextBox.Text + "9";
                operandPressed = false;
            }
            else
            {
                calculationTextBox.Text = calculationTextBox.Text + "9";
            }
        }
        private void button0_Click(object sender, EventArgs e)
        {
            if (newEquation == true)
            {
                calculationTextBox.Text = "";
                newEquation = false;
            }

            if (operandPressed == true)
            {
                calculationTextBox.Text = "";
                calculationTextBox.Text = calculationTextBox.Text + "0";
                operandPressed = false;
            }
            else
            {
                calculationTextBox.Text = calculationTextBox.Text + "0";
            }
        }
        /*** OPERAND METHODS ***/
        private void plusButton_Click(object sender, EventArgs e)
        {
            // This allows for "stacking" arithmetic.
            opCounter++;
            if (opCounter >= 2)
            {
                nextValue = int.Parse(calculationTextBox.Text);
                int sum = firstValue + nextValue;
                nextValue = sum;
                calculationTextBox.Text = sum.ToString();
            }
            // This 'if' ensures that the operand doesn't freak out if nothing is inside.
            if (calculationTextBox.Text == "") 
            { calculationTextBox.Text = ""; }

            else
            {
                // Each operand button should have a if/else for other operands.
                // firstValue stores the value in the calculationTextBox, then clear the TextBox for nextValue.
                firstValue = int.Parse(calculationTextBox.Text);
                operandPressed = true;
                plusPressed = true;
                opCounter++;

                // reset all other operands
                minusPressed = false;
                multiplyPressed = false;
                dividePressed = false;
            }
            
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            opCounter++;
            if (opCounter >= 2)
            {
                nextValue = int.Parse(calculationTextBox.Text);
                int difference = firstValue - nextValue;
                nextValue = difference;
                calculationTextBox.Text = difference.ToString();
            }
            if (calculationTextBox.Text == "") 
            { calculationTextBox.Text = ""; }
            else
            {
                firstValue = int.Parse(calculationTextBox.Text);
                operandPressed = true;
                minusPressed = true;
                

                plusPressed = false;
                multiplyPressed = false;
                dividePressed = false;
            }
            
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            opCounter++;
            if (opCounter >= 2)
            {
                nextValue = int.Parse(calculationTextBox.Text);
                int product = firstValue * nextValue;
                nextValue = product;
                calculationTextBox.Text = product.ToString();
            }
            if (calculationTextBox.Text == "") 
            { calculationTextBox.Text = ""; }
            else
            {
                firstValue = int.Parse(calculationTextBox.Text);
                operandPressed = true;
                multiplyPressed = true;
                opCounter++;

                plusPressed = false;
                minusPressed = false;
                dividePressed = false;
            }
            
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            opCounter++;
            if (opCounter >= 2)
            {
                nextValue = int.Parse(calculationTextBox.Text);
                int quotient = firstValue / nextValue;
                nextValue = quotient;
                calculationTextBox.Text = quotient.ToString();
            }
            if (calculationTextBox.Text == "")
            { calculationTextBox.Text = ""; }
            else
            {
                firstValue = int.Parse(calculationTextBox.Text);
                operandPressed = true;
                dividePressed = true;
                opCounter++;

                plusPressed = false;
                minusPressed = false;
                multiplyPressed = false;
            }
            
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            // locks in 'nextValue'
            // When newEquation is set to true, it should reset the calculationTextBox to indicate a new equation
            // such that when a number is pressed after pressing equals, it clears the TextBox
            newEquation = true;

            // If both numbers are 0, dont do any calculations
            if (firstValue == 0 && nextValue == 0)
            {
                calculationTextBox.Text = "";
            }

            if (plusPressed == true)
            {
                nextValue = int.Parse(calculationTextBox.Text);
                int sum = firstValue + nextValue;
                calculationTextBox.Text = sum.ToString();
            }
            else if (minusPressed == true)
            {
                nextValue = int.Parse(calculationTextBox.Text);
                int difference = firstValue - nextValue;
                calculationTextBox.Text = difference.ToString();
            }
            else if (multiplyPressed == true)
            {
                nextValue = int.Parse(calculationTextBox.Text);
                int product = firstValue * nextValue;
                calculationTextBox.Text = product.ToString();
            }
            else if (dividePressed == true)
            {
                nextValue = int.Parse(calculationTextBox.Text);
                int quotient = firstValue / nextValue;
                calculationTextBox.Text = quotient.ToString();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            calculationTextBox.Clear();
            firstValue = 0;
            nextValue = 0;
            opCounter = 0;

            plusPressed = false;
            minusPressed = false;
            multiplyPressed = false;
            dividePressed = false;
            newEquation = true;
        }




    }
}
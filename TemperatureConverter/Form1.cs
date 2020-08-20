using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureConverter
{
    //KeyPressEventArgs e
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         

        }




        /// <summary>
        /// Input TextBox: Initial Value 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {

        }




        /// <summary>
        /// Validates input in real time for Input TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void inputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // TextBox doesn't accept letters or other random key values

            String validInput = "0123456789";
            String input = e.KeyChar.ToString();

            // If the input has a negative sign and the cursor is before it, move the cursor position to after the negative sign.
            // If the input is a decimal and the textbox doesn't already contain one, allow it.
            // If the key value is a real number or backspace allow it
            // Ignore all other forms of input.

            if (inputTextBox.Text.Contains("-"))
            {
                inputTextBox.SelectionStart = inputTextBox.Text.Length - (inputTextBox.Text.Length - 1);
            }
            else if ((input == ".") && (inputTextBox.Text.Contains(input).Equals(false)))
            {
                // Decimal
            }
            else if (validInput.Contains(input))
            {
                // Real Number
            }
            else
            {
                e.Handled = true;
            }
        }





        /// <summary>
        /// Output TextBox: Result
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void outputTextBox_TextChanged(object sender, EventArgs e)
        {

        }


        // InputComboBoxSelection
        private void inputSelectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        // OutputComboBoxSelection
        private void outputSelectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// ConvertButton: Initiate Calculations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void convertButton_Click(object sender, EventArgs e)
        {
            // Variables

            String inputValue = inputTextBox.Text;
            String fromUnit = inputSelectionBox.Text;
            String toUnit = outputSelectionBox.Text;


            // If program is missing any needed values, throw an exception
            try
            {
                if (String.IsNullOrEmpty(inputValue) || String.IsNullOrEmpty(fromUnit) || String.IsNullOrEmpty(toUnit))
                {
                    throw new Exception("A required value is missing!");
                }
                else if(fromUnit == toUnit)
                {
                    outputTextBox.Text = inputValue;
                }
                else
                {
                    // Call to Method --> pass the values
                    ConvertTemperature(inputValue, fromUnit, toUnit);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error Message");
                inputTextBox.Select();    
         
            } 
            
        }



        /// <summary>
        /// Method for Conversion from initial Unit to final Unit.
        /// </summary>
        /// <param name="inputValue"></param>
        /// <param name="fromUnit"></param>
        /// <param name="toUnit"></param>
        private void ConvertTemperature(String inputValue, String fromUnit, String toUnit) 
        {
            double value = Convert.ToDouble(inputValue);
            double Answer;
            
            // F to C
            if (fromUnit.Equals("FAHRENHEIT") && toUnit.Equals("CELSIUS"))
            {
                Answer = ((value - 32) * 5) / 9;
                outputTextBox.Text = Answer.ToString(".00");
            }
            // F to K
            else if (fromUnit.Equals("FAHRENHEIT") && toUnit.Equals("KELVIN"))
            {
                Answer = (((value - 32) * 5) / 9) + 273.15;
                outputTextBox.Text = Answer.ToString(".00");
            }

            // C to F
            else if (fromUnit.Equals("CELSIUS") && toUnit.Equals("FAHRENHEIT"))
            {
                Answer = (1.8 * value) + 32;
                outputTextBox.Text = Answer.ToString(".00");

            }
            // C to K
            else if (fromUnit.Equals("CELSIUS") && toUnit.Equals("KELVIN"))
            {
                Answer = value + 273.15;
                outputTextBox.Text = Answer.ToString(".00");

            }

            //K to F
            else if (fromUnit.Equals("KELVIN") && toUnit.Equals("FAHRENHEIT"))
            {
                Answer = (((value - 273.15) * 9) / 5) + 32;
                outputTextBox.Text = Answer.ToString(".00");

            }
            //K to C
            else if (fromUnit.Equals("KELVIN") && toUnit.Equals("CELSIUS"))
            {
                Answer = value - 273.15;
                outputTextBox.Text = Answer.ToString(".00");

            }

        }




        /// <summary>
        /// ResetButton: Erase all current data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetButton_Click(object sender, EventArgs e)
        {
            // Clear both textBoxes and reset selectionBoxes
            inputTextBox.Text = "";
            outputTextBox.Text = "";
            inputSelectionBox.SelectedIndex = -1;
            outputSelectionBox.SelectedIndex = -1;
            

        }




        /// <summary>
        /// ExitButton: Close Program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }





        /// <summary>
        /// NegativeSign Button: Negative Values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void negativeButton_Click(object sender, EventArgs e)
        {
            // If the number doesn't have a negative sign, add one to the beginning of the number
            // If it does then ignore the click 

            if (inputTextBox.Text.Contains("-").Equals(false)) 
            {
                inputTextBox.Text = inputTextBox.Text.Insert(0, "-");
                inputTextBox.SelectionStart = inputTextBox.Text.Length;
            }
            else
            {
                inputTextBox.Text = inputTextBox.Text.Remove(0, 1);
                inputTextBox.SelectionStart = inputTextBox.Text.Length;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace SalesTrack
{            //created by Trenton Thompson
   public static class Validator
    {// this class handles all of the exceptions.Here the message Entry Error is assigned to title which is encapsulated.
        private static string title = "Entry Error";
    // the value is applied with get and set.
        public static string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
       //IsPresent method validates the textbox control and makes sure a value was entered.
        public static bool IsPresent(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(textBox.Tag + " is a required field.", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }
       //Below IsDecimal method validates that user has entered a decimal.
        public static bool IsDecimal(TextBox textBox)
        {
            try
            {
                Convert.ToDecimal(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(textBox.Tag + " must be a decimal number.", Title);
                textBox.Focus();
                return false;
            }
        }

       //This can be applied to an integer value field making sure integer was entered, but is not used in the program currently.
        public static bool IsInt32(TextBox textBox)
        {
            try
            {
                Convert.ToInt32(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(textBox.Tag + " must be an integer.", Title);
                textBox.Focus();
                return false;
            }
        }
       //Below this IsWithinRange method can be used to limit range of decimals in the program, but is not currently used in program.
        public static bool IsWithinRange(TextBox textBox, decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number < min || number > max)
            {
                MessageBox.Show(textBox.Tag + " must be between " + min
                    + " and " + max + ".", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }
    }
}


    


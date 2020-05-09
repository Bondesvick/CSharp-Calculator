using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        #region Construcotr
        public MainWindow()
        {
            InitializeComponent();

            //Focuses the user to the text Box once the window loads
            FocusClacDispText();
        }
        #endregion

        #region Clearing Methods

        /// <summary>
        /// Clears the user inputs
        /// </summary>
        /// <param name="sender">The Event Sender</param>
        /// <param name="e">The Event Arguments</param>
        private void CEButton_Click(object sender, RoutedEventArgs e)
        {
            this.CalcDisp.Text = string.Empty;

            //Focus the User input
            FocusClacDispText();

            this.CalcResultText.Text = "Please enter an Equation and pess enter or = sign.";
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            DeleteTextValue();
        }

        #endregion

        #region Number Methods

        /// <summary>
        /// Adds the '0' character to the selected position of the user text input Box
        /// </summary>
        /// <param name="sender">The event Sender</param>
        /// <param name="e"> The Event Argument</param>
        private void ZeroButton_Click(object sender, RoutedEventArgs e)
        {
            InsertTextValue("0");

            //Focus the User input
            FocusClacDispText();
        }

        /// <summary>
        /// Adds the '1' character to the selected position of the user text input Box
        /// </summary>
        /// <param name="sender">The event Sender</param>
        /// <param name="e"> The Event Argument</param>
        private void OneButton_Click(object sender, RoutedEventArgs e)
        {
            InsertTextValue("1");

            //Focus the User input
            FocusClacDispText();
        }

        /// <summary>
        /// Adds the '2' character to the selected position of the user text input Box
        /// </summary>
        /// <param name="sender">The event Sender</param>
        /// <param name="e"> The Event Argument</param>
        private void TwoButton_Click(object sender, RoutedEventArgs e)
        {
            InsertTextValue("2");

            //Focus the User input
            FocusClacDispText();
        }

        /// <summary>
        /// Adds the '3' character to the selected position of the user text input Box
        /// </summary>
        /// <param name="sender">The event Sender</param>
        /// <param name="e"> The Event Argument</param>
        private void ThreeButton_Click(object sender, RoutedEventArgs e)
        {
            InsertTextValue("3");
        }

        /// <summary>
        /// Adds the '4' character to the selected position of the user text input Box
        /// </summary>
        /// <param name="sender">The event Sender</param>
        /// <param name="e"> The Event Argument</param>
        private void FourButton_Click(object sender, RoutedEventArgs e)
        {
            InsertTextValue("4");

            //Focus the User input
            FocusClacDispText();
        }

        /// <summary>
        /// Adds the '5' character to the selected position of the user text input Box
        /// </summary>
        /// <param name="sender">The event Sender</param>
        /// <param name="e"> The Event Argument</param>
        private void FiveButton_Click(object sender, RoutedEventArgs e)
        {
            InsertTextValue("5");

            //Focus the User input
            FocusClacDispText();
        }

        /// <summary>
        /// Adds the '6' character to the selected position of the user text input Box
        /// </summary>
        /// <param name="sender">The event Sender</param>
        /// <param name="e"> The Event Argument</param>
        private void SixButton_Click(object sender, RoutedEventArgs e)
        {
            InsertTextValue("6");

            //Focus the User input
            FocusClacDispText();
        }

        /// <summary>
        /// Adds the '7' character to the selected position of the user text input Box
        /// </summary>
        /// <param name="sender">The event Sender</param>
        /// <param name="e"> The Event Argument</param>
        private void SevenButton_Click(object sender, RoutedEventArgs e)
        {
            InsertTextValue("7");

            //Focus the User input
            FocusClacDispText();
        }

        /// <summary>
        /// Adds the '8' character to the selected position of the user text input Box
        /// </summary>
        /// <param name="sender">The event Sender</param>
        /// <param name="e"> The Event Argument</param>
        private void EightButton_Click(object sender, RoutedEventArgs e)
        {
            InsertTextValue("8");

            //Focus the User input
            FocusClacDispText();
        }

        /// <summary>
        /// Adds the '9' character to the selected position of the user text input Box
        /// </summary>
        /// <param name="sender">The event Sender</param>
        /// <param name="e"> The Event Argument</param>
        private void NineButton_Click(object sender, RoutedEventArgs e)
        {
            InsertTextValue("9");

            //Focus the User input
            FocusClacDispText();
        }

        /// <summary>
        /// Adds the '.' character to the selected position of the user text input Box
        /// </summary>
        /// <param name="sender">The event Sender</param>
        /// <param name="e"> The Event Argument</param>
        private void DotButton_Click(object sender, RoutedEventArgs e)
        {
            InsertTextValue(".");

            //Focus the User input
            FocusClacDispText();
        }
        #endregion

        #region Operator Methods

        /// <summary>
        /// Adds the '+' character to the selected position of the user text input Box
        /// </summary>
        /// <param name="sender">The event Sender</param>
        /// <param name="e"> The Event Argument</param>
        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            InsertTextValue("+");
        }

        /// <summary>
        /// Adds the '-' character to the selected position of the user text input Box
        /// </summary>
        /// <param name="sender">The event Sender</param>
        /// <param name="e"> The Event Argument</param>
        private void MinusButton_Click(object sender, RoutedEventArgs e)
        {
            InsertTextValue("-");

            //Focus the User input
            FocusClacDispText();
        }

        /// <summary>
        /// Adds the '*' character to the selected position of the user text input Box
        /// </summary>
        /// <param name="sender">The event Sender</param>
        /// <param name="e"> The Event Argument</param>
        private void MultiplyButton_Click(object sender, RoutedEventArgs e)
        {
            InsertTextValue("*");

            //Focus the User input
            FocusClacDispText();
        }

        /// <summary>
        /// Adds the '/' character to the selected position of the user text input Box
        /// </summary>
        /// <param name="sender">The event Sender</param>
        /// <param name="e"> The Event Argument</param>
        private void DivideButton_Click(object sender, RoutedEventArgs e)
        {
            InsertTextValue("/");

            //Focus the User input
            FocusClacDispText();
        }

        /// <summary>
        /// Calculates the given Equation in the User input Text
        /// </summary>
        /// <param name="sender">The Event Sender</param>
        /// <param name="e">The Event Argument</param>
        private void EqualsButton_Click(object sender, RoutedEventArgs e)
        {
            // Calls th function/Method that Calculates the Equation
            CalculateEquation();

            //Focus the User input
            FocusClacDispText();
        }
        #endregion

        /// <summary>
        /// Calculates the given Equation and outputs the answer to the TextBlock Below the TextBox
        /// </summary>
        private void CalculateEquation()
        {
            

            this.CalcResultText.Text = ParseOperation();


//            operationtype myenum = operationtype.add;
//            or
//var myenum = (int)operationtype.add;

            //Focus the user input Text
            FocusClacDispText();
        }

        /// <summary>
        /// Parses the users equation and calculates the result
        /// </summary>
        /// <returns></returns>
        private string ParseOperation()
        {
            try
            {
               // throw new ArgumentNullException("Something is null");

              //First of all, get the Equation typed on the text input Box
                var userinput = this.CalcDisp.Text;

                //Remove all spaces
                userinput = userinput.Replace(" ","");
                
                //Create a new Top-Level operation
                var operation = new Operation();
                var leftSide = true;

                //Loop through each character of the userinput
                //starting from the lefft working to the right
                for (int i = 0; i < userinput.Length; i++)
                {
                    // TODO: Handle order priority
                    //      4.2 + 5.7 * 3
                    //      It hould calculate 5 * 3 first, then 4 + the result (so 4 + 15)
                    //String Variables to hold the numbers "0123456789." and operators "+-*/" to be checked by the if, else Linq
                    var numString = "0123456789.";
                    var operatorString = "+-*/";

                    //Check if the current character is a number(0123456789.)
                    if (numString.Any(c => userinput[i] == c))
                    {
                        if (leftSide)
                        operation.LeftSide = AddNumberPart(operation.LeftSide, userinput[i]);
                        
                        else
                        operation.RightSide = AddNumberPart(operation.RightSide, userinput[i]);
                        
                    }
                    //Check if the current character is an operator (+-*/) then set the operator type
                    else if (operatorString.Any(c => userinput[i] == c))
                    {
                        // If we are on the right side already, we now need to calculate our current operation
                        //and set the result to the left side of the next operation
                        if (!leftSide)
                        {
                            //Get the oprator type
                            var operatorType = GetOperationType(userinput[i]);

                            //Check if we actually have a right side
                            if (operation.RightSide.Length == 0)
                            {
                                //Check the operator is not a minus (as they could be creating a negative number)
                                if (operatorType != OperationType.Minus)
                                    throw new InvalidOperationException($"Operator (=*/ or more than one - ) specified without a left side number");

                                //If we got here, the operator type is Minus, and tere is not left number currently, so add the minus to the number
                                operation.RightSide += userinput[i];
                            }
                            else
                            {
                                // Calculate previous operation and set it to the left side
                                operation.LeftSide = CalculateOperation(operation);

                                // Then, set new operator
                                operation.OperationType = operatorType;

                                // Clear the privious right number
                                operation.RightSide = string.Empty;
                            }

                        }
                        else
                        {
                            //Get the oprator type
                            var operatorType = GetOperationType(userinput[i]);

                            //Check if we actually have a left side
                            if (operation.LeftSide.Length == 0)
                            {
                                //Check the operator is not a minus (as they could be creating a negative number)
                                if (operatorType != OperationType.Minus)
                                    throw new InvalidOperationException($"Operator (=*/ or more than one - ) specified without a left side number");

                                //If we got here, the operator type is Minus, and tere is not left number currently, so add the minus to the number
                                operation.LeftSide += userinput[i];
                            }
                            else
                            {
                                // If we get here, we have a left number and now an operator, so we want to move to the right side

                                // Set the operation type
                                operation.OperationType = operatorType;

                                // Move to the right side
                                leftSide = false;
                            }
                        }
                    }
                }

                // If we sre done parsing, and there were no exceptions
                // calculate the current opration
                return CalculateOperation(operation);

                //return string.Empty;
            }
            catch(Exception ex)
            {
                return $"Invalid Equation: {ex.Message}";

               // MessageBox.Show(ex.Message.ToString());
            }

        }

        /// <summary>
        /// Calculates an <see cref="Operation"/> and returns the result
        /// </summary>
        /// <param name="operation"> The opearation to calculate</param>
        private string CalculateOperation(Operation operation)
        {
            // Store the number values of the string representations
            decimal left = 0;
            decimal right = 0;

            // Check if we have a left side number
            if (string.IsNullOrEmpty(operation.LeftSide) || !decimal.TryParse(operation.LeftSide, out left))
                throw new InvalidOperationException($"Left siide of the opration was not a number. {operation.LeftSide}");

            // Check if we have a right side number
            if (string.IsNullOrEmpty(operation.RightSide) || !decimal.TryParse(operation.RightSide, out right))
                throw new InvalidOperationException($"Right siide of the opration was not a number. {operation.RightSide}");

            try
            {
                switch (operation.OperationType)
                {
                    case OperationType.Add:
                        return (left + right).ToString();
                    case OperationType.Minus:
                        return (left - right).ToString();
                    case OperationType.Divide:
                        return (left / right).ToString();
                    case OperationType.Multiply:
                        return (left * right).ToString();
                    default:
                        throw new InvalidOperationException($"Unknown operator typed when calculating operation. {operation.OperationType}");
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Failed to calculate opearation {operation.LeftSide} {operation.OperationType} {operation.RightSide}. {ex.Message}");
            }
            return string.Empty;
        }

        /// <summary>
        /// Accepts a character and returns the known <see cref="OperationType"/>
        /// </summary>
        /// <param name="character">The character to parse</param>
        /// <returns>The type of opeartor</returns>
        private OperationType GetOperationType(char character)
        {
            switch (character)
            {
                case '+':
                    //
                    return OperationType.Add;
                case '-':
                    //
                    return OperationType.Minus;
                case '/':
                    //
                    return OperationType.Divide;
                case '*':
                    //
                    return OperationType.Multiply;
                default:
                    throw new InvalidOperationException($"Unknown operator type {character}");
            }
        }

        /// <summary>
        /// Attempts to add anew character to the current number, checking for valid characters as goes
        /// </summary>
        /// <param name="currentNumber">The current Number string</param>
        /// <param name="newCharacter">The new character to append to the string</param>
        /// <returns></returns>
        private string AddNumberPart(string currentNumber, char newCharacter)
        {
            //Check if there is already a . in the number
            if (newCharacter == '.' && currentNumber.Contains('.'))
                 throw new InvalidOperationException($"Number {currentNumber} already contains a . and another cannot be added");
        
            //Else, if . is not typed twice, just return the old number plus the new number
            return currentNumber + newCharacter;
        }

        #region Private Helpers

        /// <summary>
        /// Focuses the user to Text input Box
        /// </summary>
        private void FocusClacDispText()
        {
            this.CalcDisp.Focus();
        }

        /// <summary>
        /// Inserts the given tex into the User input text Box
        /// </summary>
        /// <param name="value">The User Input Text</param>
        private void InsertTextValue(string value)
        {
            // Remembers the user input start point
            var selectionstart = this.CalcDisp.SelectionStart;

            // Set the new Text
            this.CalcDisp.Text = this.CalcDisp.Text.Insert(this.CalcDisp.SelectionStart, value);

            // Restores the selection start point
            this.CalcDisp.SelectionStart = selectionstart + value.Length;

            // Set the selection Lenght to Zero
            this.CalcDisp.SelectionLength = 0;
        }

        /// <summary>
        /// Deletes the Character at the right of the selection of the user input text
        /// </summary>
        private void DeleteTextValue()
        {
            // If we don't have any value in text Box to delete, return.
            if (this.CalcDisp.Text.Length < this.CalcDisp.SelectionStart + 1)
                return;

            // Remembers the user input start point
            var selectionstart = this.CalcDisp.SelectionStart;

            var remember = CalcDisp.Text.Length;

            // Deletes the Character to the right of selction
            this.CalcDisp.Text = this.CalcDisp.Text.Remove(this.CalcDisp.SelectionStart, 1);

            // Restores the selection start point
            this.CalcDisp.SelectionStart = selectionstart;

        }

        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apka_okienkowa_WinForms
{
    public partial class Form1 : Form
    {
        #region Constructor
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        #endregion


        #region Delete Methods
        /// <summary>
        /// Deleting User iinput
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void CEButton_Click(object sender, EventArgs e)
        {
            //clears userinput 
            this.UserInputText.Text = string.Empty;

            FocusInputText();
        }

        private void CKey_Click(object sender, EventArgs e)
        {
            if (this.UserInputText.TextLength < this.UserInputText.SelectionStart + 1)
                return;
            this.UserInputText.Text = this.UserInputText.Text.Remove(this.UserInputText.SelectionStart, 1);
        }

        private void Del_Click(object sender, EventArgs e)
        {
            if (this.UserInputText.TextLength >= this.UserInputText.SelectionStart + 1)
            {
                var Variable = this.UserInputText.SelectionStart;
                this.UserInputText.Text = this.UserInputText.Text.Remove(this.UserInputText.SelectionStart, 1);
                this.UserInputText.SelectionStart = Variable-1;
                this.UserInputText.SelectionLength = 0;
            }

            FocusInputText();

        }


        #endregion

        #region Number Methods

        private void One_Click(object sender, EventArgs e)
        {
            InserTextValue("1");
            FocusInputText();

        }

        private void Two_Click(object sender, EventArgs e)
        {
            InserTextValue("2");

            FocusInputText();
        }

        private void Three_Click(object sender, EventArgs e)
        {
            InserTextValue("3");

            FocusInputText();
        }

        private void Four_Click(object sender, EventArgs e)
        {
            InserTextValue("4");

            FocusInputText();
        }

        private void Five_Click(object sender, EventArgs e)
        {
            InserTextValue("5");

            FocusInputText();
        }

        private void Six_Click(object sender, EventArgs e)
        {
            InserTextValue("6");

            FocusInputText();
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            InserTextValue("7");

            FocusInputText();
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            InserTextValue("8");

            FocusInputText();
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            InserTextValue("9");

            FocusInputText();
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            InserTextValue("0");

            FocusInputText();
        }

       

        private void Dot_Click(object sender, EventArgs e)
        {
            InserTextValue(".");

            FocusInputText();
        }

        private void Sign_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

        #region Math Methods
        private void Division_Click(object sender, EventArgs e)
        {
            InserTextValue("/");

            FocusInputText();
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            InserTextValue("*");

            FocusInputText();
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            InserTextValue("-");

            FocusInputText();
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            InserTextValue("+");

            FocusInputText();
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            CalculateEquation();
        }

        
        #endregion

        #region Private Helpers
        /// <summary>
        /// Focuses the user input text
        /// </summary>
        private void FocusInputText()
        {
            this.UserInputText.Focus();
            
        }
        /// <summary>
        /// inserts given text into user input textbox
        /// </summary>
        /// <param name="v">Function Value argument</param>
        private void InserTextValue(string v)
        {
            var Variable = this.UserInputText.SelectionStart;
            this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart, v);
            this.UserInputText.SelectionStart = Variable+v.Length;
            this.UserInputText.SelectionLength = 0;
        }

        /// <summary>
        /// Calculates equation
        /// </summary>
        private void CalculateEquation()
        {
            

            this.InputInfo.Text = ParseOperation();
        }
        /// <summary>
        /// parses user nput and calculate
        /// </summary>
        /// <returns></returns>
        private string ParseOperation()
        {
            try
            {
                //equation input
                var UserInput = this.UserInputText.Text;

                //remove all spaces
                UserInput = UserInput.Replace(" ", "");

                var operation = new Operation();
                var leftside = true;

                var RightSide = string.Empty;
                for(int i = 0; i<UserInput.Length; i++){
                    if("0123456789.".Any(c => UserInput[i] == c))
                    {
                        if (leftside)
                        {
                            operation.LeftSide = AddNumberPart(operation.LeftSide, UserInput[i]);
                           
                        }
                        else
                        {
                            operation.RightSide = AddNumberPart(operation.RightSide, UserInput[i]);
                        }
                        
                    }
                    else if ("/*-+".Any(c => UserInput[i] == c))
                    {
                        if (!leftside)
                        {
                            var OperatorType = GetOperationType(UserInput[i]);
                            if (operation.LeftSide.Length == 0)
                            {
                                if (OperatorType != OperationTypes.Minus)
                                {
                                    throw new InvalidOperationException("Opeartor (*-/+) without any lefy side number");
                                }
                                operation.LeftSide += UserInput[i];
                            }
                            else
                            {
                                operation.LeftSide = CalculateOperation(operation);
                                operation.OperationType = OperatorType;
                                operation.RightSide = string.Empty;
                            }


                        }
                        else
                        {
                            //gets the operator type
                            var OperatorType = GetOperationType(UserInput[i]);

                            if (operation.LeftSide.Length == 0)
                            {
                                if(OperatorType != OperationTypes.Minus)
                                {
                                    throw new InvalidOperationException("Opeartor (*-/+) without any lefy side number");
                                }
                                operation.LeftSide += UserInput[i];
                            }
                            else
                            {
                                operation.OperationType = OperatorType;
                                leftside = false;
                            }
                        }
                    }
                }

                return CalculateOperation(operation);
            }
            catch(Exception ex)
            {
                return $"Invalid Equation. {ex.Message}";
            }
        }

        private string CalculateOperation(Operation operation)
        {
            decimal left = 0;
            decimal right = 0;

            if (string.IsNullOrEmpty(operation.LeftSide) || !decimal.TryParse(operation.LeftSide, out left))
            {
               throw new InvalidOperationException("not valid left side");
            }
            if (string.IsNullOrEmpty(operation.RightSide) || !decimal.TryParse(operation.RightSide, out right))
            {
               throw new InvalidOperationException("not valid right side");
            }
            try
            {
                switch (operation.OperationType)
                {
                    case OperationTypes.Add:
                        return (left + right).ToString();
                    case OperationTypes.Minus:
                        return (left - right).ToString();
                    case OperationTypes.Multiply:
                        return (left * right).ToString();
                    case OperationTypes.Divide:
                        return (left / right).ToString();
                    default:
                        throw new InvalidOperationException($"Invalid Operator Exception. {operation.OperationType}");
                }
            }
            catch(Exception ex)
            {
                throw new InvalidOperationException($"failed to calculate operation {operation.LeftSide}{operation.OperationType}{operation.RightSide}");
            }
        }

        private  OperationTypes GetOperationType(char v)
        {
            switch (v)
            {
                case '+' :
                    return OperationTypes.Add;
                    
                case '-':

                    return OperationTypes.Minus;
                case '/':

                    return OperationTypes.Divide;
                case '*':

                    return OperationTypes.Multiply;
                default:
                    throw new InvalidOperationException("unknown operator type");
            }
        }

        private string AddNumberPart(string leftSide, char v)
        {
            if(v == '.' && leftSide.Contains('.'))
            {
                throw new InvalidOperationException($"Number {leftSide} contains '.' already");
            }
            return leftSide += v;
        }
        #endregion
    }
}

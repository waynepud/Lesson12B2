using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Wayne Pud
 * Student ID: 300931522
 * Date: August 10th, 2017
 * Description: This is a calculator demo project
 * Version: 1.1 - Added the show result method
 */

namespace Lesson12B2
{
    public partial class CalculatorForm : Form
    {
        // PRIVATE INSTANCE VARIABLES
        private bool _isDecimalClicked;

        private string _currentOperator;

        private List<double> _operandList;

        private double _result;

        // PUBLIC PROPERTIES
        public bool IsDecimalClicked {
            get
            {
                return this._isDecimalClicked;
            }
            set
            {
                this._isDecimalClicked = value;
            }
        }

        public string CurrentOperator
        {
            get
            {
                return this._currentOperator;
            }
            set
            {
                this._currentOperator = value;
            }
        }

        public List<double> OperandList
        {
            get
            {
                return this._operandList;
            }
            set
            {
                this._operandList = value;
            }
        }

        public double Result
        {
            get
            {
                return this._result;
            }
            set
            {
                this._result = value;
            }
        }
        // CONSTRUCTORS

        /// <summary>
        /// This is the main constructor for the CalculatorForm
        /// </summary>
        public CalculatorForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is an event handler for the "FormClosing"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This is shared event handler for the calculator buttons
        /// Not including the operator buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculatorButton_Click(object sender, EventArgs e)
        {
            Button calculatorButton = sender as Button;

            if ((this.IsDecimalClicked) && (calculatorButton.Text == "."))
            {
                return;
            }

            if (calculatorButton.Text == ".")
            {
                this.IsDecimalClicked = true;
            }


            if (ResultTextBox.Text == "0")
            {
                if ((ResultTextBox.Text == "0") && (calculatorButton.Text == "."))
                {
                    ResultTextBox.Text += calculatorButton.Text;
                }
                else
                {
                    ResultTextBox.Text = calculatorButton.Text;
                }
            }

            //if ((calculatorButton.Text == "0") && (ResultTextBox.Text == "0"))
            //{
            //    ResultTextBox.Text = calculatorButton.Text;
            //}
            else if ((ResultTextBox.Text == "0") && (calculatorButton.Text == "."))
            {
                ResultTextBox.Text += calculatorButton.Text;
            }
            else
            {
                ResultTextBox.Text += calculatorButton.Text;
            }

            //Debug.WriteLine("A calculator button was clicked");
        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button operatorButton = sender as Button; //downcasting
            double operand = this._convertOperand(ResultTextBox.Text); //Convert to number

            switch (operatorButton.Text)
            {
                case "C":
                    this._clear();
                    break;
                case "+":
                    this._calculate(operand, operatorButton.Text);
                    break;

                case "=":
                    this._showResult(operand);
                    break;

                case "⌫":
                    break;

                case "±":
                    break;

                default:
                    this._calculate(operand, operatorButton.Text);
                    break;
            }

        }

        /// <summary>
        /// This method shows the result of the last operation in the ResultTextBox
        /// </summary>
        /// <param name="text"></param>
        private void _showResult(double operand)
        {
            this._calculate(operand, this.CurrentOperator);
            ResultTextBox.Text = this.Result.ToString();
        }

        /// <summary>
        /// This method calculates the result of all the operands in the operator list
        /// </summary>
        /// <param name="text1"></param>
        /// <param name="text2"></param>
        private void _calculate(double operand, string operatorString)
        {
            OperandList.Add(operand);
            if (OperandList.Count > 1)
            {
                switch (operatorString) //Have to do multiply and divide for lab
                {
                    case "+":
                        this.Result = this.OperandList[0] + this.OperandList[1];
                        break;
                    case "-":
                        this.Result = this.OperandList[0] - this.OperandList[1];
                        break;
                }
            }
            this.CurrentOperator = operatorString;
        }


        /// <summary>
        /// This method converts the string from the resulttextbox to a number
        /// </summary>
        /// <param name="operandString"></param>
        /// <returns></returns>
        private double _convertOperand(string operandString)
        {
            try
            {
                return Convert.ToDouble(operandString);
            }
            catch (Exception exception)
            {

                Debug.WriteLine("An error occurred");
                Debug.WriteLine(exception.Message);
            }
            return 0;
            
        }





        /// <summary>
        /// This is the private clear method
        /// </summary>
        private void _clear()
        {
            this.IsDecimalClicked = false;
            ResultTextBox.Text = "0";
            this.CurrentOperator = "C";
            this.OperandList = new List<double>();
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            this._clear();
        }

    }
}

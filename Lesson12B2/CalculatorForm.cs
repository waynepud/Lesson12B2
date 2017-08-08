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
 * Date: August 3rd, 2017
 * Description: This is a calculator demo project
 * Version: 0.5 - Added private underscore clear method
 */

namespace Lesson12B2
{
    public partial class CalculatorForm : Form
    {
        // PRIVATE INSTANCE VARIABLES
        private bool _isDecimalClicked;


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

            ResultTextBox.Text += calculatorButton.Text;
            //Debug.WriteLine("A calculator button was clicked");
        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button operatorButton = sender as Button; //downcasting

            switch (operatorButton.Text)
            {
                case "C":
                    this._clear();
                    break;
                default:
                    break;
            }

        }

        /// <summary>
        /// This is the private clear method
        /// </summary>
        private void _clear()
        {
            throw new NotImplementedException();
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {

        }

    }
}

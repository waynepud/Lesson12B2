using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Wayne Pud
 * Student ID: 300931522
 * Date: August 8th, 2017
 * Description: This is a splashform
 * Version: 0.2 - Created SplashFormTimer_Tick Event Handler
 */

namespace Lesson12B2
{
    public partial class Splashform : Form
    {
        public Splashform()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the event handler for the tick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashformTimer_Tick(object sender, EventArgs e)
        {
            CalculatorForm calculatorForm = new CalculatorForm();
            calculatorForm.Show();
            this.Hide();
            SplashformTimer.Enabled = false; // turn timer off
        }
    }
}

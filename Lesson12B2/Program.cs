using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
 * Name: Wayne Pud
 * Student ID: 300931522
 * Date: August 3rd, 2017
 * Description: This is a calculator demo project
 * Version: 0.2 - Started splashform first
 */

namespace Lesson12B2
{
    public static class Program
    {
        // Create Reference to Forms
        public static CalculatorForm calculatorForm;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            calculatorForm = new CalculatorForm(); //instantiate a new object of type CalculatorForm
            Application.Run(new Splashform());
        }
    }
}

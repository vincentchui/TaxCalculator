using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
    class TaxCalculator
    {
        private double grossIncome, taxRate, taxAmount;

        public void menu()
        {
            string input;

            Console.WriteLine("\nWritten by Vincent Chui" +
                "\nCIS 23 BCC Fall 2015");

            do {
            Console.Write("\nIncome" +
                "\nReset" +
                "\nQuit" +
                "\nInput: ");
            input = Console.ReadLine().ToLower();
                    
                switch (input)
                {
                    case "income":
                        setIncome();
                        getTR();
                        break;
                    case "reset":
                        resetIncome();
                        break;
                    case "quit":
                        Console.WriteLine("\nGoodbye");
                        break;
                    default:
                        Console.WriteLine("INVALID INPUT");
                        break;
                }
            } while (input != "quit"); 
        }

        public void setIncome()
        {
            Console.Write("\nGross Income Amount: ");
            grossIncome = Convert.ToDouble(Console.ReadLine());
            
        }

        public void getTR()
        {
            double temp = grossIncome;

            do {
                if ((0 < grossIncome) && (grossIncome <= 30000))
                {
                    taxRate = 0;
                }
                else if ((grossIncome >= 30000.01) && (grossIncome <= 50000))
                {
                    taxRate = 0.1;
                    temp -= 20000;
                }
                else if ((grossIncome >= 50000) && (grossIncome <= 100000))
                {
                    taxRate = 0.2;
                    temp -= 50000;
                }
                else if ((grossIncome >= 100000) && (grossIncome <= 200000))
                {
                    taxRate = 0.3;
                    temp -= 100000;
                }
                else if ((grossIncome >= 200000) && (grossIncome <= 250000))
                {
                    taxRate = 0.35;
                    temp -= 50000;
                }
                else
                {
                    taxRate = 0.4;
                    temp -= 250000;
                }
            } while (taxRate > 30000);

            taxAmount = grossIncome * taxRate;

            Console.WriteLine("\nGROSS INCOME: " + grossIncome +
                "\nTAX RATE: " + taxRate + "%" +
                "\nTAX AMOUNT: " + taxAmount);
        }

        public void resetIncome()
        {
            grossIncome = 0;
            taxRate = 0;

            Console.WriteLine("\nIncome has been reset");
        }
    }
}
/*OUTPUT

Written by Vincent Chui
CIS 23 BCC Fall 2015

Income
Reset
Quit
Input: income

Gross Income Amount: 100000

GROSS INCOME: 100000
TAX RATE: 0.2%
TAX AMOUNT: 20000

Income
Reset
Quit
Input: reset

Income has been reset

Income
Reset
Quit
Input: income

Gross Income Amount: 200000

GROSS INCOME: 200000
TAX RATE: 0.3%
TAX AMOUNT: 60000

Income
Reset
Quit
Input: reset

Income has been reset

Income
Reset
Quit
Input: income

Gross Income Amount: 500000

GROSS INCOME: 500000
TAX RATE: 0.4%
TAX AMOUNT: 200000

Income
Reset
Quit
Input: quit

Goodbye
Press any key to continue . . .
*/
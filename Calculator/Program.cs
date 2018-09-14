/*  Title  :    Calculator
 *  Author :    nicolas.glassey@cpnv.ch
 *  Version:    06.09.2018 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maths
{
    public class Program
    {
        #region private attributes
        static private int userInputOperand01;
        static private string userInputOperator;
        static private int userInputOperand02;
        static private int displayResult;
        static private bool testOperand01;
        static private bool testOperand02;
        static private bool testOperator;
        #endregion private attributes

        /// <summary>
        /// This function is designed to be application's entry point
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // ask user to input 2 operands and 1 operator
            // Demander et tester le premier opérande
            do
            {
                Console.Write("First operand  : ");
                try
                {
                    userInputOperand01 = int.Parse(Console.ReadLine());
                    testOperand01 = true;
                }
                catch
                {
                    Console.Write("Vous devez inscrire un chiffre, pas une lettre.\n");
                    testOperand01 = false;
                }
            } while (testOperand01 == false);

            // Demande et test l'opérateur
            do
            {
                Console.Write("Operator : ");
                userInputOperator = Console.ReadLine();

                int num = 0;    // Pour le test du caractère
                bool result = int.TryParse(userInputOperator, out num);
                if (result == false)
                {
                    testOperator = true;
                }
                else
                {
                    Console.Write("Vous devez inscrire un opérateur valide.\n");
                    testOperator = false;
                }

            } while (testOperator == false);

            // Demande et teste le deuxième opérande
            do
            { Console.Write("Second operand : ");
                try
                {
                    userInputOperand02 = int.Parse(Console.ReadLine());
                    testOperand02 = true;
                }
                catch
                {
                    Console.Write("Vous devez inscrire un chiffre, pas une lettre.\n");
                    testOperand02 = false;
                }
            } while (testOperand02 == false);

            // sign test
            /*if (userInputSigne == "+")
            {*/
            //declare, init and use a "calculator" object
            Calculator calculator = new Calculator();
            displayResult = calculator.add(userInputOperand01, userInputOperator, userInputOperand02);
            /*}
            else if (userInputSigne == "-")
            {
                Calculator calculator = new Calculator();
                // soustraction
                displayResult = calculator.sub(userInputOperand01, userInputOperand02);
                signResult = true;
            }
            else if (userInputSigne == "*")
            {
                Calculator calculator = new Calculator();
                // multiplication
                displayResult = calculator.mul(userInputOperand01, userInputOperand02);
                signResult = true;
            }
            else if (userInputSigne == "/")
            {
                Calculator calculator = new Calculator();
                // division
                displayResult = calculator.div(userInputOperand01, userInputOperand02);

                signResult = true;
            }
            else
            {
                signResult = false;
            }

            // Affichages
            // Test du signe
            if (signResult == true)
            {*/
            Console.Write("Result of " + userInputOperand01 + userInputOperator + userInputOperand02 + " = " + displayResult);
            /*}
            else if (signResult == false)
            {
                Console.Write("Le signe que vous avez entré n'est pas correct. Veuillez entrer l'un de ces signes : + - * /.");
            }*/
            
            Console.ReadLine();
        }
    }
}

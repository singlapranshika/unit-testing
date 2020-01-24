using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathCalculator1
{
       public class MathOperation
        {
            public double Add(double number1, double number2)
            {
                return number1 + number2;
            }
            public double Subtract(double number1, double number2)
            {
                return number1 - number2;
            }
            public double Multiply(double number1, double number2)
            {
                return number1 * number2;
            }
            public double Divide(double number1, double number2)
            {
                return number1 / number2;
            }
            static void Main(string[] args)
            {
                MathOperation m = new MathOperation();
                double number1, number2, result = 0;
                number1 = Convert.ToDouble(Console.ReadLine());
                number2 = Convert.ToDouble(Console.ReadLine());
                String ch;
                ch = Console.ReadLine();
                switch (ch)
                {
                    case "+":
                        result = m.Add(number1, number2);
                        break;
                    case "-":
                        result = m.Subtract(number1, number2);
                        break;
                    case "*":
                        result = m.Multiply(number1, number2);
                        break;
                    case "/":
                        result = m.Divide(number1, number2);
                        break;

                }
                Console.WriteLine(result);
            }
        }
    }

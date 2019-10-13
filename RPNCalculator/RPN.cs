using System;
using System.Collections.Generic;
using System.Text;

namespace RPNCalculator
{
    class RPN
    {
        public static double Calculate(string inputString)
        {
            double result = 0;
            Stack<double> stack = new Stack<double>();

            for (int i = 0; i < inputString.Length; i++)
            {
                if (IsDelimeter(inputString[i]))
                    continue;

                string element = String.Empty;

                while (Char.IsDigit(inputString[i]))
                {
                    element += inputString[i];
                    i++;
                }

                if (element != String.Empty)
                {
                    try
                    {
                        stack.Push(Double.Parse(element));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Unable to recognize {element} as a number: {e.Message}");
                    }
                    finally
                    {
                    }
                }

                if (IsOperator(inputString[i]))
                {
                    double performResult = Perform(inputString[i], stack);

                    if (!Double.IsNaN(performResult))
                        stack.Push(performResult);
                    i++;
                }
                    
            }

            if (stack.Count > 0)
                result = stack.Pop();

            return result;
        }

        static private bool IsDelimeter(char c)
        {
            return ("= ".IndexOf(c) != -1);
        }

        static private bool IsOperator(char c)
        {
            return ("+-/*^".IndexOf(c) != -1); 
        }

        static private double Perform(char operation, Stack<double> stack)
        {
            double result = Double.NaN;
            if (stack.Count < 2)
            {
                Console.WriteLine("Input string is not standard.");
                return result;
            }            

            double a = stack.Pop();

            if (operation == '+')
                result = stack.Pop() + a;

            if (operation == '-')
                result = stack.Pop() - a;

            if (operation == '*')
                result = stack.Pop() * a;

            if (operation == '/')
                result = stack.Pop() / a;

            if (operation == '^')
                result = Math.Pow(stack.Pop(), a);

            return result;
        }
    }
}

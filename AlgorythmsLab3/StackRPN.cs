using System;
using System.Collections.Generic;

namespace AlgorythmsLab3
{

    public class StackRPN
    {
        public static string ParseInRPN(string input)
        {
            string output = string.Empty;
            Stack<char> operStack = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                if (IsDelimeter(input[i]))
                    continue;

                if (Char.IsDigit(input[i]))
                {
                    while (!IsDelimeter(input[i]) && !IsOperation(input[i]))
                    {
                        output += input[i];
                        i++;

                        if (i == input.Length) break;
                    }

                    output += " ";
                    i--;
                }

                if (IsOperation(input[i]))
                {
                    if (input[i] == '(')
                        operStack.Push(input[i]);
                    else if (input[i] == ')')
                    {
                        char s = (char)operStack.Pop();

                        while (s != '(')
                        {
                            output += s.ToString() + ' ';
                            s = (char)operStack.Pop();
                        }
                    }
                    else
                    {
                        if (operStack.Count > 0)
                            if (GetPriority(input[i]) <= GetPriority(operStack.Peek()))
                                output += operStack.Pop().ToString() + " ";

                        operStack.Push(char.Parse(input[i].ToString()));

                    }
                }
            }

            while (operStack.Count > 0)
                output += (char)operStack.Pop() + " ";

            return output;

        }

        static private bool IsDelimeter(char c)
        {
            return " =".IndexOf(c) != -1;
        }
        

        static private byte GetPriority(char s)
        {
            switch (s)
            {
                case '(': return 0;
                case ')': return 1;
                case '+': return 2;
                case '-': return 3;
                case '*': return 4;
                case '/': return 4;
                case '^': return 5;
                default: return 6;
            }
        }
        private static bool IsOperation(char symbol) => "+-/*^()".IndexOf(symbol) != -1;

        private static bool IsOperation(string operation) =>operation.Equals("+")
                                                             || operation.Equals("-")
                                                             || operation.Equals("=")
                                                             || operation.Equals("/")
                                                             || operation.Equals("*")
                                                             || operation.Equals("^")
                                                             || operation.Equals("ln")
                                                             || operation.Equals("cos")
                                                             || operation.Equals("sin");
        
        
        public static double CalculateRPN(List<string> rpn)
        {
            if (rpn.Count == 0)
            {
                throw new ArgumentException("Invalid number of values");
            }

            Stack<double> calc = new Stack<double>();
            foreach (var element in rpn)
            {
                double.TryParse(element, out double doubleValue);
                if (doubleValue != 0)
                {
                    calc.Push(doubleValue);
                }
                else if (IsOperation(element))
                {
                    if (calc.Count < 2)
                        {
                            double first = calc.Pop();
                            calc.Push(CalculateOperation(first: first, operation: element));
                        }
                        else
                        {
                            double second = calc.Pop();
                            double first = calc.Pop();

                            calc.Push(CalculateOperation(first: first, second: second, operation: element));
                        }
                }
                else
                {
                    throw new ArgumentException("Invalid value");
                }
            }

            return calc.Pop();
        }

        private static double CalculateOperation(double first, string operation, double second = 0)
        {
            switch (operation)
            {
                case "+":
                    return first + second;
                case "-":
                    return first - second;
                case "/":
                    return first / second;
                case "*":
                    return first * second;
                case "ln":
                    return Math.Log(first);
                case "cos":
                    return Math.Cos(first);
                case "^":
                    return Math.Pow(first, second);
                case "sin":
                    return Math.Sin(first);
                default:
                    throw new Exception("Invalid operation");
            }
        }
    }
}
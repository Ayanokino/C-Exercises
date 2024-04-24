using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Exercises
{
    public class Exercises
    {
        public void Exercise1()
        {
            Console.WriteLine("Hello\nLucas Pinto");
            Console.ReadKey();
        }
        public void Exercise2()
        {
            Console.WriteLine(2 + 2);
            Console.ReadKey();
        }
        public void Exercise3()
        {
            Console.WriteLine(3 / 3);
            Console.ReadKey();
        }
        public void Exercise4()
        {
            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine((35 + 5) % 7);
            Console.WriteLine(14 + -4 * 6 / 11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
            Console.ReadKey();
        }
        public void Exercise5()
        {
            int num1, num2, temp;
            Console.WriteLine("Input the first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("input the second number");
            num2 = int.Parse(Console.ReadLine());
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("After Swapping the two numbers: ");
            Console.WriteLine("First number: " + num1);
            Console.WriteLine("Second numbber: " + num2);
            Console.ReadKey();
        }
        public void Exercise6()
        {
            int num1, num2, num3;
            Console.WriteLine("Input the first number to multiply: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("input the second number to multiply: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the third number to multiply: ");
            num3 = int.Parse(Console.ReadLine());
            int result = num1 * num2 * num3;
            Console.WriteLine($"Result: {result}");
        }
        public void Exercise7()
        {
            double num1, num2, plus, minus, division, gange,mod;
            Console.WriteLine("Input the first number: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("input the second number: ");
            num2 = double.Parse(Console.ReadLine());
            plus = num1 + num2;
            minus = num1 - num2;
            division = num1 / num2;
            gange = num1 / num2;
            mod = num1 % num2;
            Console.WriteLine($"+ {plus}\n- {minus}\n/ {division}\n* {gange}\n% {mod}");
            Console.ReadKey();
        }
        public void Exercise8()
        {
            double Number,LoopNumber = 0;
            Console.WriteLine("Enter a number: ");
            Number = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("{0} * {1} = {2}", Number, LoopNumber, Number * LoopNumber);
                LoopNumber++;
            }
            while (LoopNumber !=  10);
            Console.ReadKey();
        }
    }
}

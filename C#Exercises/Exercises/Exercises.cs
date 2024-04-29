using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace C_Exercises
{
    public class Exercises
    {
        public void Exercise1()
        {
            Console.WriteLine("Hello\nLucas Pinto");
        }
        public void Exercise2()
        {
            Console.WriteLine(2 + 2);
        }
        public void Exercise3()
        {
            Console.WriteLine(3 / 3);
        }
        public void Exercise4()
        {
            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine((35 + 5) % 7);
            Console.WriteLine(14 + -4 * 6 / 11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
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
            gange = num1 * num2;
            mod = num1 % num2;
            Console.WriteLine($"+ {plus}\n- {minus}\n/ {division}\n* {gange}\n% {mod}");
        }
        public void Exercise8()
        {
            int Number,LoopNumber = 0;
            Console.WriteLine("Enter a number: ");
            Number = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("{0} * {1} = {2}", Number, LoopNumber, Number * LoopNumber);
                LoopNumber++;
            }
            while (LoopNumber !=  11);
        }
        public void Exercise9()
        {
            double number1, number2, number3, number4;

            Console.Write("Enter the First number: ");
            number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Second number: ");
            number2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the third number: ");
            number3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the fourth number: ");
            number4 = Convert.ToDouble(Console.ReadLine());
            double result = (number1 + number2 + number3 + number4) / 4;
            Console.WriteLine("The average of {0}, {1}, {2}, {3} is: {4} ",
                number1, number2, number3, number4, result);
        }
        public void Exercise10()
        {
            int number1, number2, number3, result1, result2;
            Console.Write("Enter the First number: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Second number: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the third number: ");
            number3 = Convert.ToInt32(Console.ReadLine());
            result1 = (number1 + number2) * number3;
            result2 = number1 * number2 + number2 * number3;
            Console.WriteLine($"Result of specified numbers {number1},{number2} and {number3},(x+y)*z is {result1} and x*y + y*z is {result2}");
        }
        public void Exercise11()
        {
            int age;
            Console.WriteLine("Write your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You look older than " + age);
        }
        public void Exercise12()
        {
            int Number;
            Console.WriteLine("Enter a Number: ");
            Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} {0} {0} {0}",Number);
            Console.WriteLine("{0}{0}{0}{0}",Number);
            Console.WriteLine("{0} {0} {0} {0}", Number);
            Console.WriteLine("{0}{0}{0}{0}", Number);
        }
        public void Exercise13()
        {
            int x;
            Console.Write("Enter a number: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}{0}{0}", x);
            Console.WriteLine("{0} {0}", x);
            Console.WriteLine("{0} {0}", x);
            Console.WriteLine("{0} {0}", x);
            Console.WriteLine("{0}{0}{0}", x);
        }
        public void Exercise14() 
        {
            double Celsius, Fahrenheit, Kelvin, Reaumur;
            Console.WriteLine("Skrive en temperatur i celsius: ");
            Celsius = Convert.ToDouble(Console.ReadLine());
            Fahrenheit = (Celsius * 9 / 5) + 32;
            Kelvin = Celsius + 273.15;
            Reaumur = Celsius * 0.8;
            Console.WriteLine($"Fahrenheit: {Fahrenheit}\nKelvin: {Kelvin}\nReaumur: {Reaumur}");
        }
        public void Exercise15() 
        {
            Console.WriteLine(remove_char("GamerName",1));
            Console.WriteLine(remove_char("GamerName",9));
            Console.WriteLine(remove_char("GamerName",0));
        }
        public static string remove_char(string str, int n)
        {
            return str.Remove(n, 1);
        }
        public void Exercise16()
        {
            Console.WriteLine(first_last("w3resource"));
            Console.WriteLine(first_last("Python"));
            Console.WriteLine(first_last("E"));
        }
        public static string first_last(string ustr)
        {
            return ustr.Length > 1
               ? ustr.Substring(ustr.Length) + ustr.Substring(1,ustr.Length - 2) + ustr.Substring(0,1) : ustr;
        }
        public void Exercise17()
        {
            string str;
            Console.WriteLine("Input a string");
            str = Console.ReadLine();
            if (str.Length > 1)
            {
                var s = str.Substring(0, 1);
                Console.WriteLine(s + str + s);
            }
        }
        public void Exercise18()
        {
            int int1, int2;
            Console.WriteLine("Input the first integer: ");
            int1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second integer: ");
            int2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(int1<0 || int2<0);
        }
        public void Exercise19()
        {
            int int1, int2;
            Console.WriteLine("Input the first integer: ");
            int1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second integer: ");
            int2 = Convert.ToInt32(Console.ReadLine());
            if (int1 == int2)
            {
                Console.WriteLine(int1*3);
            }
            else
            {
                Console.WriteLine(int1 + int2);
            }
        }
        public void Exercise20()
        {
            int int1, int2,DoubleValue;
            Console.WriteLine("Input the first integer: ");
            int1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second integer: ");
            int2 = Convert.ToInt32(Console.ReadLine());
            if (int1>int2)
            {
                DoubleValue = int1 - int2;
                Console.WriteLine(DoubleValue * 2);
            }
            else if(int2 > int1) 
            {
                Console.WriteLine(int2 - int1);
            }
        }
        public void Exercise21()
        {
            int int1, int2,result;
            Console.WriteLine("Input the first integer: ");
            int1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second integer: ");
            int2 = Convert.ToInt32(Console.ReadLine());
            result = int1 + int2;
            Console.WriteLine(result ==20 || int1==20 || int2==20);
        }
        public void Exercise22()
        {
            int number;
            Console.WriteLine("Write a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(result(number));
        }
        public static bool result(int n)
        {
            if (Math.Abs(n - 100) <= 20 || Math.Abs(n - 200) <= 20)
                return true; return false;
        }
        public void Exercise23()
        {
            string test = "This is a C# test string";
            Console.WriteLine(test.ToLower());
        }
        public void Exercise24()
        {
            string test = "This is a C# test string";
            string[] words = test.Split(new[] { " " }, StringSplitOptions.None);

            string word = "";
            int ctr = 0;

            foreach (String s in words)
            {
                if(s.Length > ctr)
                {
                    word = s;
                    ctr = s.Length;
                }
            }
            Console.WriteLine(word);
        }
        public void Exercise25()
        {
            int loopNumber = 0, number = 0;
            do
            {
                if (number % 2 != 0)
                {
                    Console.WriteLine(number);
                    
                }
                number++;

                loopNumber++;
            }
            while (loopNumber != 100);
        }
        public void Exercise26()
        {
            int sum = 0, count = 0, n = 2;//Sum holder på sum af prime numbers og n starter fra den første prime number

            //loop til at finde sum af de første 500 prime numbers
            while (count < 500)
            {
                if (isPrime(n)) //Checker om n er et prime number ved at kalde på isPrime method
                {
                    sum += n;// Putter numer n i sum variablet
                    count++;
                }
                n++;//tage den næste tal 
                
            }
            Console.WriteLine(sum);//displayer hele summen
        }
        public static bool isPrime(int n)
        {
            int x = (int)Math.Floor(Math.Sqrt(n));//finder square root a n

            if (n == 1) return false; //1 er ikke en prime number
            if (n == 2) return true; //2 er en prime number

            //Loop til at check om n kan divideres med været som helst tal fra 2 til kvadrat rulen af n
            for(int i = 2; i <= x; i++)
            {
                if (n % i == 0) return false;//Hvis n kan divideres med i, så er det ikke en prime number
            }

            return true; //n er en prime number hvis den kun kan divideres med sig selv og 1
        }
    }
}

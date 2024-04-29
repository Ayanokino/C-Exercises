using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Bil bil = new Bil();
            bil.Pris();

            Exercises exercises = new Exercises();
            exercises.Exercise25();
            Console.ReadKey();
        }
    }
}

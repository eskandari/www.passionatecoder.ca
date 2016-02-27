using System;

namespace csharp_MathRounding
{
    class Program
    {
        static void Main(string[] args)
        {
            RoundingSample();
        }

        static void RoundingSample()
        {
            //By default, .Net rounds mid-point number to nearest even number:
            var roundedValue35 = Math.Round(3.5);
            Console.WriteLine("Default Rounded Value for 3.5 is {0}", roundedValue35);//print:4
            var roundedValue45 = Math.Round(4.5);
            Console.WriteLine("Default Rounded Value for 4.5 is {0}", roundedValue45);//print:4
            var roundedValue325_1 = Math.Round(3.25, 1);
            Console.WriteLine("Default Rounded Value for 3.25 with 1 is {0}", roundedValue325_1);//print:3.2

            //you can change this default by passing MidpointRounding.AwayFromZero as second parameter to the Round method
            roundedValue35 = Math.Round(3.5, MidpointRounding.AwayFromZero);
            Console.WriteLine("Rounded Value by passing 'MidpointRounding.AwayFromZero' to the Round method for 3.5 is {0}", roundedValue35);//print:4
            roundedValue45 = Math.Round(4.5, MidpointRounding.AwayFromZero);
            Console.WriteLine("Rounded Value by passing 'MidpointRounding.AwayFromZero' to the Round method for 4.5 is {0}", roundedValue45);//print:5
            roundedValue325_1 = Math.Round(3.25, 1, MidpointRounding.AwayFromZero);
            Console.WriteLine("Rounded Value by passing 'MidpointRounding.AwayFromZero' to the Round method for 3.25 with 1 is {0}", roundedValue325_1);//print:3.3
        }
    }
}

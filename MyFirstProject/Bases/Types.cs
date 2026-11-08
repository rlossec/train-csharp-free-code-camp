using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal static class Types
    {
        public static void Run()
        {
            // Numérique

            // -- Integers
            int age = 23;

            Console.WriteLine("Votre age est : " + age);
            Console.WriteLine("Les int sont compris entre {0} et {1}", int.MinValue, int.MaxValue);

            long bigNumber = 123456L;

            Console.WriteLine(bigNumber);
            Console.WriteLine("Les long sont compris entre {0} et {1}", long.MinValue, long.MaxValue);

            // -- Floats
            float pi = 3.14F;

            Console.WriteLine("Le pi est : " + pi);
            Console.WriteLine("Les float sont compris entre {0} et {1}", float.MinValue, float.MaxValue);

            // -- Doubles
            double pi2 = 3.14159265358979323846;

            Console.WriteLine("Le pi2 est : " + pi2);
            Console.WriteLine("Les doubles sont compris entre {0} et {1}", double.MinValue, double.MaxValue);

            // -- Decimals
            decimal pi3 = 3.14159265358979323846M;

            Console.WriteLine("Le pi3 est : " + pi3);
            Console.WriteLine("Les decimals sont compris entre {0} et {1}", decimal.MinValue, decimal.MaxValue);

            int x, y, z;
            // Equivalent à
            // int x;
            // int y;
            // int z;

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix_gyak2
{
    class Program
    {
        //Kérjük be egy 2x2-es (esetleg egy 3x3-as) mátrix elemeit, 
        //majd „rajzoljuk” ki a mátrixot a konzol képernyőre, 
        //végül számítsuk ki és írjuk ki a determinánsát.
        static void Main(string[] args)
        {
            Console.WriteLine("Mátrix bekérés");
            int[,] matrix = new int[2, 2];
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("Kérem az {0}. sor {1} elemét: ", i+1, j+1);
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            Console.WriteLine();
            Console.WriteLine("A mátrix: ");
            Console.WriteLine();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                    Console.Write("{0}  ",matrix[i, j]);
                Console.WriteLine();               
            }
            Console.WriteLine();
            int det = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            Console.WriteLine("A mátrix determinálása: {0}", det);
            Console.ReadLine();
        }
    }
}

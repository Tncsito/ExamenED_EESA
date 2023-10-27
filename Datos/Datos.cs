using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenED_EESA.Datos
{
    internal class Datos
    {
        public void uno()
        {
            int total = 0;
            int total2 = 0;
            int total3 = 0;
            int total4 = 0;

            int[,] a = { { 1, 500, 1000, 250, 400, 60, 2, 3000, 150, 1800, 130, 20}, { 3, 100, 200, 2900, 90, 4000, 4, 400, 500, 300, 2400, 3600 } };
            Console.WriteLine($"El vendedor {a[0, 0]} tuvo ganancias de");
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine(a[0, i]);
                total = total + a[0, i];
            }
            Console.WriteLine("\nCon un total de " + total);
            Console.WriteLine($"\nEl vendedor {a[0, 6]} tuvo ganancias de");
            for (int i = 7; i < 12; i++)
            {
                Console.WriteLine(a[0, i]);
                total2 = total2 + a[0, i];
            }
            Console.WriteLine("\nCon un total de " + total2);
            Console.WriteLine($"\nEl vendedor {a[1, 0]} tuvo ganancias de");
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine(a[1, i]);
                total3 = total3 + a[1, i];
            }
            Console.WriteLine("\nCon un total de " + total3);
            Console.WriteLine($"\nEl vendedor {a[1, 6]} tuvo ganancias de");
            for (int i = 7; i < 12; i++)
            {
                Console.WriteLine(a[1, i]);
                total4 = total4 + a[1, i];
            }
            Console.WriteLine("\nCon un total de " + total4);
        }
        public void dos()
        {
            char[] a = new char[18];

            Console.WriteLine("Dame tu curp letra por letra");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Char.Parse(Console.ReadLine());
            }
            switch (a[10])
            {
                case 'H':
                    {
                        Console.Write("Usted es de Sexo Masculino, ");
                        break;
                    }
                case 'M':
                    {
                        Console.Write("Usted es de Sexo Femenino, ");
                        break;
                    }
            }
            Console.Write("y naciste el ");
            for (int i = 8; i < 10; i++)
            {
                Console.Write(a[i]);
            }
            Console.Write("/");
            for (int i = 6; i < 8; i++)
            {
                Console.Write(a[i]);
            }
            Console.Write("/");
            for (int i = 4; i < 6; i++)
            {
                Console.Write(a[i]);
            }

        }
        public void tres()
        {
            Random random= new Random();
            int[] a = new int[100];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(0,100);
                Console.WriteLine(a[i]);
            }
            //########################################
            //Ordenamiento
            int tmp = 0;

            for(int i = 0; i < a.Length - 1; i++)
            {
                for (int j = 1; j < a.Length - i -1; j++)
                {
                        a[i] = tmp;
                        tmp = a[j + 1];
                        a[j + 1] = tmp;
                }
            }
            Console.WriteLine("\n######################\n");
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            
        }
    }
}

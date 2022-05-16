using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Burbuja
{
    class Burbuja
    {
        private int[] vector;

        public void Cargar()
        {
            Console.WriteLine("Usando el modo Burbuja");
            Console.Write("Ingresa longitud de vector: ");
            string linea;
            linea = Console.ReadLine();
            int num;
            num = int.Parse(linea);
            vector = new int[num];
            for (int f = 0; f < vector.Length; f++)
            {
                Console.Write("Ingresa el numero " + (f + 1) + ": ");
                linea = Console.ReadLine();
                vector[f] = int.Parse(linea);
            }
        }

        public void MetodoBurbuja()
        {
            int t;
            for (int a = 1; a < vector.Length; a++)
                for (int b = vector.Length - 1; b >= a; b--)
                {
                    if (vector[b - 1] > vector[b])
                    {
                        t = vector[b - 1];
                        vector[b - 1] = vector[b];
                        vector[b] = t;
                    }
                }
        }
        public void Imprimir()
        {
            Console.WriteLine("Numeros ordenados en forma ascendente");
            for (int f = 0; f < vector.Length; f++)
            {
                Console.Write(vector[f] + "  ");
            }
            Console.ReadKey();
        }

        public void busqueda(int num)
        {
            int l = 0, h = 9;
            int m = 0;
            bool found = false;
            while (l <= h && found == false)
            {
                m = (l + h) / 2;
                if (vector[m] == num)
                    found = true;
                if (vector[m] > num)
                    h = m - 1;
                else
                    l = m + 1;
            }
            if (found == false)
            { Console.Write("\nEl elemento {0} no esta en el arreglo", num); }
            else
            { Console.Write("\nEl elemento {0} esta en la posicion: {1}", num, m + 1); }
        }
        public void Imprimir1()
        {
            for (int f = 0; f > vector.Length; f++)
            {
                Console.Write(vector[f] + "  ");
            }
        }
        static void Main(string[] args)
        {
            Burbuja pv = new Burbuja();
            pv.Cargar();
            pv.MetodoBurbuja();
            pv.Imprimir();
            pv.Imprimir1();
            Console.Write("\n\nQue elemento buscas: ");
            int num = int.Parse(Console.ReadLine());
            pv.busqueda(num);
            Console.ReadKey();
        }
    }
}
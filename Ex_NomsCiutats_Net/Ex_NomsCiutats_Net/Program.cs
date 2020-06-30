using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Ex_NomsCiutats_Net
{
    class Program
    {
        static void Main(string[] args)
        {
            // FASE 1
            // Crear 6 variables string vacias y pedir por consola 6 ciudades
            // guardarlas en las variables y mostrarlas.
            string v1, v2, v3, v4, v5, v6;
            // Solicitar ciudades por consola
            Console.WriteLine("Introduce la primera ciudad:");
            v1 = Console.ReadLine();
            Console.WriteLine("Introduce la segunda ciudad:");
            v2 = Console.ReadLine();
            Console.WriteLine("Introduce la tercera ciudad:");
            v3 = Console.ReadLine();
            Console.WriteLine("Introduce la cuarta ciudad:");
            v4 = Console.ReadLine();
            Console.WriteLine("Introduce la quinta ciudad:");
            v5 = Console.ReadLine();
            Console.WriteLine("Introduce la sexta ciudad:");
            v6 = Console.ReadLine();
            Console.WriteLine();

            //Mostrarlas por consola
            string[] arrayCiudades = new string[] { v1, v2, v3, v4, v5, v6 };
            Console.WriteLine("Las ciudades introducidas son:");
            
            for(int i = 0; i < arrayCiudades.Length; i++)
            {
                Console.WriteLine("La ciudad " + (i + 1) + " es: " + arrayCiudades[i]);
            }
            
            Console.WriteLine();

            // Fase 2
            // Guardar info en un array y mostrarlo en orden
            
            Array.Sort(arrayCiudades);
            Console.WriteLine();
            Console.WriteLine("Las ciudades en orden alfabetico son:");
            foreach (string value in arrayCiudades)
            {
                Console.Write(value + " ");
            }
            
            //Fase 3
            // Cambiar las a's por 4's, guardarla en un nuevo array y ordenarlo.
            // Creamos nuevo array para cada ciudad, longitud de cada array en longitud de cada string
            string[] arrayCiudadesModificadas = new string[arrayCiudades.Length];

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Reemplazamos la a por el 4:");

            for (int i = 0; i < arrayCiudades.Length; i++)
            {
                // cambiamos a por 4
                arrayCiudadesModificadas[i] = arrayCiudades[i].ToLower().Replace('a', '4');
            }
            // mostramos array ordenado y modificado
            foreach (string value in arrayCiudadesModificadas)
            {
                Console.Write(value + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            //Creamos 6 variables  array of chars

            char[] ciudad1 = new char[arrayCiudades[0].Length];
            char[] ciudad2 = new char[arrayCiudades[1].Length];
            char[] ciudad3 = new char[arrayCiudades[2].Length];
            char[] ciudad4 = new char[arrayCiudades[3].Length];
            char[] ciudad5 = new char[arrayCiudades[4].Length];
            char[] ciudad6 = new char[arrayCiudades[5].Length];

                       
                //ciudad1

            for (int i = 0; i < ciudad1.Length; i++)
            {
               ciudad1[i] = arrayCiudades[0][i];
            }
            // la escribimos al reves
            Console.Write("Para la ciudad " + arrayCiudades[0] + ": ");
            for (int i = ciudad1.Length - 1; i >= 0; i--)
            {
                Console.Write(ciudad1[i]);
            }
            Console.WriteLine();

            //ciudad2
            for (int i = 0; i < ciudad2.Length; i++)
            {
                ciudad2[i] = arrayCiudades[1][i];

            }
            Console.Write("Para la ciudad " + arrayCiudades[1] + ": ");
            for (int i = ciudad2.Length - 1; i >= 0; i--)
            {
                Console.Write(ciudad2[i]);
            }
            Console.WriteLine();
            //ciudad3
            for (int i = 0; i < ciudad3.Length; i++)
            {
               ciudad3[i] = arrayCiudades[2][i];
            }
            Console.Write("Para la ciudad " + arrayCiudades[2] + ": ");
            for (int i = ciudad3.Length - 1; i >= 0; i--)
            {
                Console.Write(ciudad3[i]);
            }
            Console.WriteLine();
            //ciudad4
            for (int i = 0; i < ciudad4.Length; i++)
            {
               ciudad4[i] = arrayCiudades[3][i];

            }
            Console.Write("Para la ciudad " + arrayCiudades[3] + ": ");
            for (int i = ciudad4.Length - 1; i >= 0; i--)
            {
                Console.Write(ciudad4[i]);
            }
            Console.WriteLine();
            //ciudad5
            for (int i = 0; i < ciudad5.Length; i++)
            {
                ciudad5[i] = arrayCiudades[4][i];
            }

            Console.Write("Para la ciudad " + arrayCiudades[4] + ": ");
            for (int i = ciudad5.Length - 1; i >= 0; i--)
            {
                Console.Write(ciudad5[i]);
            }
            Console.WriteLine();

            //ciudad6
            for (int i = 0; i < ciudad6.Length; i++)
            {
                ciudad6[i] = arrayCiudades[5][i];
            }
            Console.Write("Para la ciudad " + arrayCiudades[5] + ": ");
            for (int i=ciudad6.Length-1; i>=0; i--)
            {
                Console.Write(ciudad6[i]);
            }
            Console.WriteLine();

        }
    }
}

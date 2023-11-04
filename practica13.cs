using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {   
            //poblado de arreglos
            string [] nombres = {"juan", "manuel", "kevin", "maria", "zulma", "kenia"};

            double [] notas_primerComputo = new double [6];

            notas_primerComputo[0] = 7.5;
            notas_primerComputo[1] = 9.5;
            notas_primerComputo[2] = 6.5;
            notas_primerComputo[3] = 10;
            notas_primerComputo[4] = 5.6;
            notas_primerComputo[5] = 8.9;

            // Lectura de arreglos

            string primeraPosicion = nombres [0]; //juan
            string segundaPosicion = nombres [1]; //manuel
            string terceraPosicion = nombres [2]; //kevin
            string cuartaPosicion = nombres [3]; //maria
            string quintaPosicion = nombres [4]; //zulma
            string UltimaPosicion = nombres [5]; //kenia

            double notasPrimeraPosicion = notas_primerComputo [0]; //7.5
            double notassegundaPosicion = notas_primerComputo [1]; //9.5
            double notasterceraPosicion = notas_primerComputo [2]; //6.5
            double notascuartaPosicion = notas_primerComputo [3]; //10
            double notasQuintaPosicion = notas_primerComputo [4]; //5.6
            double notasUltimaPosicion = notas_primerComputo [5]; //8.9

            // Ordenamientos de arreglos
            Console.WriteLine ("\n----Mostrando los 6 alumnos de forma ascendente----");
            Array.Sort(nombres);
            foreach (string nombre in nombres)
            {
                Console.WriteLine(nombre);
            }

            Console.WriteLine ("\n----Mostrando los 6 alumnos de forma ascendente----");
            Array.Reverse(nombres);
            foreach (string nombre in nombres)
            {
                Console.WriteLine(nombre);
            }

            Console.WriteLine ("\n----Mostrando los 6 notas de forma ascendente----");
            Array.Sort(notas_primerComputo);
            foreach (double notas1 in notas_primerComputo)
            {
                Console.WriteLine(notas1);
            }

            Console.WriteLine ("\n----Mostrando los 6 notas de forma descendente----");
            Array.Reverse(notas_primerComputo);
            foreach (double notas1 in notas_primerComputo)
            {
                Console.WriteLine(notas1);
            }

            // Impresion de resultados de los arreglos
            Console.WriteLine("\n -----Mostrandos los 6 alumnos con sus notas del primer computo----- ");
            Console.WriteLine(primeraPosicion + " Tiene la siguiente nota: " + notasPrimeraPosicion);
            Console.WriteLine(segundaPosicion + " Tiene la siguiente nota: " + notassegundaPosicion);
            Console.WriteLine(terceraPosicion + " Tiene la siguiente nota: " + notasterceraPosicion);
            Console.WriteLine(cuartaPosicion + " Tiene la siguiente nota: " + notascuartaPosicion);
            Console.WriteLine(quintaPosicion + " Tiene la siguiente nota: " + notasQuintaPosicion);
            Console.WriteLine(UltimaPosicion + " Tiene la siguiente nota: " + notasUltimaPosicion);
        }
    }
}
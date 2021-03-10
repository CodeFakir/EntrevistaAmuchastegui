using System;
using System.Collections.Generic;

namespace EntrevistaAmuchastegui
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu();
        }

        static void Ej1()
        {
            Console.Write("Ingrese un número ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
                Console.Write("el numero" + " " + num + " " + "es positivo\n");
            else
            { Console.Write("el numero" + " " + num + " " + "es negativo\n"); }



            VolverMenuPrincipal();

        }


        static void Ej2()
        {
            List<int> list = new List<int>();
            int num = 1;
            do
            {
                Console.Write("Ingrese un número ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num > 0)
                    list.Add(num);
            }

            while (num > 0);

            list.Sort();
            list.Reverse();

            foreach (int value in list)
            {
                Console.Write(value + "\n");
            }

            VolverMenuPrincipal();



        }

        static void Menu()
        {


            int num1 = 0; int num2 = 0;

            Console.WriteLine("Entrevista Amuchastegui\r");
            Console.WriteLine("------------------------\n");


            Console.WriteLine("Seleccione el ejercicio:");
            Console.WriteLine("\t1 - Problema 1 : Ingresar un número e indicar si es positivo o negativo (Ingresar 0 para finalizar)");
            Console.WriteLine("\t2 - Problema 2 : Ordenar un array de número de de mayor a menor");
            Console.WriteLine("\t3 - Problema 3 : dados 3 vagones de tren determinar...");
            Console.Write("Esperando respuesta  ");

            // Use a switch statement to do the math.
            switch (Console.ReadLine())
            {
                case "1":

                    Ej1();
                    break;
                case "2":
                    Ej2();
                    break;
                case "3":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;

            }


        }

        static void VolverMenuPrincipal()
        {

            Console.Write("presione enter para volver al menu principal o escape para salir");
            ConsoleKeyInfo info = Console.ReadKey();
            if (info.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                Menu();
            }

            if (info.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }

        static void Ej3()
        {
            List<Caja> list = new List<Caja>();
            List<Caja> vagon1 = new List<Caja>();
            List<Caja> vagon2 = new List<Caja>();
            List<Caja> vagon3 = new List<Caja>();
            const int capacidadVagones = 141;
            const int capacidadCargaTotal = 423;
            const int cantidadVagones = 3;
            string dimensiones = "";
            int volumenTotalAcargar = 0;
            int volumenAproximadoAcargarPorVagon = 0;
            int x = 0, y = 0, z = 0;
            do
            {
                Console.Write("Ingrese las dimensiones de la caja x,y,z separadas por una coma ");
                dimensiones = Console.ReadLine();
                // if (num > 0)

                Caja caja = new Caja(x, y, z);
                volumenTotalAcargar += caja.VolumenM3;
                list.Add(caja);
            }

            while (x != 0 && y != 0 && z != 0 && volumenTotalAcargar <= capacidadCargaTotal);
            list.Sort();
            list.Reverse();
            volumenAproximadoAcargarPorVagon = volumenTotalAcargar / cantidadVagones;

            if (list.Count > 3)
            {
                vagon1.Add(list[0]);
                vagon2.Add(list[1]);
                vagon3.Add(list[2]);
                list.RemoveRange(0, 3);


                foreach (Caja caja in list)
                {
                  
                }
            }


            VolverMenuPrincipal();



        }

    }



}

﻿using System;

namespace Ej_Propuesto_1_Mozo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1-El dueño de un restaurante, desea saber la cantidad de platos que se venden; de un menú fijo, 
             existen 2 mozos para la atención de la gente, el menú es el siguiente: 1-Milanesas con papas fritas2-Pizzas3-Plato Especial.
            Losdatos que se ingresan por pantalla son los siguientes:-Nro. de Mozo-Plato seleccionado de menú(1, 2,3)
            Dar la opción de salir del sistema en cualquier momento (Ejemplo: Salir con (0)Cero, <Enter> para continuar cargando).
            Se debe informar por pantalla cual de los 2 mozos vendió másplatos del menú, la información que se pide es la siguiente:
            
                        El mozo que másplato sirvió es: 1
                        Cantidad de platos servidos: 10
                        Cantidad del Plato nº 1: 4
                        Cantidad del Plato nº 2: 4
                        Cantidad del Plato nº 3: 2
             */

            int menu, mozo, mozo1, mozo2, plato1, plato2, plato3, totalPlatos;
            string mozoMasVentas, option;
            mozo1 = 0;
            mozo2 = 0;
            mozo = 0;
            plato1 = 0;
            plato2 = 0;
            plato3 = 0;
            totalPlatos = 0;
            option = "";
            Console.WriteLine("Control de ventas diarias");
            Console.WriteLine("Mosos \n 1- Juan \n 2- Pablo");
            Console.WriteLine("Menu\n 1 - Milanesas con Papas fritas\n 2 - Pizzas\n 3 - Plato especial\n");
            do
            {
                //seleccion de moso 
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Indique que moso realiza la venta");
                mozo = int.Parse(Console.ReadLine());
                switch (mozo)
                {
                    case 1:
                        mozo1 = mozo1 + 1;
                        break;
                    case 2:
                        mozo2 = mozo2 + 1;
                        break;
                    default:
                        Console.WriteLine("no existe ese moso");
                        break;
                }
                //selección de menu
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Seleccione un plato del menu");
                menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        plato1 = plato1 + 1;
                        break;
                    case 2:
                        plato2 = plato2 + 1;
                        break;
                    case 3:
                        plato3 = plato3 + 1;
                        break;
                    default:
                        Console.WriteLine("Plato no valido");
                        break;
                }
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("para continuar cargando precione 'enter' o 0 para salir");
                option = Console.ReadLine();
            } while (option != "0");
            totalPlatos = plato1 + plato2 + plato3;
            if (mozo1 > mozo2)
            { mozoMasVentas = "Juan, Mozo 1"; }
            else { mozoMasVentas = "Pablo, Mozo 2"; }
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"               El mozo que mas platos vendio fue el {mozoMasVentas}");
            Console.WriteLine($"               Cantidad de platos vendidos en total     {totalPlatos}");
            Console.WriteLine($"               Cantidad de platos de Milanesas             {plato1}");
            Console.WriteLine($"               Cantidad de platos de Pizza                 {plato2}");
            Console.WriteLine($"               Cantidad de platos de Especial              {plato3}");

            Console.ReadKey();
        }
    }
}

﻿using System;

namespace Ej_Propuesto_2_NotasMyF
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Profesor con dos materias. Matematica y Fisica 
              Mostrar  Cuantos aprobaron cuantos reprobaron por materia 
             ingresa los datos, legajo / nota / materia 
             opcion a salir con 0 
             apruevan con nota superior a 7 */
            float promedioFis, nota, aprobado, promedioMat, sumaNotaMat, sumaNotaFis;
            int cAlumnosMat, cAlumnosFis, aprobadosMat, aprobadosFis, reprobadosMat, reprobadosFis, legajo, materia, option, caso;

            materia = 0;
            legajo = 0;
            nota = 0;
            option = 1;
            caso = 0;
            cAlumnosMat = 0;
            cAlumnosFis = 0;
            aprobado = 7;
            aprobadosMat = 0;
            aprobadosFis = 0;
            reprobadosMat = 0;
            reprobadosFis = 0;
            sumaNotaMat = 0;
            sumaNotaFis = 0;

            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Carga de notas para Matematica y Fisica");

            do
            {
                Console.WriteLine("Ingrese el legajo del alumno: ");
                legajo = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese la nota del alumno");
                nota = float.Parse(Console.ReadLine());
                Console.WriteLine("Seleccione la materia del alumno \n  1-Matematicas \n  2-Fisica");
                materia = int.Parse(Console.ReadLine());
                //if (legajo != 0 && materia == 1) { caso = 1;}
                //else if (legajo != 0 && materia == 2) { caso = 2; }
                caso = materia;
                switch (caso)
                {
                    //Matematicas
                    case 1:
                        cAlumnosMat++;
                        if (nota >= aprobado)
                        {
                            aprobadosMat++;
                        }
                        else { reprobadosMat++; }
                        sumaNotaMat = sumaNotaMat + nota;
                        break;
                    //Fisica
                    case 2:
                        cAlumnosFis++;
                        if (nota >= aprobado)
                        {
                            aprobadosFis++;
                        }
                        else { reprobadosFis++; }

                        sumaNotaFis = sumaNotaFis + nota;
                        break;
                    default:
                        Console.WriteLine("No es una materia valida");
                        break;
                }

                Console.WriteLine("Para contiar cargando precione 1 o para salir precione 0");
                option = int.Parse(Console.ReadLine());
            } while (option != 0);

            promedioMat = sumaNotaMat / cAlumnosMat;
            promedioFis = sumaNotaFis / cAlumnosFis;

            //Matematicas 
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Materia Matematicas ");
            Console.WriteLine($"Cantidad de alumnos{cAlumnosMat}");
            Console.WriteLine($"Cantidad de alumnos aprobados: {aprobadosMat}");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Candad de alumnos  reprobados: {reprobadosMat} ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"Promedio obtenido: {promedioMat}");
            //Fisica
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Materia Matematicas ");
            Console.WriteLine($"Cantidad de alumnos{cAlumnosFis}");
            Console.WriteLine($"Cantidad de alumnos aprobados: {aprobadosFis}");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Candad de alumnos  reprobados: {reprobadosFis} ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"Promedio obtenido: {promedioFis}");

            Console.ReadKey();
        }
    }
}

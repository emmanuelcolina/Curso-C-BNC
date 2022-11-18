using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace Ejercicio4
{
    class Program {


        static void Main(string[] args) {

            
            try {
                //Creacion del archivo

                /***************************************Ejercicio1*********************************************/

                //Lectura de archivo

                Console.WriteLine("Contenido del Archivo:");
                var leer_archivo = new StreamReader("C:/Curso CSharp/archivo.txt");
                Console.WriteLine(leer_archivo.ReadToEnd());
                leer_archivo.Close();

                string[] lineas = File.ReadAllLines("C:/Curso CSharp/archivo.txt"),
                         lineasMayor = File.ReadAllLines("C:/Curso CSharp/archivo2.txt"),
                         palabras;

                string texto, palabraMayor = "";

                Boolean palabraEncontrada = false;

                Console.WriteLine("Ingrese una Palabra: ");

                texto = Console.ReadLine().ToString();


                for (int i = 0; i < lineas.Length; i++) {

                    palabras = lineas[i].Split(',');

                    foreach (var palabra in palabras)
                    {
                        if (texto == palabra.Trim())
                        {
                            palabraEncontrada = true;

                            break;
                        }
                            
                    }

                }

                if (palabraEncontrada)
                    System.Console.WriteLine("\nPalabra Hace Match");
                else
                    System.Console.WriteLine("\nPalabra No Hace Match");

                System.Console.WriteLine("\n");

                /***************************************Ejercicio2*********************************************/


                for (int i = 0; i < lineasMayor.Length; i++) {

                    if (palabraMayor.Length < lineasMayor[i].Length)
                    {   
                        palabraMayor = lineasMayor[i];
                    }
                }

                var archivo3 = new StreamWriter("C:/Curso CSharp/archivo3.txt");
               
                archivo3.WriteLine(palabraMayor);
                archivo3.Close();
                System.Console.WriteLine("Linea Mayor en el Archivo: " + palabraMayor);

                System.Console.WriteLine("\n");

                /***************************************Ejercicio3*********************************************/

                System.Console.WriteLine("Ingrese el nombre del archivo de Origen");
                var archivo4 = new StreamWriter("C:/Curso CSharp/"+Console.ReadLine().ToString()+".txt");
                Console.WriteLine("Ingresa el texto que quieres agregar al archivo");
                string textoNuevo = Console.ReadLine().ToString();
                archivo4.WriteLine(textoNuevo);
                archivo4.Close();

                System.Console.WriteLine("Ingrese el nombre del archivo de Destino");
                var archivo5 = new StreamWriter("C:/Curso CSharp/" + Console.ReadLine().ToString() + ".txt");
                archivo5.WriteLine(textoNuevo.ToUpper());
                archivo5.Close();

            }
            catch (FileNotFoundException e) {
                Console.WriteLine(e.Message+ "Archivo no Existe");
            }    

        }
    }
}

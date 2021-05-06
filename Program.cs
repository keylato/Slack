using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) Decir "Hola Mundo!"
            // 2) Decir "Hola [nombre]!"
            // 9) Salir

            // while

            // Mostrar el menú de opciones
            // Solicitar la opción al usuario
            StackNotas stackNotas = new StackNotas();
            stackNotas.Push("Primer nota");
            stackNotas.Push("Segunda nota");
            stackNotas.Push("Tercera nota");

            string opcion = "";
            while (opcion != "9")
            {
                opcion = "";
                // Pedir opción al usuario
                while (opcion != "1" && opcion != "2" && opcion != "9" && opcion != "4")
                {
                    // Escapar caracter "
                    Console.WriteLine("1) Decir Imprimir Stack");
                    Console.WriteLine("2) Decir \"Hola [nombre]!\"");
                    Console.WriteLine("4) Consultar un elemnto (peek");
                    Console.WriteLine("9) Salir");


                    Console.WriteLine("Por favor selecciona una opción:");
                    opcion = Console.ReadLine();

                    // Validar opción ingresada
                    // hasta que se introduzca una opción correcta
                    // (mientras no se haya introducido una opción correcta)
                    if (opcion != "1" && opcion != "2" && opcion != "9")
                    {
                        Console.WriteLine("La opción seleccionada no es correcta.");
                    }
                }

                // Manejar la opción seleccionada
                if (opcion == "1")
                {
                    stackNotas.PrintStack();
                }
                else if (opcion == "2")
                {
                    //Push 
                    Console.WriteLine("Agregar nota:");
                    string nota = Console.ReadLine();
                    stackNotas.Push(nota);
                }
                else if (opcion == "3")
                {
                    string nota = stackNotas.Pop();
                    Console.WriteLine("Nota removida:");
                    Console.WriteLine(nota);
                }
                else if (opcion == "4")
                {
                    //peek
                    string nota = stackNotas.Peek();
                    Console.WriteLine("Nota consultada:");
                    Console.WriteLine(nota);
                }
                else if (opcion == "9")
                {
                    Console.WriteLine("Hasta luego!");
                }
            }

        }
    }
}
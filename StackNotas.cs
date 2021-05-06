using System;
using System.Collections.Generic;

namespace Stack
{
    class StackNotas
    {
        List<string> notas = new List<string>();
        
        //Push-> Agregar elementos
        //Quitar elementos
        //Peek-> Ver el elemnto de arriba
        //Pop -> Ver + Quitar
        //Saber cuantos elementos tiene dentro

        //Imprimir Stack
        public int Count {
            get => this.notas.Count;
        }

        public void Push(string nota)
        {
            // La parte de arriba del stack es el final de la lista
            this.notas.Add(nota);
        }
        public string Pop()
        {
            //1. Devolver valor
            //2. Borrar

            //Respaldar Valor
            string value= this.notas[this.notas.Count -1];
            //Borrar de la lista
            this.notas.RemoveAt(this.notas.Count -1);
            
            //Devolver el valor respaldo
            return value; //<-- la funcion llega hasta aqui (return)
        }
        public string Peek()
        {

            if (this.notas.Count == 0)
            {
                Console.WriteLine("no hay elementos en el stack");
                return null;
            }
            else
            {
                return this.notas[this.notas.Count -1];
            }
            
        }
        public void PrintStack()
        {
            for (int i = this.notas.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(notas[i]);
            }
        }
    }
}
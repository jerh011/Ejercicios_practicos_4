using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_practicos_4
{
    internal class Metodos
    {
        //Considere un arreglo entero t de dos por tres.
        //a) Escriba una instrucción que declare y cree a t.
        public int[,] IncisoA() {
            int[,] t = new int[2, 3];
           
        return t;
        }

        //b) ¿Cuántas filas tiene t?
        public void IncisoB(int[,] t)
        {
            Console.WriteLine($"La filas es {t.GetLength(0)}");
        }
        //c) ¿Cuántas columnas tiene t?
        public void IncisoC(int[,] t)
        {
            Console.WriteLine($"La columnas es {t.GetLength(1)}");
        }
        //d) ¿Cuántos elementos tiene t?
        public void IncisoD(int[,] t)
        {
            Console.WriteLine($"Los elementos son {t.Length}");
        }
        //e) Escriba expresiones de acceso para todos
        //los elementos en la fila 1 de t.
        public void IncisoE(int[,] t)
        {
            Console.Write($"Los elementos en la fila 1 son");
            for (int i = 0;i < t.GetLength(0); i++)
                Console.Write($" {t[1,i]}");
            Console.WriteLine(" ");
        }
        //f ) Escriba expresiones de acceso para
        //todos los elementos en la columna 2 de t.
        public void IncisoF(int[,] t)
        {
            Console.Write($"Los elementos en la fila 1 son");
            for (int i = 0; i < t.GetLength(1); i++)
                Console.Write($" {t[0, i]}");

            Console.WriteLine(" ");
        }
        //g) Escriba una sola instrucción que asigne cero al elemento de t en la fila 0 y la columna 1.
        public void IncisoG(int[,] t)
        {
            t[0,1]= 0;
        }
        //h) Escriba una serie de instrucciones que inicialice cada elemento de t con cero. No utilice una instrucción de repetición.
        public void IncisoH(int[,] t)
        {
            t[0, 0] = 0;
            t[0, 1] = 0;
            t[0, 2] = 0;
            t[1, 0] = 0;
            t[1, 1] = 0;
            t[1, 2] = 0;
        }
        //i) Escriba una instrucción for anidada que inicialice cada elemento de t con cero.

        public void IncisoI(int[,] t)
        {
            for (int x = 0; x < t.GetLength(0); x++) {
                for (int y = 0; y < t.GetLength(1); y++)
                    t[x, y] = 0;
            }
        }
        //j) Escriba una instrucción for anidada que reciba como entrada del usuario los valores de los elementos de t.
        public int[,] IncisoJ(int[,] t)
        {
            for (int x = 0; x < t.GetLength(0); x++)
            {
                for (int y = 0; y < t.GetLength(1); y++)
                {
                    Console.WriteLine($"Ingrese el dato del arreglo {x}{y}");
                    t[x, y] = Convert.ToInt32(Console.ReadLine());

                }
            }
            return t;
        }
        //k) Escriba una serie de instrucciones que determine e imprima el valor más pequeño en t.
        public void IncisoK(int[,] t)
        {
            for (int x = 0; x < t.GetLength(0); x++)
            {
                for (int y = 0; y < t.GetLength(1); y++) { 
                Console.Write("{0,-3}|", t[x, y]);
            }
                Console.WriteLine(" ");
            }
        }
        //l) Escriba una instrucción Console.WriteLine que muestre los elementos de la primera fila de t. No utilice repetición.
        public void IncisoL(int[,] t)
        {
            Console.WriteLine($"{t[0, 0]}| {t[0, 1]}| {t[0, 2]}");
        }
        //m) Escriba una instrucción que totalice los elementos de la tercera columna de t. No utilice repetición.
        public void IncisoM(int[,] t)
        {
            Console.WriteLine($"{t[2, 0]}| {t[2, 1]}| {t[2, 2]}");
        }
        //n) Escriba una serie de instrucciones para imprimir el contenido de t en formato tabular. Enliste los índices de columna como encabezados a lo largo de la parte superior, y enliste los índices de fila a la izquierda de cada fila.
        public void IncisoN(int[,] t)
        {
            Console.WriteLine($"{t[2, 0]}| {t[2, 1]}| {t[2, 2]}");
        }

    }
}

    }
}

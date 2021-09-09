using _03_ArreglosYListas.Models;
using System;
using System.Collections.Generic;

namespace _03_ArreglosYListas
{
    class Program
    {
        //Un arreglo, es una colección de datos
        static void Main(string[] args)
        {
            int[] numeros = new int[10] {1,2,3,4,5,6,7,8,9,0 };
            //Para acceder a uno de los elementos del arreglo:
            //Crear una variable por ejemplo
            //quiero el numero del arreglo numeros que se encuentra en
            //la posicion []

            //int numero = numeros[9];

            //Para recorrer un arreglo
            for (int i=0; i<numeros.Length; i++)
            {
                Console.WriteLine("iteración: " + i + " - " + numeros[i]);
            }
            //Una forma mas práctica de recorrer colecciones es la siguiente:
            //foreach tambien sirve para otro tipo de colecciones como son
            //las listas
            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }
            //La diferencia entre un arreglo y una lista, es que al arreglo
            //le damos una longitud inicial y los arreglos son mas 
            //rápidos que las listas
            //La lista es una clase de c# que regularmente implementa una interfaz.

            Console.WriteLine("**************************************************");
            //Implementamos una lista con la palabra reservada List
            List<int> lista = new List<int>() {1,2,3,4,5,6,7,8};
            //Para manipular elementos de la lista:
            lista.Add(9);
            lista.Add(0);
            lista.Remove(2);
            //la variable numero solo es visible dentro de su mismo bloque
            //asi que podemos tener la misma variable nombre en diferentes bloques.
            foreach (var numero in lista)
            {
                Console.WriteLine("Elemento: " + numero);
            }
            Console.WriteLine("**************************************************");
            //Lista de Clases
            List<Cerveza> cervezas = new List<Cerveza>() { new Cerveza("Indio", 10) };
            cervezas.Add(new Cerveza("Pacifico",500));
            //tambien se puede crear un objeto de la clase Cerveza
            Cerveza miller = new Cerveza("Miller", 600);
            //y se agrega el objeto creado al listado
            cervezas.Add(miller);
            //recorremos el listado
            foreach (var cerveza in cervezas)
            {
                Console.WriteLine("Cerveza: " + cerveza.Nombre);
            }

 
        }
    }
}

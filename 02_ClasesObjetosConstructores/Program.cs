using System;
using _02_ClasesObjetosConstructores.Models;

namespace _02_ClasesObjetosConstructores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Un objeto es la abstraccion de objetos del mundo real
            //Una clase es una plantilla para poder crear un objeto
            //La clase define que acciones y atributos tiene un objeto
            //La clase Bebida nos sirve para crear objetos tipo Bebida
            //El constructor nos obliga a recibir parámetros

            Bebida bebida = new Bebida("Coca Cola",1000);
            
            //Se llama al método Beberse
            //Beberse recibe un parámetro (cuanto se bebio)
            //y se ejecuta el calculo definido en el método Beberse
            
            bebida.Beberse(500);
            
            //Muestra la cantidad restante ene la bebida
            Console.WriteLine(bebida.Cantidad);

            //Creamos un objeto cerveza de la clase Cerveza
            Cerveza cerveza = new Cerveza("Pacifico",600);
            cerveza.Beberse(10);
            Console.WriteLine(cerveza.Cantidad);
        }
    }
}

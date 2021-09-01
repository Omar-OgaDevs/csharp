using System;

namespace _01_TiposDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numero = 255;
            //nemesis, al aceptar valores negativos el rango es: -128 a 127
            sbyte numNegativo = -128;

            int intNumero = -529767457;
            //nemesis, solo valores positivos
            uint uintNumero = 529767457;

            long numLargo = 31416784566613;
            //nemesis,ulong solo valores positivos

            //float es de 4bytes
            float numFlotante = 100.9f;
            
            //double es de 8bytes
            double numDouble = 3.141617;

            //decimal es de 16bytes
            //En palabras de Peter Golde, la m es por la siguiente consonante disponible en DeCiMaL
            decimal numDecimal = 3.14161711254515m;

            //char es de 2bytes admite un solo caracter en comillas simples ''
            char caracter = 'A';

            //strign es un tipo compuesto
            string caracteres = "ABCDEFGH...XYZ";

            //DateTime es una clase, por lo cual es ya un objeto
            DateTime fecha = DateTime.Now;
            Console.WriteLine(fecha);

            //booleano, true ó false
            bool siOno = true;

            //Los tipos nativos de c# como int, char, float, etc
            //se pueden inicializar como objetos y tienen sus métodos
            //a diferencia de java
            int numeroInt = new int();
            Console.WriteLine(numeroInt.ToString());

            //Para permitir valores null agregamos ?
            char? caracterX = null;

            //var es una palabra reservada y
            //no es como el var de JavaScript
            //var simplemente sirve para hacer variables
            //la variable por su nombre deberia representar su tipo de dato y lo que es.
            //var solo funciona dentro de los métodos. No puede ser un atributo.

            //var como string
            var nombre = "Omar";

            //var como int
            var velocidad = 75;

            //object es la base de todos los elementos de c# .Net
            //Se puede crear object con valor anónimo, es decir, 
            //no se necesita una clase para crearlo.
            object persona = new { nombre = "Omar", apellido = "Garcia" };
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ClasesObjetosConstructores.Models
{
    //Herencia: La clase Bebida es padre de esta clase Cerveza
    //Cerveza hereda los atributos y métodos publicos ó protegidos de Bebida 
    class Cerveza : Bebida
    {
        //Creamos en constructor de Cerveza
        //y con : base hace referencia al constructor de su padre.
        //Definimos que todas se llamen Cerveza y sean de 500ml
        public Cerveza(string Nombre, int Cantidad)
            : base(Nombre, Cantidad)
        {

        }
    }
}

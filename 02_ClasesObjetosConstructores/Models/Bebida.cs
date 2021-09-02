using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//el namesapce es el grupo al cual pertenece esta clase
//Bebida pertenece a Models
//Models pertenece a ClasesObjetsConstructores
//De esta manera se pueden crear objetos tipo bebida
//en otro lugar del proyecto(en algun otro grupo)
//se agrega usando: using ClasesObjetosConstructores.Models;
//en el grupo donde lo queramos usar.
namespace _02_ClasesObjetosConstructores.Models
{
    class Bebida
    {
        //public es el modificador de acceso
        //el modificador define hasta donde tiene alcanze el atributo
        //Nombre y Cantidad son los atributos
        //get, set se usan comunmente para serializar objetos y
        //permitir el acceso a los atributos de la clase.

        //private solo es accesible dentro de la misma clase        
        //protected solo pueden acceder las clases derivadas de
        //esta misma clase.

        //si se le quita el modificador public
        //automáticamente se le asigna el modificador internal
        //de esta manera el atributo no puede ser accedido desde otro dll.
        //los dll son paquetes compilados en c# los cuales sirven para
        //almacenar librerias, clases y funcionalidades encapsuladas.
        public string Nombre { get; set; }
        public int Cantidad { get; set; }

        //El constructor es un método y sirve para definir los atributos que necesita
        //el objeto para poder existir, en este ejemplo; Nombre y Cantidad
        //el constructor debe de tener el mismo nombre de la clase

        //Constructor y sus parámetros
        public Bebida(string Nombre, int Cantidad)
        {
            //Asignar los valores del constructor al objeto
            //this.Nombre=Nombre apunta al parametro Nombre del constructor
            //this.Cantidad=Cantidad apunta al parametro Cantidad del constructor
            this.Nombre = Nombre;
            this.Cantidad = Cantidad;
        }
        //Método Beberse, acción a realizar
        //En este método (Beberse) calcula cuanto bebiste (CuantoBebio)
        //restandole de la Cantidad inicial de la bebida (Cantidad)
        public void Beberse(int CuantoBebio)
        {
            //Se le resta CuantoBebio a la Cantidad inicial
            //this.Cantidad apunta al atributo de esta clase (Bebida)
            this.Cantidad -= CuantoBebio;       
        }

    }
}

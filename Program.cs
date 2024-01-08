using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checked
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //cheked:Verifica las operaciones arigmeticas y evita los
            //"desbordamientos aritmeticos" ya que estas imprimen numeros erroneos
            //Solo funciona con primitivos "int", "Long"
            //CHECKED();
            //CHECKEDABREVIADO();
            UNCHEKED();
        }

        static void CHECKED()
        {
            checked
            {
                int numero = int.MaxValue;
                int resultado = numero + 20;

                Console.WriteLine(resultado);
            }
        }
        static void CHECKEDABREVIADO()
        {
            //Se agrega delante de la expresion que se desea agregar 
            int numero = int.MaxValue;
            int resultado = checked(numero + 20);
            Console.WriteLine(resultado);
        }
        static void UNCHEKED()
        {
            //En este caso se utiliza si en la configuracion se asigna que aplique los "checked"
            //de forma automatica y se desea que no aplique en una sentencia en especifico.
            //Ahí es donde entra los uncheked
            int numero = int.MaxValue;
            int resultado = unchecked(numero + 20);
            Console.WriteLine(resultado);
        }

    }
}

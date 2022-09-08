using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Persona
{
    public class Program
    {
        static void Main(string[] args)
        { 
string nombre;
        byte edad;
        int telefono;
            Console.WriteLine("CUAL ES SU NOMBRE");
            nombre = Console.ReadLine();
            Console.WriteLine("digite su telefono");
            telefono = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite su edad");
            edad = Convert.ToByte(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("nombre:" + nombre);
            Console.WriteLine("telefono:" + telefono);
            Console.WriteLine("edad:" + edad);

            Console.ReadLine();

        }

    }
}

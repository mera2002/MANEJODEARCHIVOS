using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace compra_en_linea
{
    class Program
    {

        private static string getPath()
        {
            string menu1 = @"C:\compra_en_linea\archivo.text";
            return menu1;
         

        }
        static void MenuCompra()
        {
            
            Console.WriteLine("USB ");
            Console.WriteLine("Lapton ");
            Console.WriteLine("Mouse ");
            Console.WriteLine("Microfono ");
            Console.WriteLine("Teclado ");
            Console.WriteLine("Webcam ");
            Console.WriteLine("cables rj45 ");
            Console.WriteLine("Terminales ");
            
        }


        static void Menu()
        {
            //Console.Clear(); //permite limpiar la consola
            Console.WriteLine("COMPRA EN LINEA ");
            Console.WriteLine("                                             ");
            Console.WriteLine("Seleccion la operación a realizar: ");
            Console.WriteLine("1. Mostrar productos disponibles");
            Console.WriteLine("2. Comprar");
            Console.WriteLine("4. Mostrar listado de productos en existencia");
            Console.WriteLine("5. Salir");
            Console.Write("\nOpcion: ");
            var tmp = Console.ReadLine();
            if (tmp == "1")
            {
                MenuCompra();
            }
            else if (tmp == "2")
            {

             
            }
            else if (tmp == "3")

            {

            }
            else if (tmp == "4")

            {

            }
            else if (tmp == "5")

            {

            }

            else

            {
                Console.WriteLine("Debe eligir una opcion valida");

            }
        }
        static void Main(string[] args)
        {
            Program.Menu();
            {

            }
            TextWriter menu1;
            menu1 = new StreamWriter(@"C:\compra_en_linea\archivo.text");

          
            

            Console.ReadKey();
        }
    }
}

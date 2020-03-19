using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia0
{
    class Class1
    {


        public void BuscarPalabra()
        {
            string frase;
            Console.WriteLine("Ingrese una frase");
            frase = Console.ReadLine();

            string[] palabras = frase.Split();

            for (int x = 0; x <= palabras.Length - 1; x++)
            {

                if (palabras[x] == "fin") { Console.WriteLine("se encontro la palabra"); }


            }

        }

        public void pasarMayusculas()
        {

            string nombre;
            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();

            string[] palabras = nombre.Split();
            nombre = "";
            for (int x = 0; x <= palabras.Length - 1; x++)
            {

                palabras[x] = palabras[x].ToUpper();
                nombre = nombre + " " + palabras[x];

            }


            Console.WriteLine(nombre);

        }


        public void pasarMinusculas()
        {

            string nombre;
            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();

            string[] palabras = nombre.Split();
            nombre = "";
            for (int x = 0; x <= palabras.Length - 1; x++)
            {

                palabras[x] = palabras[x].ToLower();
                nombre = nombre + " " + palabras[x];

            }


            Console.WriteLine(nombre);

        }

        public void combinacionTeclas() {

            ConsoleKeyInfo keyInfo;

            do
            {
                keyInfo = Console.ReadKey();

            }

            while ((keyInfo.Modifiers & ConsoleModifiers.Control) == 0 && keyInfo.Key != ConsoleKey.F);


        }
        public void FrasesFin() {
            string frase;

            do
            {
                frase = Console.ReadLine();

            }
            while (!frase.Equals("fin"));


        }

        public void NombreYfin() {

            string nombre, frase;
            string[] cadena;
            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("hola {0}", nombre);

            Console.WriteLine("Ingrese una frase");
            frase = Console.ReadLine();
            cadena = frase.Split();

            if (cadena.Contains("fin"))
            {
                Console.WriteLine("la frase contiene la palabra Fin");


            }
            Console.ReadKey();


        }

    }


    }


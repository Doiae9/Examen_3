using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen3;

namespace Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            Libro cuatro_acuerdos = new Libro("Los 4 acuerdos","Miguel Ruiz Macías",1997);
            LibroNoFiccion Hornos = new LibroNoFiccion("Los hornos de hittler", "Holga Lengyel",1947,"WWII");
            LibroFiccion Anillos = new LibroFiccion("El señor de los anillos", "J.R.R.Tolkien", 1954, "Fantástico");

            Console.WriteLine("La información del primer libro es: ");
            cuatro_acuerdos.ImprimirInformacion();

            Console.WriteLine("La información del libro que no es de ficción es: ");
            Hornos.ImprimirInformacion();
            Console.WriteLine("Se ha alterado el tema");
            Hornos.EstablecerTema("Segunda guerra mundial");
            Hornos.ObtenerTema();

            Console.WriteLine("Esta es la información del libro de ficción");
            Anillos.ImprimirInformacion();
            Console.WriteLine("Se ha alterado el genero");
            Anillos.EstablecerGenero("Magia");
            Anillos.ObtenerGenero();

        }
    }
}

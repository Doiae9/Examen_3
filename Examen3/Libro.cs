using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen3
{
    public class Libro
    {
        protected string titulo;
        protected string autor;
        protected int anioPublicacion;
        

       public Libro() { }

        public Libro(string titulo, string autor, int anioPublicacion) 
        {
            this.titulo = titulo;
            this.autor = autor;
            this.anioPublicacion = anioPublicacion;
        }

        public void ImprimirInformacion() 
        {

            Console.WriteLine("Titulo: " + titulo);
            Console.WriteLine("Autor: " + autor);
            Console.WriteLine("Año de publicación: " + anioPublicacion);
        }
    }
}

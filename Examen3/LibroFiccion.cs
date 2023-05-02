using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen3
{
    public class LibroFiccion: Libro
    {
        protected string genero;

       public LibroFiccion(string titulo, string autor, int anioPublicacion,string genero): 
            base(titulo,autor,anioPublicacion) 
        {
            this.genero = genero;
        }
           
            
        public new void ImprimirInformacion() 
        {
            base.ImprimirInformacion();
            Console.WriteLine("Genero: "+ genero);

        }
        public void EstablecerGenero(string genero) 
        {
             this.genero = genero;
        }

        public string ObtenerGenero() {
            Console.WriteLine("Nuevo genero: "+ genero);
            return genero; }

    }
}

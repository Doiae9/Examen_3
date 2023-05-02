using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen3
{
    public class LibroNoFiccion: Libro
    {
        protected string tema;

        public LibroNoFiccion(string titulo, string autor, int anioPublicacion, string tema):
            base(titulo,autor,anioPublicacion) 
        {
            this.tema = tema;
           
        }
        public new void ImprimirInformacion() 
        {
            base.ImprimirInformacion();
            Console.WriteLine("Tema: " + tema);

        }
        public void EstablecerTema(string tema) 
        { 
            this.tema= tema;
        }

        public string ObtenerTema() {
            Console.WriteLine("Nuevo tema: " + tema);
            return tema; }

    }
}

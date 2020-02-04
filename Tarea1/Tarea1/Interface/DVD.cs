using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1.Interface
{
   public class DVD : IReproductores
    {
        private int Id { get; set; }
        private string Nombre { get; set; }

        public DVD(int Id , String Nombre)
        {
            this.Id = Id;
            this.Nombre = Nombre;
        }

        public void fw()
        {
            Console.WriteLine("Ejecutando FW " + Nombre);
            Console.WriteLine("------------------------");
        }
        public void play()
        {
            Console.WriteLine("Ejecutando Play " + Nombre);
            Console.WriteLine("------------------------");
        }

        public void rw()
        {
            Console.WriteLine("Ejecutando RW " + Nombre);
            Console.WriteLine("------------------------");
        }

        public void stop()
        {
            Console.WriteLine("Ejecutando Stop " + Nombre);
            Console.WriteLine("------------------------");
        }

    }
}

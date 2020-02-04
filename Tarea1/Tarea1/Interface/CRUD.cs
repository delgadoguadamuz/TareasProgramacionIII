using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1.Interface
{
    public class CRUD : ICRUD<IReproductores>
    {
        private List<IReproductores> Lista;

        public CRUD()
        {

            Lista = new List<IReproductores>();

        }

        public IReproductores buscar(int posicion)
        {
            Console.WriteLine("Buscando " + posicion);
            IReproductores reproductor = Lista.ElementAt(posicion);
            return reproductor;
        }

        public void eliminar(int posicion)
        {
            Console.WriteLine("Eliminando " + posicion);
            Lista.RemoveAt(posicion);
            
        }

        public void insertar(IReproductores item)
        {
            Console.WriteLine("Insertando");
            Lista.Add(item);
        }
    }
}

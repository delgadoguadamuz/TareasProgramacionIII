using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea1.Interface;

namespace Tarea1
{
    class Program
    {
        static void Main(string[] args)
        {
            IReproductores DVD = new DVD(0,"DVD1");
            IReproductores VHS = new VHS(1, "VHS1");
            IReproductores Netflix = new Netflix(3, "Netflix1");

            ICRUD<IReproductores> ListaReproductores = new CRUD();
            ListaReproductores.insertar(DVD);
            ListaReproductores.insertar(VHS);
            ListaReproductores.insertar(Netflix);

            ListaReproductores.buscar(0).play();
            ListaReproductores.buscar(0).fw();
            ListaReproductores.buscar(0).rw();
            ListaReproductores.buscar(0).stop();

            ListaReproductores.buscar(1).play();
            ListaReproductores.buscar(1).fw();
            ListaReproductores.buscar(1).rw();
            ListaReproductores.buscar(1).stop();

            ListaReproductores.buscar(2).play();
            ListaReproductores.buscar(2).fw();
            ListaReproductores.buscar(2).rw();
            ListaReproductores.buscar(2).stop();

            ListaReproductores.eliminar(0);
            ListaReproductores.eliminar(0);
            ListaReproductores.eliminar(0);

            IReproductores DVD1 = new DVD(0, "DVD2");
            IReproductores VHS1 = new VHS(1, "VHS2");
            IReproductores Netflix1 = new Netflix(3, "Netflix2");
            
            ListaReproductores.insertar(DVD1);
            ListaReproductores.insertar(VHS1);
            ListaReproductores.insertar(Netflix1);

            ListaReproductores.buscar(0).play();
            ListaReproductores.buscar(0).fw();
            ListaReproductores.buscar(0).rw();
            ListaReproductores.buscar(0).stop();

            ListaReproductores.buscar(1).play();
            ListaReproductores.buscar(1).fw();
            ListaReproductores.buscar(1).rw();
            ListaReproductores.buscar(1).stop();

            ListaReproductores.buscar(2).play();
            ListaReproductores.buscar(2).fw();
            ListaReproductores.buscar(2).rw();
            ListaReproductores.buscar(2).stop();

            Console.ReadKey();


        }
    }
}

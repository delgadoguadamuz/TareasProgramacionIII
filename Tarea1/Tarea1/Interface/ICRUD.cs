using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1.Interface
{
    public interface ICRUD<T>
    {
        void insertar(T item);
        void eliminar(int posicion);
        T buscar(int posicion);


    }
}

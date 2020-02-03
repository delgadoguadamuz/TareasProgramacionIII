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
            Reproductores reproductores = new Reproductores();

            reproductores.Play1();
            Console.ReadKey();

        }
    }
}

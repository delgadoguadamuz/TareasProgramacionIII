using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1.Interface
{
    public class Reproductores 
    {

        #region Atributos
        private string _play;
        private string _stop;
        private string _fw;
        private string _rw;

       
        #endregion

        #region Propiedades
        public string Play1 { get => _play; set => _play = value; }
        public string Stop1 { get => _stop; set => _stop = value; }
        public string Fw { get => _fw; set => _fw = value; }
        public string Rw { get => _rw; set => _rw = value; }
        #endregion


        #region Constructores
               
        public void Play(String play)
        {
            _play = play;
            Console.WriteLine("Ejecutando"+ play);
        }

        public void Stop(String stop)
        {
            _stop = stop;
            Console.WriteLine("Ejecutando" + stop);

        }

        public void FW(String fw)
        {
            _fw = fw;
            Console.WriteLine("Ejecutando" + fw);
        }


        public void RW(string rw)
        {
            _rw = rw;
            Console.WriteLine("Ejecutando" + rw);

        }
        #endregion

    }
}

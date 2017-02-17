using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlenussZKTeco1
{
    class DispositivoZK : zkemkeeper.CZKEMClass
    {   
        public string dispositivo { get; set; }
        public string nombre { get; set; } 
        public string IP { get; set; }
        public int Puerto { get; set; }
        public DateTime fecha_alta { get; set; }
        public DateTime ult_lectura { get; set; }

        public DispositivoZK()
        {

        }

        /// <summary> 
        /// Connects to the IP and Port that is especific </summary> 
        /// <remarks> 
        /// Longer comments can be associated with a type or member through 
        /// the remarks tag.</remarks> 
        public bool connect()
        {
            return this.Connect_Net(this.IP, this.Puerto);
        }
    }
}

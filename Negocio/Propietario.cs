using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Propietario
    {

        public string nombre { get; set; }
        public int numeroDocumento { get; set; }

        public Propietario() { }

        public Propietario(string nombre = "", int numeroDocumento = 0)
        {
            this.nombre = nombre;
            this.numeroDocumento = numeroDocumento;
        }
    }
}

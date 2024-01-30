using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet.Models
{
    public class ResumenEmpleados
    {
        public ResumenEmpleados()
        {
            this.Apellidos = new List<string>();
            this.SumaSalarial = 0;
            this.MediaSalarial = 0;
            this.Personas = 0;
        }

        public List<string> Apellidos { get; set; }
        public int SumaSalarial { get; set; }
        public int MediaSalarial { get; set; }
        public int Personas { get; set; }
    }
}
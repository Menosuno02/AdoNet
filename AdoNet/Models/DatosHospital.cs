using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet.Models
{
    public class DatosHospital
    {
        public DatosHospital()
        {
            DatosEmpleados = new List<EmpleadoHospital>();
            SumaSalarial = 0;
            MediaSalarial = 0;
            Empleados = 0;
        }

        public List<EmpleadoHospital> DatosEmpleados { get; set; }

        public int SumaSalarial { get; set; }

        public int MediaSalarial { get; set; }
        public int Empleados { get; set; }
    }
}
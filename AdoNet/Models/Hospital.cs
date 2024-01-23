using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet.Models
{
    public class Hospital
    {
        public Hospital(string codigoHospital, string nombre, string direccion, string telefono, string numCama)
        {
            CodigoHospital = codigoHospital;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            NumCama = numCama;
        }

        public string CodigoHospital { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string NumCama { get; set; }
    }
}
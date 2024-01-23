using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet.Models
{
    public class Empleado
    {
        public Empleado(int empNo, string apellido, string oficio, string direccion, string fechaAlta, int salario, int comision, int deptNo)
        {
            EmpNo = empNo;
            Apellido = apellido;
            Oficio = oficio;
            Direccion = direccion;
            FechaAlta = fechaAlta;
            Salario = salario;
            Comision = comision;
            DeptNo = deptNo;
        }

        public int EmpNo { get; set; }
        public string Apellido { get; set; }
        public string Oficio { get; set; }
        public string Direccion { get; set; }
        public string FechaAlta { get; set; }
        public int Salario { get; set; }
        public int Comision { get; set; }
        public int DeptNo { get; set; }
    }
}
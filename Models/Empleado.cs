using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoWebApiFinal.Models
{
    public class Empleado
    {
        [Key]
        public int EmpleadoId { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        [ForeignKey("Departamento")]
        public int DepartamentoId { get; set; }
        public Departamento Departamento { get; set; }
    }
}

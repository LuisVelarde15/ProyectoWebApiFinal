using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoWebApiFinal.Models
{
    public class Departamento
    {
        [Key]
        public int DepartamentoId { get; set; }
        public string Nombre { get; set; }
        public decimal Presupuesto { get; set; }
    }
}

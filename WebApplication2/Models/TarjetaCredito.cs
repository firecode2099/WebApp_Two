using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class TarjetaCredito
    {


        [Key]
        public int id { get; set; }
        public string Titular { get; set; }
        public string NumeroTarjeta { get; set; }
        public string FechaExpiracion { get; set; }
        public string cvv { get; set; }
    }
}

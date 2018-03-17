using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01.Models
{
    public class Sale
    {
        public int ID { get; set; }

        public string Descripcion { get; set; }

        public DateTime Fecha { get; set; }

        public double Monto { get; set; }

        public string Tipo { get; set; }
    }
}

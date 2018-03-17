using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab01.Models
{
    public class Person
    {
        public int ID { get; set; }

        public string Nombre { get; set; }

        public string Apellido1 { get; set; }

        public string Apellido2 { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string Telefono { get; set; }

        public List<Sale> ListaVentas { get; set; }

        public string Foto { get; set; }

        public static async Task<ObservableCollection<Person>> ObtenerPersonas()
        {
            ObservableCollection<Person> vloPersona = new ObservableCollection<Person>();
            vloPersona.Add(new Person()
            {
                ID = 1,
                Nombre = "Fernando",
                Apellido1 = "Angulo",
                Apellido2 = "Guido",
                FechaNacimiento = DateTime.Now,
                Telefono = "87832589",
                Foto = ""
            });

            vloPersona.Add(new Person()
            {
                ID = 1,
                Nombre = "Daniela",
                Apellido1 = "Apellido1",
                Apellido2 = "Apellido2",
                FechaNacimiento = DateTime.Now,
                Telefono = "87832589",
                Foto = ""
            });

            vloPersona.Add(new Person()
            {
                ID = 1,
                Nombre = "Juan cho",
                Apellido1 = "Apellido1",
                Apellido2 = "Apellido2",
                FechaNacimiento = DateTime.Now,
                Telefono = "87832589",
                Foto = ""
            });

            Thread.Sleep(4000);

            return vloPersona;
        }
    }
}

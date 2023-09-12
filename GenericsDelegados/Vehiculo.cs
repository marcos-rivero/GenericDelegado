using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDelegados
{
    internal class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public Vehiculo()
        {

        }
        public Vehiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Vehiculo
    {
        private int id;
        private string nombre;
        private string tipo;
        private string marca;
        private int year;


        //Encapsulacion
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public string Nombre
        {

            get { return nombre; }
            set { nombre = value; }
        }

        public string Marca
        {

            get { return marca; }
            set { marca = value; }

        }
        public int Year
        {

            get { return year; }
            set { year = value; }

        }

        
        
    }
}

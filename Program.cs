using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciacion

            Vehiculo  vehiculod1 = new Vehiculo();
            vehiculod1.Id = 6;
            vehiculod1.Nombre = "mustang";
            vehiculod1.Tipo = "Deportivo";
            vehiculod1.Marca = "Ford";
            vehiculod1.Year = 2015;

            Vehiculo vehiculo2 = new Vehiculo();
            vehiculo2.Id = 3;
            vehiculo2.Nombre = "mustang";
            vehiculo2.Tipo = "Deportivo";
            vehiculo2.Marca = "Ford";
            vehiculo2.Year = 2014;

            Vehiculo vehiculo3 = new Vehiculo();
            vehiculo3.Id = 5;
            vehiculo3.Nombre = "mustang";
            vehiculo3.Tipo = "Deportivo";
            vehiculo3.Marca = "Ford";
            vehiculo3.Year = 2019;

            Vehiculo vehiculo4 = new Vehiculo();
            vehiculo4.Id = 2;
            vehiculo4.Nombre = "mustang";
            vehiculo4.Tipo = "Deportivo";
            vehiculo4.Marca = "Ford";
            vehiculo4.Year = 2012;

            Vehiculo vehiculo5 = new Vehiculo();
            vehiculo5.Id = 9;
            vehiculo5.Nombre = "mustang";
            vehiculo5.Tipo = "Deportivo";
            vehiculo5.Marca = "Ford";
            vehiculo5.Year = 2012;

            Repovehiculo Rv = new Repovehiculo();

            Rv.Mostrarvehiculo(vehiculod1);

            Console.WriteLine("----------------------");

            Vehiculo[] vs = { vehiculod1, vehiculo2, vehiculo3, vehiculo4, vehiculo5 };

            Rv.ListarVehiculo(vs);

            Console.ReadKey();






        }
    }
}
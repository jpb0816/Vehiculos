using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Repovehiculo
    {

        public void ListarVehiculo(Vehiculo[] vh)
        {
            for(int i = 0; i < vh.Length; i++)
            {
                Console.WriteLine(vh[i].Id+" "+vh[i].Nombre+" "+vh[i].Tipo+" "+vh[i].Marca+" "+vh[i].Year);
            }
        }


        public void Mostrarvehiculo(Vehiculo carro)
        {
        Console.WriteLine(carro.Id+" "+carro.Tipo+" "+carro.Nombre+" "+carro.Marca+" "+carro.Year);

    }
    }
}


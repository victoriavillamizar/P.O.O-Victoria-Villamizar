using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN1
{
 partial class ReservaHotel
        {
            public double CalcularTotal()
            {
                double precio = 0;

                if (TipoHabitacion == "simple")
                    precio = 5000;
                else if (TipoHabitacion == "doble")
                    precio = 8000;
                else if (TipoHabitacion == "suite")
                    precio = 12000;

                return precio * CantidadNoches;
            }
        }
    }
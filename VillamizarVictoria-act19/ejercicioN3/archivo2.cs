using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN3
{
      partial class JuegoArcade
        {
            public bool SuperaRecord(int puntaje)
            {
                return puntaje > PuntajeMaximo;
            }
        }
    }

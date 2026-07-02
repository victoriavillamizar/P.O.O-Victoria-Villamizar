using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN3
{
    partial class JuegoArcade
    {
        /*3. Armar una clase parcial JuegoArcade.
        En el primer archivo, definir las propiedades NombreJuego, PuntajeMaximo, y
        NivelDificultad (de 1 a 5). Valores cargados desde consola
        En el segundo archivo, implementar un método que indique si un puntaje ingresado
        supera el récord o no.
        Desde Main, simular 4 partidas, mostrar qué jugador rompió el récord de su juego.*/
        private string nombreJuego;
        private int puntajeMaximo;
        private int nivelDificultad;

        public string NombreJuego
        {
            get { return nombreJuego; }
            set { nombreJuego = value; }
        }

        public int PuntajeMaximo
        {
            get { return puntajeMaximo; }
            set { puntajeMaximo = value; }
        }

        public int NivelDificultad
        {
            get { return nivelDificultad; }
            set
            {
                if (value >= 1 && value <= 5)
                    nivelDificultad = value;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN3
{
    class Computadora
    {
        /*3. Fábrica de Computadoras (Herencia y Constructores con base)
        Crear una clase base llamada Computadora que contenga los atributos Marca y
        MemoriaRAM (en GB). Definir un constructor que reciba estos dos valores obligatoriamente.
        Luego, definir dos clases derivadas de la clase base:
         Notebook: que añade el atributo propio TamanoPantalla (en pulgadas).
         Escritorio: que añade el atributo propio PotenciaFuente (en Watts).
        Cada una de estas clases derivadas debe poseer su propio constructor, el cual debe recibir
        tanto los atributos específicos como los de la clase base, transfiriendo estos últimos a la
        clase Computadora mediante el uso explícito de la palabra clave base. Instanciar un objeto
        de cada clase derivada en el Main y mostrar la totalidad de sus datos por consola.*/
        protected string marca;
        protected int memoriaRAM;
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public int MemoriaRAM
        {
            set { memoriaRAM = value; }
            get { return memoriaRAM; }
        }

        class Notebook : Computadora
        {
            private int tamañoPantalla;
            public int TamañoPantalla
            {
                set { tamañoPantalla = value; }
                get { return tamañoPantalla; }
            }
        }
        class Escritorio : Computadora
        {
            private int potenciaFuente;
            public int PtenciaFuente
            {
                set { potenciaFuente = value; }
                get { return potenciaFuente; }
            }
        }







        static void Main(string[] args)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleneDeTroya
{
    class Caballo
    {
        int capacidad, ocupacion;

        List<Griego> ocupantes = new List<Griego>();

        public Caballo (int capacidad)
        {
            this.capacidad = capacidad;
        }

        //GETTERS & SETTERS
        public int GetCapacidad()
        {
            return capacidad;
        }
        public void SetCapacidad(int capacidad)
        {
            this.capacidad = capacidad;
        }
        public int GetOcupacion()
        {
            return ocupacion;
        }
        public void SetOcupacion(int ocupacion)
        {
            this.ocupacion = ocupacion;
        }

        //METODOS

        public int Buscar(string nombre)
        {
            foreach (Griego ocupante in ocupantes)
            {
                if(ocupante.GetNombre() == nombre)
                {
                    int pos = ocupantes.IndexOf(ocupante);
                    return pos;
                }             
              

            }
            return -1;
        }

        public void MostrarGuerreroPosicion (int pos)
        {
            if (pos >= 0 && pos < ocupantes.Count)
            {
                ocupantes.ElementAt(pos).MostrarDatos();
            }
            else
            {
                Console.WriteLine("No es posible");
            }
        }
        public void MontarseEnCaballo (Griego ocupante)
        {
            ocupantes.Add(ocupante);
        }

    }
}

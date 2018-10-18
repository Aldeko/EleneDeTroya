using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleneDeTroya
{
    class Griego
    {
        private string nombre, herido, muerto;
        private int edad, fuerza;

        public Griego ()
        {
            this.nombre = "GriegoX";
            this.edad = 20;
            this.fuerza = 8;

        }
        public Griego (string nombre, int edad, int fuerza)
        {
            this.nombre = nombre;           
            this.edad = edad;
            this.fuerza = fuerza;
        }
        public string GetNombre()
        {
            return nombre;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string GetHerido()
        {
            return herido;
        }
        public void SetHerido(string herido)
        {
            this.herido = herido;
        }
        public string GetMuerto()
        {
            return muerto;
        }
        public void SetMuerto(string muerto)
        {
            this.muerto = muerto;
        }
        public int GetEdad()
        {
            return edad;
        }
        public void SetEdad(int edad)
        {
            this.edad = edad;
        }
        public int GetFuerza()
        {
            return fuerza;
        }
        public void SetFuerza(int fuerza)
        {
            this.fuerza = fuerza;
        }

        //METODOS

        public bool Retirarse(string herido)
        {
            if(herido=="herido")
            {
                MostrarMensaje();
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public void MostrarMensaje()
        {
            Console.WriteLine("Acción retirarse");
            Console.WriteLine("----------------");
            Console.WriteLine("Griego: Ulyses");
            Console.WriteLine("Edad: 28  Fuerza: 3");
            Console.WriteLine("Esta herido ==> RETIRADA");

        }
        public void MostrarDatos()
        {
            Console.WriteLine("Maaaaaaaaaaaaaaaaaaaaximuuuuuuuuus")
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleneDeTroya
{
    class Troyano
    {
        private string nombre, herido, muerto;
        private int edad, fuerza;

        public Troyano()
        {
           this.nombre="TroyanoX";
            this.edad = 18;
            this.fuerza = 10;
        }
        public Troyano(string nombre, int edad, int fuerza)
        {
            if (ComprobarEdad(edad)==false)
            {
                this.nombre = nombre;
                this.edad = 25;
                this.fuerza = 5;
            }
        }
        
        
        public string GetNombre()
        {
            return nombre;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
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
      
        public bool ComprobarEdad(int edad)
        {
            if (edad > 15 && edad < 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ComprobarFuerza(int f)
        {
            if (f >= 1 && f <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
            //return f >= 1 && f <= 10;
        }
       
        public bool Retirarse()
        {

            MostrarMensaje();
            return false;           
        }

        public void MostrarMensaje()
        {
            Console.WriteLine("Acción retirarse");
            Console.WriteLine("----------------");
            Console.WriteLine("Troyano: Paris");
            Console.WriteLine("Edad: 19  Fuerza: 10");
            Console.WriteLine("Esta herido ==> Los Guerreros Toyanos NUNCA se retiran");

        }
    }
}

using System;

namespace InyeccionDeDependencias
{
    class PC : IJugable
    {
        private string modelo { get; set; }

        public PC(string modelo)
        {
            this.modelo = modelo;
        }

        public void Jugar()
        {
            Console.WriteLine($"Hola soy tu PC: {modelo}");
        }
    }
}

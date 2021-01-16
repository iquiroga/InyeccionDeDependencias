using System;

namespace InyeccionDeDependencias
{
    public class Consola : IJugable
    {
        private string modelo { get; set; }        

        public Consola(string modelo)
        {
            this.modelo = modelo;
        }

        public void Jugar()
        {
            Console.WriteLine($"Estás jugando a la consola: {modelo}");
        }

    }
}

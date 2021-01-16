namespace InyeccionDeDependencias
{
    class Jugador
    {
        public string Nombre { get; private set; }
        private IJugable DispositivoJugable { get; set; }

        public Jugador(string nombre, IJugable dispositivoJugable)
        {
            Nombre = nombre;
            DispositivoJugable = dispositivoJugable;
        }

        public void Jugar()
        {
            DispositivoJugable.Jugar();
        }
    }
}

namespace InyeccionDeDependencias
{
    class Program
    {
        static void Main(string[] args)
        {
            IJugable dispositivo = new Consola(modelo: "PS4");
            IJugable dispositivo2 = new PC(modelo: "Pentium 5");

            Jugador jugador = new Jugador(nombre: "Ignacio", dispositivo);
            Jugador jugador2 = new Jugador(nombre: "Ignacio", dispositivo2);

            jugador.Jugar();
            jugador2.Jugar();
        }
    }
}

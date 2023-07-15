internal class Program
{
    private static void Main(string[] args)
    {
        Reproductor reproductor = new Reproductor();
        reproductor.Reproducir(); // Salida: "Reproducción iniciada."
        reproductor.Pausar(); // Salida: "Reproducción en pausa."
        reproductor.Detener(); // Salida: "Reproducción detenida."

        reproductor.SetEstado(new EstadoReproduciendo());
        reproductor.Reproducir(); // Salida: "El reproductor ya se encuentra reproduciendo."
        reproductor.Pausar(); // Salida: "Reproducción en pausa."
        reproductor.Detener(); // Salida: "Reproducción detenida."
    }
}
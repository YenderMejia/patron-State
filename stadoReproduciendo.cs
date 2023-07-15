// Estado concreto: Reproduciendo
public class EstadoReproduciendo : IEstadoReproductor
{
    public void Reproducir()
    {
        Console.WriteLine("El reproductor ya se encuentra reproduciendo.");
    }

    public void Pausar()
    {
        Console.WriteLine("Reproducción en pausa.");
    }

    public void Detener()
    {
        Console.WriteLine("Reproducción detenida.");
    }
}

// Estado concreto: Detenido
public class EstadoDetenido : IEstadoReproductor
{
    public void Reproducir()
    {
        Console.WriteLine("Reproducción iniciada.");
    }

    public void Pausar()
    {
        Console.WriteLine("No se puede pausar, el reproductor está detenido.");
    }

    public void Detener()
    {
        Console.WriteLine("El reproductor ya se encuentra detenido.");
    }
}

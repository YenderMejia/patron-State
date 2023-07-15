// Estado concreto: Pausado
public class EstadoPausado : IEstadoReproductor
{
    public void Reproducir()
    {
        Console.WriteLine("Reproducción reanudada.");
    }

    public void Pausar()
    {
        Console.WriteLine("El reproductor ya se encuentra en pausa.");
    }

    public void Detener()
    {
        Console.WriteLine("Reproducción detenida.");
    }
}
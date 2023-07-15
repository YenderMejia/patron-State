// Contexto: Reproductor
public class Reproductor
{
    private IEstadoReproductor estado;

    public Reproductor()
    {
        // Estado inicial
        estado = new EstadoDetenido();
    }

    public void SetEstado(IEstadoReproductor estado)
    {
        this.estado = estado;
    }

    public void Reproducir()
    {
        estado.Reproducir();
    }

    public void Pausar()
    {
        estado.Pausar();
    }

    public void Detener()
    {
        estado.Detener();
    }
}
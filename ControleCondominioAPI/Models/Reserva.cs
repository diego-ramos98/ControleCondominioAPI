namespace ControleCondominioAPI.Models;

public class Reserva
{
    public long IdReserva { get; set; }
    public int IdUsuarioReserva { get; set; }
    public int IdEspacoReserva { get; set; }
    public DateTime DataIncio { get; set; }
    public DateTime DataFim { get; set; }   
    public bool Liberado { get; set; }
    public DateTime DataAlteracao { get; set; }
    public long IdUsuarioALteracao { get; set; }
    public DateTime DataInclusao { get; set; }
    public long IdUsuarioInclusao { get; set; }
}
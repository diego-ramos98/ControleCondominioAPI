namespace ControleCondominioAPI.Models;

public class Comunicado
{
    public long IdComunicado { get; set; }
    public string? Texto {get; set;}
    public DateTime DataComunicada  { get; set; }
    public DateTime DataAlteracao { get; set; }
    public long IdUsuarioALteracao { get; set; }
    public DateTime DataInclusao { get; set; }
    public long IdUsuarioInclusao { get; set; }
}
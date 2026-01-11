namespace ControleCondominioAPI.Models;

public class Condominio
{
    public long IdCondominio { get; set; }
    public int IdUsuario { get; set; }
    public int QuantidadeApartamento { get; set; }
    public string? Logo { get; set; }
    public DateTime DataAlteracao { get; set; }
    public long IdUsuarioALteracao { get; set; }
    public DateTime DataInclusao { get; set; }
    public long IdUsuarioInclusao { get; set; }

}

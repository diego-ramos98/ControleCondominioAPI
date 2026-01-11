namespace ControleCondominioAPI.Models;

public class Apartamento
{
    public long IdAPartamento { get; set; }
    public int IdUsuario { get; set; }
    public bool Ativo { get; set; }
    public int Numero { get; set; }
    public int Andar { get; set; }
    public string? StatusDivida { get; set; }
    public DateTime DataAlteracao { get; set; }
    public long IdUsuarioALteracao { get; set; }
    public DateTime DataInclusao { get; set; }
    public long IdUsuarioInclusao { get; set; }
}
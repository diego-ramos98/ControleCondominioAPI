namespace ControleCondominioAPI.Models;

public class Usuario
{
    public long IdUsuario { get; set; }
    public int IdGrupoUsuario { get; set; }
    public string? Nome { get; set; }
    public string? Cpf { get; set; }
    public string? Email { get; set; }
    public string? Telefone { get; set; }
    public DateTime DataAlteracao { get; set; }
    public long IdUsuarioALteracao { get; set; }
    public DateTime DataInclusao { get; set; }
    public long IdUsuarioInclusao { get; set; }




}
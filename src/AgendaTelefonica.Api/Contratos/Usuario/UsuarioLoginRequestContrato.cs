namespace AgendaTelefonica.Api.Contratos.Usuario
{
    public class UsuarioLoginRequestContrato
    {
        public string Telefone { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
    }
}
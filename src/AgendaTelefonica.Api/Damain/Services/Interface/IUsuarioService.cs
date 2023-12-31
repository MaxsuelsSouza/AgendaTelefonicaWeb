using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgendaTelefonica.Api.Contratos.Usuario;

namespace AgendaTelefonica.Api.Damain.Services.Interface
{
    public interface IUsuarioService : IService<
    UsuarioRequestContrato,
    UsuarioResponseContrato,
    long
    >
    {
        Task<UsuarioLoginResponseContrato> Autenticar(UsuarioLoginRequestContrato usuarioLoginRequestContrato);
        Task<UsuarioResponseContrato> ObterPorNumero(string telefone);
    }
}
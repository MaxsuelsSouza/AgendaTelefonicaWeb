using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaTelefonica.Api.Contratos.Usuario
{
    public class UsuarioLoginResponseContrato
    {
        public long Id { get; set; }
        public string Telefone { get; set; } = string.Empty;
        public string Token { get; set; } = string.Empty;
    }
}
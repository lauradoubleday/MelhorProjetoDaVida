using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelhorProjetoDaVida.CODE.DTO
{
    class LoginDTO
    {
        private int cpf;
        private string email;
        private string senha;

        public int Cpf { get => cpf; set => cpf = value; }
        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelhorProjetoDaVida.CODE.DTO
{
    class CadastroDTO
    {
        private string nome;
        private int cpf;
        private string email;
        private string senha;

        public string Nome { get => nome; set => nome = value; }
        public int Cpf { get => cpf; set => cpf = value; }
        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }
    }
}

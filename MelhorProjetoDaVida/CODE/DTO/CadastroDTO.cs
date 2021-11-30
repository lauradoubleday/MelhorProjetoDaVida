using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelhorProjetoDaVida.CODE.DTO
{
    class CadastroDTO
    {
        private string Nome;
        private int CPF;
        private string Email;
        private string Senha;

        public string Nome1 { get => Nome; set => Nome = value; }
        public int CPF1 { get => CPF; set => CPF = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string Senha1 { get => Senha; set => Senha = value; }
    }
}

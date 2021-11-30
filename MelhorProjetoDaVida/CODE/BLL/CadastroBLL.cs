using MelhorProjetoDaVida.CODE.DAL;
using MelhorProjetoDaVida.CODE.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelhorProjetoDaVida.CODE.BLL
{
    class CadastroBLL
    {
        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "tbl_usuario";

        public void Inserir(CadastroDTO cadastroDTO)
        {
            string inserir = $"insert into {tabela} values(null,'{cadastroDTO.Nome1}','{cadastroDTO.CPF1}','{cadastroDTO.Email1}','{cadastroDTO.Senha1}')";
            conexao.ExecutarComando(inserir);
        }

        public DataTable Listar()     
        {
            string sql = $"select * from {tabela} order by id;";
            return conexao.ExecutarConsulta(sql);
        }

        public void Editar(CadastroDTO cadastroDTO)
        {
            string alterar = $"update {tabela} set nome = '{cadastroDTO.Nome1}', '{cadastroDTO.Email1}', '{cadastroDTO.Senha1}' where CPF = '{cadastroDTO.CPF1}';";
            conexao.ExecutarComando(alterar);
        }


        public void Excluir(CadastroDTO cadastroDTO)
        {
            string excluir = $"delete from {tabela} where CPF = '{cadastroDTO.CPF1}';";
            conexao.ExecutarComando(excluir);
        }
    }
}

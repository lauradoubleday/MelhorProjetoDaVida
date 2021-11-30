using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MelhorProjetoDaVida.CODE.BLL;
using MelhorProjetoDaVida.CODE.DTO;


namespace MelhorProjetoDaVida.Ui
{
    public partial class Frm_Cadastro : Form
    {
       CadastroBLL CadastroBLL = new CadastroBLL();
       CadastroDTO CadastroDTO = new CadastroDTO();

        public Frm_Cadastro()
        {
            InitializeComponent();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            CadastroDTO.Nome = txtNome.Text;
            CadastroDTO.Cpf = int.Parse(txtCpf.Text);
            CadastroDTO.Email = txtEmail.Text;
            CadastroDTO.Senha = txtSenha.Text;

            CadastroBLL.Inserir(CadastroDTO);

            MessageBox.Show("Cadastrado com sucesso!", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtNome.Clear();
            txtCpf.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
        }


        private void Frm_Cadastro_Load(object sender, EventArgs e)
        {
            dgvCadastro.DataSource = CadastroBLL.Listar();
        }

        private void dgvCadastro_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtCpf.Text = dgvCadastro.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dgvCadastro.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtEmail.Text = dgvCadastro.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSenha.Text = dgvCadastro.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {


            CadastroDTO.Nome = txtNome.Text;
            CadastroDTO.Cpf = int.Parse(txtCpf.Text);
            CadastroDTO.Email = txtEmail.Text;
            CadastroDTO.Senha = txtSenha.Text;

            CadastroBLL.Editar(CadastroDTO);

            MessageBox.Show("Alterado com sucesso!", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CadastroBLL.Listar();

            txtNome.Clear();
            txtCpf.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            CadastroDTO.Nome = txtNome.Text;
            CadastroDTO.Cpf = int.Parse(txtCpf.Text);
            CadastroDTO.Email = txtEmail.Text;
            CadastroDTO.Senha = txtSenha.Text;

            CadastroBLL.Excluir(CadastroDTO);

            MessageBox.Show("Excluido com sucesso!", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CadastroBLL.Listar();

            txtNome.Clear();
            txtCpf.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
        }
    }
}
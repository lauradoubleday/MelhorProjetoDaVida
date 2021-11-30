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
    public partial class Frm_Dados : Form
    {

        DadosBLL DadosBLL = new DadosBLL();
        DadosDTO DadosDTO = new DadosDTO();
        public Frm_Dados()
        {
            InitializeComponent();

        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            DadosDTO.Id = int.Parse(txtid.Text);
            DadosDTO.Lhckd = txtLhckd.Text;
            DadosDTO.L04 = txtL04.Text;
            DadosDTO.D05 = txtD05.Text;

            DadosBLL.Inserir(DadosDTO);

            MessageBox.Show("Cadastrado com sucesso!", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtid.Clear();
            txtLhckd.Clear();
            txtL04.Clear();
            txtD05.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            DadosDTO.Id = int.Parse(txtid.Text);
            DadosDTO.Lhckd = txtLhckd.Text;
            DadosDTO.L04 = txtL04.Text;
            DadosDTO.D05 = txtD05.Text;

            DadosBLL.Editar(DadosDTO);

            MessageBox.Show("Alterado com sucesso!", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DadosBLL.Listar();

            txtid.Clear();
            txtLhckd.Clear();
            txtL04.Clear();
            txtD05.Clear();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DadosDTO.Id = int.Parse(txtid.Text);
            DadosDTO.Lhckd = txtLhckd.Text;
            DadosDTO.L04 = txtL04.Text;
            DadosDTO.D05 = txtD05.Text;

            DadosBLL.Excluir(DadosDTO);

            MessageBox.Show("Excluido com sucesso!", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DadosBLL.Listar();

            txtid.Clear();
            txtLhckd.Clear();
            txtL04.Clear();
            txtD05.Clear();
        }
    }
}

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

namespace MelhorProjetoDaVida
{
    public partial class Frm_Login : Form
    {
        LoginDTO LoginDTO = new LoginDTO();
        LoginBLL LoginBLL = new LoginBLL();
        public Frm_Login()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginDTO.Cpf = int.Parse(txtCpf.Text);
            LoginDTO.Email = txtEmail.Text;
            LoginDTO.Senha = txtSenha.Text;

            if (LoginBLL.RealizarLogin(LoginDTO) == true)
            {
                Frm_Login Frm_Login = new Frm_Login();
                Frm_Login.ShowDialog();
            }

           else
            {
                {
                    MessageBox.Show("Confira se há algo errado.", "Há algo errado.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

           

        }
    }
}
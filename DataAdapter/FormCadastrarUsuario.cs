using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAdapter
{
    public partial class FormCadastrarUsuario : Form
    {
        public FormCadastrarUsuario()
        {
            InitializeComponent();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            if (txt_Id.Text.Trim().Length == 0 || txt_Nome.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            int num;
            if (!int.TryParse(txt_Id.Text, out num))
            {
                MessageBox.Show("O campo \"Id:\" deve ser um valor númerico");
                return;
            }

            if (GerenciaBanco.CadastrarUsuario(num, txt_Nome.Text))
                MessageBox.Show("Usuario cadastrado com sucesso!");
            else
                MessageBox.Show("Foi encontrado algum erro no ato de cadastrar usuario!");
        }
    }
}

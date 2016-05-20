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
    public partial class Banco : Form
    {
        public Banco()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastrarUsuario form = new FormCadastrarUsuario();
            form.MdiParent = this;
            form.Show();
        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultaTodosUsuarios form = new FormConsultaTodosUsuarios();
            form.MdiParent = this;
            form.Show();
        }

        private void porNomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultaUsuarioPorNome form = new FormConsultaUsuarioPorNome();
            form.MdiParent = this;
            form.Show();
        }

        private void porCódigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultaUsuarioPorCodigo form = new FormConsultaUsuarioPorCodigo();
            form.MdiParent = this;
            form.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultaUsuarioAutomatico form = new FormConsultaUsuarioAutomatico();
            form.MdiParent = this;
            form.Show();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormCadastrarCompra form = new FormCadastrarCompra();
            form.MdiParent = this;
            form.Show();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormConsultaCompra form = new FormConsultaCompra();
            form.MdiParent = this;
            form.Show();
        }

        private void imagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFoto form = new FormFoto();
            form.MdiParent = this;
            form.Show();
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroAluno form = new FormCadastroAluno();
            form.MdiParent = this;
            form.Show();
        }
    }
}

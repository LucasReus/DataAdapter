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
    public partial class FormConsultaUsuarioPorCodigo : Form
    {
        Label lbl_nome;
        public FormConsultaUsuarioPorCodigo()
        {
            InitializeComponent();
        }

        private void txt_codigo_Enter(object sender, EventArgs e)
        {
            if (txt_codigo.Text == "Entre com o código")
                txt_codigo.Clear();
        }

        private void txt_codigo_Leave(object sender, EventArgs e)
        {
            if (txt_codigo.Text.Length == 0)
                txt_codigo.Text = "Entre com o código";
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            string nome = GerenciaBanco.getNomePorCodigo(txt_codigo.Text);
            if (lbl_nome != null)
                this.Controls.Remove(lbl_nome);
            lbl_nome = new Label();
            lbl_nome.Text = nome;
            lbl_nome.Location = new Point(50,50);
            this.Controls.Add(lbl_nome);
        }
    }
}

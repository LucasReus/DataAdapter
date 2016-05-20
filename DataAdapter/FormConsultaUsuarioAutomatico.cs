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
    public partial class FormConsultaUsuarioAutomatico : Form
    {
        public FormConsultaUsuarioAutomatico()
        {
            InitializeComponent();
        }

        private void FormConsultaUsuarioAutomatico_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bancoDataSet.Usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter.Fill(this.bancoDataSet.Usuario);

        }

        private void btn_filtro_Click(object sender, EventArgs e)
        {
            if (txt_filtro.Text.Length == 0)
                usuarioBindingSource.Filter = "";
            else
                usuarioBindingSource.Filter = "nome = '" + txt_filtro.Text + "'";
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            usuarioTableAdapter.Update(bancoDataSet.Usuario);
        }
    }
}

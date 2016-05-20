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
    public partial class FormConsultaUsuarioPorNome : Form
    {
        public FormConsultaUsuarioPorNome()
        {
            InitializeComponent();
        }

        private void cmb_nome_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Up || e.KeyData == Keys.Down || e.KeyData == Keys.Left || e.KeyData == Keys.Right|| cmb_nome.Text.Length == 0)
                return;

            string[] nomes = GerenciaBanco.getListaUsuario(cmb_nome.Text).ToArray();
            cmb_nome.DroppedDown = nomes.Length > 0 ? true : false;
            cmb_nome.Items.Clear();
            cmb_nome.Items.AddRange(nomes);
            cmb_nome.SelectionStart = cmb_nome.Text.Length;
        }
    }
}

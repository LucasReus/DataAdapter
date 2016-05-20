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
    public partial class FormConsultaTodosUsuarios : Form
    {
        public FormConsultaTodosUsuarios()
        {
            InitializeComponent();
            dtv_usuarios.DataSource = GerenciaBanco.getUsuarios();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            dtv_usuarios.DataSource = GerenciaBanco.getUsuarios();
        }
    }
}

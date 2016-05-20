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
    public partial class FormCadastrarCompra : Form
    {
        public FormCadastrarCompra()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            GerenciaBanco.CadastrarCompra(int.Parse(txt_id.Text), txt_item.Text, int.Parse(txt_quantidade.Text), int.Parse(txt_iduser.Text));
        }
    }
}

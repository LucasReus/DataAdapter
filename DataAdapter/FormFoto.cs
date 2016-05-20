using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.IO;

namespace DataAdapter
{
    public partial class FormFoto : Form
    {
        public FormFoto()
        {
            InitializeComponent();
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            if (d.ShowDialog() == DialogResult.OK)
            {
                GerenciaBanco.adicionarImagem(d.FileName);
            }
        }

        private void btn_carregar_Click(object sender, EventArgs e)
        {
            MemoryStream[] foto = new MemoryStream[2];
            foto = GerenciaBanco.getImagens();
            foreach (MemoryStream item in foto)
            {
                pic_foto.Image = Image.FromStream(item);
                MessageBox.Show("Pressione ok!");
            }
        }
    }
}

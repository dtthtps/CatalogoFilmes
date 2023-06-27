using CatalogoFilmes.Controller;
using CatalogoFilmes.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogoFilmes.View
{
    public partial class TelaCadastroFilme : Form
    {
        public TelaCadastroFilme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Filme.NomeFilme = txt_Nomefilme.Text;
            Filme.EstreiaFilme = txt_estreiafilme.Text;
            Filme.DuracaoFilme = txt_duracaofilme.Text;
            Filme.CategoriaFilme = cmb_categoria.Text;



            FilmeController filmeController = new FilmeController();
            filmeController.CadastrarFilme();
        }
    }
}

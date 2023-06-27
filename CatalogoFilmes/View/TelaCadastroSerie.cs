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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace CatalogoFilmes.View
{
    public partial class TelaCadastroSerie : Form
    {
        public TelaCadastroSerie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Serie.NomeSerie = txt_NomeSERIE.Text;
            Serie.EstreiaSerie = txt_estreiaSERIE.Text;
            Serie.TemporadaSerie = txt_duracaoSERIE.Text;
            Serie.CategoriaSerie = cmb_categoriaSERIE.Text;
            SerieController seriecontroller = new SerieController();
            seriecontroller.CadastrarSerie();
        }
    }
}

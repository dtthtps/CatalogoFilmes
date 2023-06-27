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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaCadastroFilme tela = new TelaCadastroFilme();
            tela.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TelaCadastroSerie tela = new TelaCadastroSerie();
            tela.Show();
        }
    }
}

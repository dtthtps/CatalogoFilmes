using CatalogoFilmes.Model;
using CatalogoFilmes.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoFilmes.Controller
{
    internal class SerieController
    {
        public void CadastrarSerie()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("inserirS", cn);
            cmd.CommandType = CommandType.StoredProcedure;



            try
            {
                cmd.Parameters.AddWithValue("@nomeS", Serie.NomeSerie);
                cmd.Parameters.AddWithValue("@estreiaS", Serie.EstreiaSerie);
                cmd.Parameters.AddWithValue("@categoriaS", Serie.CategoriaSerie);
                cmd.Parameters.AddWithValue("@temporadaSerie", Serie.TemporadaSerie);



                SqlParameter nv = cmd.Parameters.Add("@idS", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();



                var resposta = MessageBox.Show("Serie cadastrado com sucesso." + "Deseja cadastrar outra Série?",
                    "Novo registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resposta == DialogResult.Yes)
                {
                    TelaCadastroSerie TelaSerie = new TelaCadastroSerie();
                    TelaSerie.Show();
                }
                else
                {
                    TelaCadastroSerie TelaSerie = new TelaCadastroSerie();
                    TelaSerie.Show();






                }
            }




            catch (Exception)
            {
                throw;
            }






        }

    }
}

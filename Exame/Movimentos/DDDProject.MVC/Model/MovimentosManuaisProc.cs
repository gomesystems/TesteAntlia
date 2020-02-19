using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DDDProject.MVC.Model
{
    public class MovimentosManuaisProc
    {     //consxão local
        string connectionString = "data source=DESKTOP-L6MG1RO\\SQLEXPRESS;initial catalog=Antlia_DB;integrated security=True;";
        
        public IEnumerable<MovimentosManuais> GetAllMovimentosManuaiss()
        {
            try
            {
                List<MovimentosManuais> lstMovimentosManuais = new List<MovimentosManuais>();
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("prSelecionaMOVIMENTO_MANUAL", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        MovimentosManuais MovimentosManuais = new MovimentosManuais();
                        lstMovimentosManuais.Add(MovimentosManuais);
                    }
                    con.Close();
                }
                return lstMovimentosManuais;
            }
            catch
            {
                throw;
            }
        }
        //insert
        // protected void btnSave_Click(object sender, EventArgs e, MovimentosManuais par)
        // {
        public int AddMovimentosManuais(MovimentosManuais par)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("prInserirMovimentosManuais", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@COD_PRODUTO", par.COD_PRODUTO);
                    cmd.Parameters.AddWithValue("@COD_COSIF", par.COD_COSIF);
                    cmd.Parameters.AddWithValue("@DAT_ANO", par.DAT_ANO);
                    cmd.Parameters.AddWithValue("@DAT_MES", par.DAT_MES);
                    cmd.Parameters.AddWithValue("@NUM_LANCAMENTO", par.NUM_LANCAMENTO);
                    cmd.Parameters.AddWithValue("@VAL_VALOR", par.VAL_VALOR);
                    cmd.Parameters.AddWithValue("@DES_DESCRICAO", par.DES_DESCRICAO);
                    cmd.Parameters.AddWithValue("@DAT_MOVIMENTO", par.DAT_MOVIMENTO);
                    cmd.Parameters.AddWithValue("@COD_USUARIO", par.COD_USUARIO);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                return 1;
            }
            catch
            {
                throw;
            }
        }
     

    }
}
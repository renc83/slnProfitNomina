using slnProfitNomina.Entidades;
using slnProfitNomina.SysFunciones;
using System.Data;
using System.Data.SqlClient;

namespace slnProfitNomina.Data
{
	public class dListContratos
	{
		public List<eContratos> ListarContratos(string codempresa)
		{
			List<eContratos> Listado = new List<eContratos>();
			SqlConnection txtGp = new SqlConnection();
			try
			{
				txtGp = ConexionSQL.AbreConexion();
				SqlCommand cmd = new SqlCommand("pl_GBListadoContratos", txtGp);
				cmd.Parameters.AddWithValue("@COD_EMPRESA", codempresa);
				cmd.CommandType = CommandType.StoredProcedure;
				SqlDataReader dr;
				dr = cmd.ExecuteReader();
				while (dr.Read())
				{
					Listado.Add(new eContratos
					{						
						des_cont = dr["des_cont"].ToString(),
						co_cont  = dr["co_cont"].ToString()
					});
				}
				txtGp.Close();
			}
			catch (Exception exp)
			{
				MessageBox.Show(exp.Message);
			}

			return Listado;
		}
	}
}

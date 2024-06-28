using slnProfitNomina.Entidades;
using slnProfitNomina.SysFunciones;
using System.Data;
using System.Data.SqlClient;

namespace slnProfitNomina.Data
{
	public class dEmpresasNomina_S
	{
		public List<eEmpresasNomina> BuscarEmpresasNomina(string UsuarioProfit) {
			List<eEmpresasNomina> Listado = new List<eEmpresasNomina>();
			string sProducto = "NOMI";
			SqlConnection txtGp = new SqlConnection();

			try
			{
				txtGp = ConexionSQL.AbreConexion();
				SqlCommand cmd = new SqlCommand("pConsultarUsuarioAccesos", txtGp);
				cmd.Parameters.AddWithValue("@sCod_Usuario", UsuarioProfit);
				cmd.Parameters.AddWithValue("@sProducto", sProducto);
				cmd.CommandType = CommandType.StoredProcedure;
				SqlDataReader dr;
				dr = cmd.ExecuteReader();
				while (dr.Read())
				{
					Listado.Add( new eEmpresasNomina{
					 cod_empresa= dr["cod_empresa"].ToString(),
					 desc_empresa= dr["desc_empresa"].ToString(),
					 co_mapa= dr["co_mapa"].ToString()
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

using slnProfitNomina.SysFunciones;
using System.Data;
using System.Data.SqlClient;

namespace slnProfitNomina.Data
{
	public class dCargaBasesdeDatos
	{
		public List<string> BuscaBasesdeDatos() { 
			List<string> listBD = new List<string>();
			SqlConnection txtGp = new SqlConnection();
			try
			{
				txtGp = ConexionSQL.AbreConexion();
				SqlCommand cmd = new SqlCommand("select name from master.sys.databases", txtGp);
				cmd.CommandType = CommandType.Text;


				SqlDataReader dr;
				dr = cmd.ExecuteReader();
				while (dr.Read())
				{
					listBD.Add(dr["name"].ToString());
				}

			}
			catch (Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
			return listBD;
		}
	}
}

using slnProfitNomina.SysFunciones;
using System.Data;
using System.Data.SqlClient;

namespace slnProfitNomina.Data
{
	public class dValidaPassword
	{
		public Boolean ValidaPassword(string usuario,string password) { 
			Boolean Valida=false;
			SqlConnection txtGp = new SqlConnection();
			int resultado= 0;
			try
			{
				txtGp = ConexionSQL.AbreConexion();
				SqlCommand cmd = new SqlCommand("pAutenticarUsuario", txtGp);
				cmd.Parameters.AddWithValue("@sUsuario", usuario);
				cmd.Parameters.AddWithValue("@sPassword", password);
				cmd.CommandType = CommandType.StoredProcedure;
				resultado = cmd.ExecuteNonQuery();
				SqlDataReader dr;
				dr = cmd.ExecuteReader();
				while (dr.Read())
				{
					resultado = Convert.ToInt32(dr[0].ToString());
				}
				txtGp.Close();
			}
			catch (Exception exp)
			{
				MessageBox.Show(exp.Message,"Baltico Consultores");
			}
			Valida = resultado == 0 ? false : true;
			return Valida;
		}
	}
}

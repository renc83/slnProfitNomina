using slnProfitNomina.Entidades;
using slnProfitNomina.SysFunciones;
using System.Data;
using System.Data.SqlClient;

namespace slnProfitNomina.Data
{
	public class dListNominas_S
	{
		public List<eNominaList> ListarNominas(eFiltroNominas Filtro)
		{
			List<eNominaList> Listado = new List<eNominaList>();
			SqlConnection txtGp = new SqlConnection();
			try
			{
				txtGp = ConexionSQL.AbreConexion();
				SqlCommand cmd = new SqlCommand("pl_GBListadoNominas", txtGp);
				cmd.Parameters.AddWithValue("@COD_EMPRESA", Filtro.cod_empresa);
				cmd.Parameters.AddWithValue("@DCONTRATO", Filtro.co_contDesde);
				cmd.Parameters.AddWithValue("@HCONTRATO", Filtro.co_contHasta);
				cmd.Parameters.AddWithValue("@FECHAINI", Filtro.fec_ini);
				cmd.Parameters.AddWithValue("@FECHAFIN", Filtro.fec_fin);
				cmd.CommandType = CommandType.StoredProcedure;
				SqlDataReader dr;
				dr = cmd.ExecuteReader();
				while (dr.Read())
				{
					Listado.Add(new eNominaList
					{
						co_gennomi =Convert.ToInt32(dr["co_gennomi"].ToString()),
						des_gennomi = dr["des_gennomi"].ToString(),
						co_cont = (dr["co_cont"].ToString()),
						fec_ini = Convert.ToDateTime(dr["fec_ini"]).ToString("dd/MM/yyyy"),
						fec_fin = Convert.ToDateTime(dr["fec_ini"]).ToString("dd/MM/yyyy"),
						fec_emis = Convert.ToDateTime(dr["fec_emis"]).ToString("dd/MM/yyyy"),
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

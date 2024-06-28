using DocumentFormat.OpenXml.Office.Word;
using slnProfitNomina.Entidades;
using slnProfitNomina.SysFunciones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnProfitNomina.Data
{
	public class dDetNominaxls_S
	{
		public DataTable DetNominaxls(eFiltroNominaDet Filtro) {
			DataTable dt = new DataTable("Datos");
			SqlConnection txtGp = new SqlConnection();
			try
			{
				txtGp = ConexionSQL.AbreConexion();
				SqlCommand cmd = new SqlCommand("pl_GBDetNomina_xls", txtGp);
				cmd.Parameters.AddWithValue("@COD_EMPRESA", Filtro.cod_empresa);
				cmd.Parameters.AddWithValue("@CO_GENNOMI", Filtro.co_gennomi);
				cmd.CommandType = CommandType.StoredProcedure;

				SqlDataAdapter returnVal = new SqlDataAdapter(cmd);
				returnVal.Fill(dt);
				returnVal.Dispose();
				txtGp.Close();
			}
			catch (Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
			return dt;
		}
	}
}

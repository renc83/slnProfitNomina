using System;
using System.Data.SqlClient;
using slnProfitNomina.Entidades;

namespace slnProfitNomina.SysFunciones
{
	public class ConexionSQL
	{
		public static SqlConnection AbreConexion()
		{
			string strID		= clsStaticConectionSQL.UsuarioID;
			string strPassword  = clsStaticConectionSQL.Password;
			string strDatabase  = clsStaticConectionSQL.DatabaseName;
			string strSource    = clsStaticConectionSQL.ServerName;
			try
			{
				SqlConnection SqlC = new SqlConnection("Data Source=" + strSource + ";Initial Catalog=" + strDatabase + ";user ID = " + strID + ";Password=" + strPassword + "");
				SqlC.Open();
				return SqlC;
			}
			catch (Exception Ex)
			{
				return null;
			}
		}

		public static SqlConnection AbreConexionEmpresa()
		{
			string strID = clsStaticConectionSQL.UsuarioID;
			string strPassword = clsStaticConectionSQL.Password;
			string strDatabase = clsStaticConectionSQL.DatabaseEmpresa;
			string strSource = clsStaticConectionSQL.ServerName;
			try
			{
				SqlConnection SqlC = new SqlConnection("Data Source=" + strSource + ";Initial Catalog=" + strDatabase + ";user ID = " + strID + ";Password=" + strPassword + "");
				SqlC.Open();
				return SqlC;
			}
			catch (Exception Ex)
			{
				return null;
			}
		}
	}
}

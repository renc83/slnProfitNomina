using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnProfitNomina.SysFunciones
{
	public  class cConectividad
	{
		SqlConnection connection = new SqlConnection();
		string m_Server;    // Nombre del Sevidor a Conectar
		string m_Catalog;   // Nombre de la Base de datos
		string m_UserId;    // Nombre de Usuario
		string m_Passw;     // Clave de Usuario
		int m_IniWin;     // Clave de Usuario
		string m_CommandText; // Nombre de Sentecia de SQL 
		SqlConnection m_Conexion;
		SqlDataReader m_Command;
		CommandType m_CommandType;

		public cConectividad(string Server, string Catalog)
		{
			this.Server = Server;
			this.Catalog = Catalog;
			this.IniWin = 1;
		}

		public cConectividad(string Server, string Catalog, string UserId, string Passw)
		{
			this.Server = Server;
			this.Catalog = Catalog;
			this.UserId = UserId;
			this.Passw = Passw;
			this.IniWin = 0;

		}

		public SqlConnection Conexion    // La Propiedad Servidor
		{
			get
			{
				return m_Conexion;
			}
			set
			{
				m_Conexion = value;
			}
		}

		public string Server    // La Propiedad Servidor
		{
			get
			{
				return m_Server;
			}
			set
			{
				m_Server = value;
			}
		}

		public string Catalog    // La Propiedad Catalog
		{
			get
			{
				return m_Catalog;
			}
			set
			{
				m_Catalog = value;
			}
		}

		public string UserId    // La Propiedad UserId
		{
			get
			{
				return m_UserId;
			}
			set
			{
				m_UserId = value;
			}
		}
		public string Passw    // La Propiedad Passw
		{
			get
			{
				return m_Passw;
			}
			set
			{
				m_Passw = value;
			}
		}
		public int IniWin    // La Propiedad Inicio de Sesion de Windows
		{
			get
			{
				return m_IniWin;
			}
			set
			{
				m_IniWin = value;
			}
		}

		private string GetConnectionString()
		{
			// To avoid storing the connection string in your code, 
			// you can retrieve it from a configuration file, using the 
			// System.Configuration.ConfigurationSettings.AppSettings property 
			if (m_IniWin == 1)
			{
				return "Data Source=" + m_Server + ";Initial Catalog=" + m_Catalog + ";"
					+ "Integrated Security=SSPI;";
			}
			else
			{
				return "Data Source=" + m_Server + ";Initial Catalog=" + m_Catalog + ";"
					+ "User ID=" + m_UserId + ";Password=" + m_Passw + ";Persist Security Info=True";
			}
		}

		public void OpenSqlConnection()
		{

			string connectionString = GetConnectionString();

			{
				try
				{

					if (connection.ConnectionString == "")
						connection.ConnectionString = connectionString;

					if (connection.State == ConnectionState.Open)
						connection.Close();

					connection.Open();
					m_Conexion = connection;
				}
				catch (Exception e)
				{
					MessageBox.Show(e.Message, "Error de Conexion");
					Conexion = null;
				}
			}
		}

		public void CloseSqlConnection()
		{
			connection.Close();
			connection.Dispose();
		}

		public string CommandText    // Sentencia de SQL
		{
			get
			{
				return m_CommandText;
			}
			set
			{
				m_CommandText = value;
			}
		}

		public SqlDataReader RecordSet    // Recordset
		{
			get
			{
				return m_Command;
			}
			set
			{
				m_Command = value;
			}
		}

		public CommandType CommandType
		{
			get
			{
				return m_CommandType;
			}
			set
			{
				m_CommandType = value;
			}
		}

		public void OpenSqlCommand()
		{

			string CommandText = m_CommandText;

			{
				try
				{

					SqlCommand cmd = new SqlCommand();

					cmd.CommandText = m_CommandText;
					cmd.CommandType = m_CommandType;
					cmd.Connection = Conexion;
					RecordSet = cmd.ExecuteReader();



				}
				catch (Exception e)
				{
					MessageBox.Show(e.Message, "Error Abriendo RecordSet");
					RecordSet = null;
				}
			}
		}
		public void ProbarConexion()
		{
			string connectionString = GetConnectionString();
			{
				try
				{

					if (connection.ConnectionString == "")
						connection.ConnectionString = connectionString;

					if (connection.State == ConnectionState.Open)
						connection.Close();

					connection.Open();
					m_Conexion = connection;
					MessageBox.Show("La prueba de conexión fue satisfactoria", "Prueba de conexión", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				catch (Exception e)
				{
					MessageBox.Show("Error de conexión: " + e.Message, "Prueba de conexión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ;
					Conexion = null;
				}
			}
		}
	}
}

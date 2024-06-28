using slnProfitNomina.Entidades;
using slnProfitNomina.SysFunciones;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace slnProfitNomina
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			clsDataJson data = new clsDataJson();
			cEncripta DesEncripta = new cEncripta();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			string RutaJson = Environment.CurrentDirectory + "\\appconfig.json";
			ApplicationConfiguration.Initialize();

			if (!File.Exists(RutaJson))
			{
				Application.Run(new frmConfiguracion());
			}
			else
			{
				try
				{
					string json = File.ReadAllText(RutaJson);
					data = JsonSerializer.Deserialize<clsDataJson>(json);
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Error de Inicialización JSON.{ex.Message}");
				}

				if (String.IsNullOrEmpty(data.ServidorSQL.ServerName))
				{
					Application.Run(new frmConfiguracion());
				}
				else
				{

					clsStaticConectionSQL.ServerName = DesEncripta.descifra(data.ServidorSQL.ServerName);
					clsStaticConectionSQL.DatabaseName = DesEncripta.descifra(data.ServidorSQL.DatabaseName);
					clsStaticConectionSQL.UsuarioID = DesEncripta.descifra(data.ServidorSQL.UsuarioID);
					clsStaticConectionSQL.Password = DesEncripta.descifra(data.ServidorSQL.Password);
					Application.Run(new frmUserLogin());
				}
			}
		}
	}
}
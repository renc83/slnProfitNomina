﻿namespace slnProfitNomina.SysFunciones
{
	public class cEncripta
	{
		public string cifra(string vtxt)
		{
			string result = string.Empty;
			byte[] encryted = System.Text.Encoding.Unicode.GetBytes(vtxt);
			result = Convert.ToBase64String(encryted);
			return result;
		}

		public string descifra(string vtxt)
		{
			string result = string.Empty;
			byte[] decryted = Convert.FromBase64String(vtxt);
			result = System.Text.Encoding.Unicode.GetString(decryted);
			return result;
		}
	}
}

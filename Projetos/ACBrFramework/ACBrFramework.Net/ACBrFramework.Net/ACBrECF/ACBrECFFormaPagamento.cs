﻿namespace ACBrFramework
{
	public sealed class ACBrECFFormaPagamento
	{
		public string Indice { get; set; }

		public string Descricao { get; set; }

		public bool PermiteVinculado { get; set; }

		public decimal Total { get; set; }
	}
}
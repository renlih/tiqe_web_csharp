using System.ComponentModel.DataAnnotations;

public enum InvestimentType{
	[Display(Name="Poupança")]POUPANCA = 1,
	[Display(Name="Previdência Privada")]PREVIDENCIA = 2,
	[Display(Name="Ações")]ACOES = 3,
	[Display(Name="Tesouro Direto")]TESOURO = 4,
	[Display(Name="CDB")]CDB = 5,
	[Display(Name="CDI")]CDI = 6,
	[Display(Name="LCI")]LCI = 7,
	[Display(Name="RDB")]RDB = 8,
	[Display(Name="Debêntures")]DEBENTURES = 9,
	[Display(Name="Fundos de Investimento")]FUNDOS = 10,
	[Display(Name="Clubes de Investimento")]CLUBES = 11,
	[Display(Name="Ouro")]OURO = 12,
	[Display(Name="Outro")]OUTRO = 999
}
using System.ComponentModel.DataAnnotations;

public enum Frequency{
	[Display(Name="Mensal")]MENSAL = 1,
	[Display(Name="Diário")]DIARIO = 2,
	[Display(Name="Semanal")]SEMANAL = 3,
	[Display(Name="Quinzenal")]QUINZENAL = 4,
	[Display(Name="Única vez")]UNICO = 5,
	[Display(Name="Bimestral")]BIMESTRAL = 6,
	[Display(Name="Trimestral")]TRIMESTRAL = 7,
	[Display(Name="Semestral")]SEMESTRAL = 8,
	[Display(Name="Anual")]ANUAL = 9
	
}
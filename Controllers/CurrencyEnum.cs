using System.ComponentModel.DataAnnotations;

public enum Currency{
	[Display(Name="R$")]BRL,
	[Display(Name="US$")]USD,
	[Display(Name="C$")]CAD,
	[Display(Name="€")]EUR,
	[Display(Name="£")]GBP,
	[Display(Name="Outra")]OUTRO = 999
	
}
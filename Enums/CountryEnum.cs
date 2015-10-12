using System.ComponentModel.DataAnnotations;

public enum Country{
	[Display(Name="Brasil")]BRA,
	[Display(Name="Canadá")]CAN,
	[Display(Name="Estados Unidos")]USA,
	[Display(Name="Outro")]OUTRO = 999
}
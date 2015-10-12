using System.ComponentModel.DataAnnotations;

public enum AccountType{
	[Display(Name="Conta Corrente")]CC = 1,
	[Display(Name="Conta Poupança")]POUPANCA = 2,
	[Display(Name="Conta Investimento")]INVESTIMENTO = 3
}
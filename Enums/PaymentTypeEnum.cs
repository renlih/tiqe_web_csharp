using System.ComponentModel.DataAnnotations;

public enum PaymentType 
{
	[Display(Name="Cartão de Crédito")]CARTAO = 1,
	[Display(Name="Débito em conta")]DEBITO = 2,
	[Display(Name="Transferência bancária")]TRANSFERENCIA = 3,
	[Display(Name="Boleto")]BOLETO = 4,
	[Display(Name="Dinheiro")]DINHEIRO = 5,
	[Display(Name="Financiamento")]FINANCIAMENTO = 6,
	[Display(Name="Outra")]OUTRO = 99 
	
}
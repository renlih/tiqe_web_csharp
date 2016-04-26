using System.ComponentModel.DataAnnotations;

public enum IncomeType
{
	[Display(Name="Salário")]SALARIO = 1,
	[Display(Name="Pensão")]PENSAO = 2,
	[Display(Name="Aluguel")]ALUGUEL = 3,
	[Display(Name="Mesada")]MESADA = 4,
	[Display(Name="Rede social")]REDESOCIAL = 5,
	[Display(Name="Doação")]DOACAO = 6,
	[Display(Name="Vendas")]VENDA = 7,
	[Display(Name="Freelance")]FREELANCE = 8,
	[Display(Name="Outro")]OUTRO = 999
}
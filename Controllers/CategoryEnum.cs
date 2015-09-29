using System.ComponentModel;
using System.Reflection;
using System;
using System.ComponentModel.DataAnnotations;

public enum Category
{
	[Display(Name="Habitação")]HABITACAO = 1, 
	
	[Display(Name="Transporte")]TRANSPORTE = 2,
	
	[Display(Name="Saúde")]SAUDE = 3,
	
	[Display(Name="Educação")]EDUCACAO = 4,
	
	[Display(Name="Impostos")]IMPOSTOS = 5,
	
	[Display(Name="Alimentação")]ALIMENTACAO = 6,
	
	[Display(Name="Cuidados Pessoais")]CUIDADOSPESSOAIS = 7,
	
	[Display(Name="Manutenção")]MANUTENCAO = 8, 
	
	[Display(Name="Lazer")]LAZER = 9,
	
	[Display(Name="Vestuário")]VESTUARIO = 10,
	
	[Display(Name="Outros")]OUTROS = 999
}
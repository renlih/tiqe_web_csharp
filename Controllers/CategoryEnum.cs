using System.ComponentModel;
using System.Reflection;
using System;

public enum Category
{
	[DescriptionAttribute("Habitação")]HABITACAO = 1, 
	
	[DescriptionAttribute("Transporte")]TRANSPORTE = 2,
	
	[DescriptionAttribute("Saúde")]SAUDE = 3,
	
	[DescriptionAttribute("Educação")]EDUCACAO = 4,
	
	[DescriptionAttribute("Impostos")]IMPOSTOS = 5,
	
	[DescriptionAttribute("Alimentação")]ALIMENTACAO = 6,
	
	[DescriptionAttribute("Cuidados Pessoais")]CUIDADOSPESSOAIS = 7,
	
	[DescriptionAttribute("Manutenção")]MANUTENCAO = 8, 
	
	[DescriptionAttribute("Lazer")]LAZER = 9,
	
	[DescriptionAttribute("Vestuário")]VESTUARIO = 10,
	
	[DescriptionAttribute("Outros")]OUTROS = 999
}
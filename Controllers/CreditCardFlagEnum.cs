using System.ComponentModel.DataAnnotations;

public enum CreditCardFlag{
	[Display(Name="Visa")]VISA = 1,
	[Display(Name="MasterCard")]MASTER = 2,
	[Display(Name="American Express")]AMEX = 3,
	[Display(Name="Diners Club")]DINERS = 4,
	[Display(Name="Hiper")]HIPER = 5,
	[Display(Name="Hipercard")]HIPERCARD = 6,
	[Display(Name="Discover")]DISCOVER = 7,
	[Display(Name="Aura")]AURA = 8,
	[Display(Name="Cabal")]CABAL = 9,
	[Display(Name="Sorocred")]SOROCRED = 10,
	[Display(Name="Sicredi")]SICREDI = 11,
	[Display(Name="Cooper Card")]COOPER = 12,
	[Display(Name="Avista")]AVISTA = 13,
	[Display(Name="Bandeira Mais")]MAIS = 14,
	[Display(Name="UnionPay Internacional")]UNIONPAY = 15,
	[Display(Name="Elo")]ELO = 16,
	[Display(Name="Agiplan")]AGIPLAN = 17,
	[Display(Name="Credz")]CREDZ = 18,
	[Display(Name="JCB")]JCB = 19,
	[Display(Name="BNDES")]BNDES = 20,
	[Display(Name="Outro")]OUTRO = 999
	
	
}
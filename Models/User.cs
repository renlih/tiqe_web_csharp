using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity.EntityFramework;

namespace tiqe_web.Models
{
	public class User : IdentityUser
	{
                public int Id_TiqeUser {get;}
                
                [StringLength(300)]
                public string Picture {get; set;}
                
                [Required]
                [StringLength(20)]
                public string FirstName {get; set;}
                
                [Required]
                [StringLength(20)]
                public string LastName {get; set;}
                
                [Required]
                [StringLength(100)]
                public string Email {get; set;}
                
                [Required]
                [StringLength(20)]
                public string Pass {get; set;}
                
                public DateTime Birthday {get; set;}
                
                [Required]
                public bool UseTerms {get; set;}
                
                public bool Status {get; set;}
                
                public bool FirstLogin {get; set;}
                
                public string Language {get;}
                
                public bool SendLogError {get; set;}
                
                public DateTime RegisterDate {get;}
                
                public DateTime ModifyDate {get; set;}	
	}
	
}
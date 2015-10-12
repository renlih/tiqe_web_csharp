using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;

namespace tiqe_web.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public int Id {get;}
        public string Picture{get; set;}
        [RequiredAttribute]
        public string FirstName{get; set;}
        [RequiredAttribute]
        public string LastName{get; set;}
        [RequiredAttribute]
        public string Email{get; set;}
        [RequiredAttribute]
        public string Pass {get; set;}
        public DateTime Birthday{get; set;}
        [RequiredAttribute]
        public bool UseTerms{get; set;}
        public bool Status {get; set;}
        public bool FirstLogin {get; set;}
        public string Language {get;}
        public bool SendLogError{get; set;}
        public DateTime RegisterDate {get;}
        public DateTime ModifyDate {get; set;}
        
    }
}

using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace tiqe_web.Models
{
    [Table("TB_User")]
    public class User
	{
        public int TiqeUserId { get; set; }
        
        [StringLength(300)]
        public string Picture { get; set; }
        
        [Required]
        [StringLength(20)]
        public string FirstName { get; set; }
        
        [Required]
        [StringLength(20)]
        public string LastName { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Email { get; set; }
        
        [Required]
        [StringLength(20)]
        [MaxLength(20, ErrorMessage="Password must be between 6 and 20 characters"),MinLength(6)] 
        public string Pass { get; set; }
        
        public DateTime Birthday { get; set; }
        
        [Required]
        public bool UseTerms { get; set; }
        
        public bool Status { get; set; }
        
        public bool FirstLogin { get; set; }
        
        public string Language { get; set; }
        
        public bool SendLogError { get; set; }
        
        [Timestamp]
        public DateTime RegisterDate { get; set; }

        [Timestamp]
        public DateTime ModifyDate { get; set; }
        
        public virtual List<User> Users { get; set; }
    }
}
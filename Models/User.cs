using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace tiqe_web.Models
{
    [Table("TB_User")]
    public class User
	{
        [Column("ID_TiqeUser")]
        public int Id { get; set; }
        
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
        public string Pass { get; set; }
        
        public DateTime Birthday { get; set; }
        
        [Required]
        public bool UseTerms { get; set; }
        
        public bool Status { get; set; }
        
        public bool FirstLogin { get; set; }
        
        public string Language { get; set; }
        
        public bool SendLogError { get; set; }
        
        public DateTime RegisterDate { get; set; }

        public DateTime ModifyDate { get; set; }	
	}
    
    public class UserNewsletter 
    {
        public int ID_UserNewsletter { get; set; }
        public int ID_TiqeUser { get; set; }
        public bool Receiver { get; set; }
        public DateTime ReceiverRegisterDate { get; set; }
        public DateTime ModifyDate { get; set; }
    }
	
}
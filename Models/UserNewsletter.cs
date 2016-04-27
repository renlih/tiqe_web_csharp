using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tiqe_web.Models
{
    [Table("TB_UserNewsletter")]
    public class UserNewsletter 
    {
        [Key()]
        public int UserNewsletterId { get; set; }
        
        [Required]
        public int TiqeUserId { get; set; }
        
        public bool Receiver { get; set; }
        
        [Timestamp]
        public DateTime ReceiverRegisterDate { get; set; }
        
        [Timestamp]
        public DateTime ModifyDate { get; set; }
        
        [ForeignKey("TiqeUserId")]
        public User User { get; set; }
        
    }
	
}
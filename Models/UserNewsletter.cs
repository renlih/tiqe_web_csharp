using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace tiqe_web.Models
{
    [Table("TB_UserNewsletter")]
    public class UserNewsletter 
    {
        public int UserNewsletterId { get; set; }
        public User TiqeUserId { get; set; }
        public bool Receiver { get; set; }
        public DateTime ReceiverRegisterDate { get; set; }
        public DateTime ModifyDate { get; set; }
    }
	
}
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.Entity;
using Microsoft.Extensions.Logging;
using tiqe_web.Models;

namespace tiqe_web.DAO
{
    public class UserNewsletterDAO
	{
		  
        private readonly TiqeDbContext _context;
        
        //ver para que serve isso
        private readonly ILogger _logger;
        
        //ver para que serve isso
        /*public UsersNewsletterDAO(TiqeDbContext context, ILoggerFactory loggerFactory){
            _context = context;
            _logger = loggerFactory.CreateLogger("UsersNewsletterDAO");
        }*/
        
        public void AddUserNewsletter(UserNewsletter userNewsletter){
            _context.UsersNewsletter.Add(userNewsletter);
            _context.SaveChanges();
        }
        
        public void UpdateUserNewsletter(int UserNewsletterId, UserNewsletter userNewsletter)
        {
            _context.UsersNewsletter.Update(userNewsletter);
            _context.SaveChanges();
        }
        
        public void DeleteUserNewsletter(int UserNewsletterId){
            var entity = _context.UsersNewsletter.First(t => t.UserNewsletterId == UserNewsletterId);
            _context.UsersNewsletter.Remove(entity);
            _context.SaveChanges();
        }
        
        public UserNewsletter GetUserNewsletter(int UserNewsletterId){
            return _context.UsersNewsletter.First(t => t.UserNewsletterId == UserNewsletterId);
        }
        
        public List<UserNewsletter> GetUsersNewsletter(){
            return _context.UsersNewsletter.OrderByDescending(userNewsletter => EF.Property<DateTime>(userNewsletter, "UpdatedTimestamp")).ToList();
        }
	}	
}


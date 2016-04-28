using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.Entity;
using Microsoft.Extensions.Logging;
using tiqe_web.Models;

namespace tiqe_web.DAO
{
    public class UserDAO
	{
		  
        private readonly TiqeDbContext _context;
        
        //ver para que serve isso
        private readonly ILogger _logger;
        
        //ver para que serve isso
        /*public UsersDAO(TiqeDbContext context, ILoggerFactory loggerFactory){
            _context = context;
            _logger = loggerFactory.CreateLogger("UsersDAO");
        }*/
        
        public void AddUser(User user){
            _context.Users.Add(user);
            _context.SaveChanges();
        }
        
        public void UpdateUser(int TiqeUserId, User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }
        
        public void DeleteUser(int TiqeUserId){
            var entity = _context.Users.First(t => t.TiqeUserId == TiqeUserId);
            _context.Users.Remove(entity);
            _context.SaveChanges();
        }
        
        public User GetUser(int TiqeUserId){
            return _context.Users.First(t => t.TiqeUserId == TiqeUserId);
        }
        
        public List<User> GetUsers(){
            return _context.Users.OrderByDescending(user => EF.Property<DateTime>(user, "UpdatedTimestamp")).ToList();
        }
	}	
}


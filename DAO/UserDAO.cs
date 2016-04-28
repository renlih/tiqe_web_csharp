using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.Entity;
using tiqe_web.Models;

namespace tiqe_web.DAO
{
    public class UserDAO
	{
		  
        private readonly TiqeDbContext _context;
        
        public UserDAO(TiqeDbContext context){
            _context = context;
        }
        
        public void AddUser(User user){
            _context.Users.Add(user);
            _context.SaveChanges();
        }
        
        public void UpdateUser(int TiqeUserId, User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }
        
        public void DeleteUser(int TiqeUserId)
        {
            var entity = _context.Users.First(t => t.TiqeUserId == TiqeUserId);
            _context.Users.Remove(entity);
            _context.SaveChanges();
        }
        
        public User GetUser(int TiqeUserId)
        {
            return _context.Users.First(t => t.TiqeUserId == TiqeUserId);
        }
        
        public IList<User> GetUsers()
        {
            return _context.Users.OrderByDescending(user => EF.Property<DateTime>(user, "UpdatedTimestamp")).ToList();
        }
        
        public IList<User> GetStatusUsers(bool status)
        {
            var find = from user in _context.Users 
                       where user.Status == status
                       select user;
            return find.ToList();
        }
        
        public IList<User> GetFirstLoginUsers(bool firstLogin)
        {
            var find = from user in _context.Users 
                       where user.FirstLogin == firstLogin
                       select user;
            return find.ToList();
        }
        
        public IList<User> GetSendLogErrorUsers(bool sendLogError)
        {
            var find = from user in _context.Users 
                       where user.SendLogError == sendLogError
                       select user;
            return find.ToList();
        }
        
        //fazer ainda:
        //lista de aniversariantes do mês
        //lista dos usuários que fizeram o último login há mais de 1 mês Ou data a ser determinada
        //
        
	}	
}


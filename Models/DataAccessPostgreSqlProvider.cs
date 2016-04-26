using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.Entity;
using Microsoft.Extensions.Logging;

namespace tiqe_web.Models
{
    public class DataAccessPostgreSqlProvider : IDataAccessProvider
    {
        private readonly TiqeDbContext _context;
        private readonly ILogger _logger;
        
        public DataAccessPostgreSqlProvider(TiqeDbContext context, ILoggerFactory loggerFactory){
            _context = context;
            _logger = loggerFactory.CreateLogger("DataAccessPostgreSqlProvider");
        }
        
        //melhorar daqui para baixo, de modo que as demais classes herdem dessa
        //e sobrecrevam. Todos vao ter isso.
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
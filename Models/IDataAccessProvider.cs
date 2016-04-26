using System.Collections.Generic;

namespace tiqe_web.Models
{
    
    public interface IDataAccessProvider
    {
       //melhorar isso aqui para ficar mais genérico, pois
       //outras classes vão usar
       void AddUser(User user);
       void UpdateUser(int TiqeUserId, User user);
       void DeleteUser(int TiqeUserId);
       User GetUser(int TiqeUserId);
       List<User> GetUsers();  
    }
}

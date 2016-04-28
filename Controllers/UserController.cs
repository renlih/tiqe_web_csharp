using Microsoft.AspNet.Mvc;
using System;
using tiqe_web.DAO;
using tiqe_web.Models;
using Microsoft.Extensions.Logging;

namespace tiqe_web.Controllers
{
	public class UserController : Controller
	{
        public IActionResult Index()
        {
            TiqeDbContext context = new TiqeDbContext();
            
            UserDAO dao = new UserDAO(context);
            
            User user = new User()
            {
                Picture = "https://plus.google.com/u/0/me?tab=mX",
                FirstName = "Giselle",
                LastName = "Tavares",
                Email = "gitavares@hotmail.com",
                Pass = "123456",
                Birthday = DateTime.Parse("10/11/1980"),
                UseTerms = true,
                Status = false,
                FirstLogin = false,
                Language = "pt-Br",
                SendLogError = true,
                RegisterDate = DateTime.Now,
                ModifyDate = DateTime.Now,
                LastLogin = DateTime.Now     
            };
            
            dao.AddUser(user);
            dao.GetUser(user.TiqeUserId);
            //ver o que quer mostrar do usuário: foto + login (email) + primeiro nome + segundo nome
            return View();
        }


    }
}
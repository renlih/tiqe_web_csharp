using Microsoft.AspNet.Mvc;
using System;
using tiqe_web.DAO;
using tiqe_web.Models;

namespace tiqe_web.Controllers
{
	public class UserNewsletterController : Controller
	{
        public IActionResult Index()
        {
            TiqeDbContext context = new TiqeDbContext();
            
            UserNewsletterDAO dao = new UserNewsletterDAO(context);
            
            UserNewsletter userNewsletter = new UserNewsletter()
            {
                UserNewsletterId = 1,
                TiqeUserId = 1,
                Receiver = true,
                ReceiverRegisterDate = DateTime.Now,
                ModifyDate = DateTime.Now    
            };
            
            dao.AddUserNewsletter(userNewsletter);
            //ver o que quer mostrar do usuário: foto + login (email) + primeiro nome + segundo nome
            return View();
        }


    }
}
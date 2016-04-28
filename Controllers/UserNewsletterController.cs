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
            UserNewsletterDAO dao = new UserNewsletterDAO();
            
            UserNewsletter usuarioNewsletter = new UserNewsletter()
            {
                TiqeUserId = 1,
                Receiver = true,
                ReceiverRegisterDate = DateTime.Now,
                ModifyDate = DateTime.Now    
            };
            
            dao.AddUserNewsletter(usuarioNewsletter);
            //ver o que quer mostrar do usuário: foto + login (email) + primeiro nome + segundo nome
            return View();
        }


    }
}
using Microsoft.AspNet.Mvc;
using tiqe_web.DAO;

namespace tiqe_web.Controllers
{
	public class UserController : Controller
	{
        public IActionResult Index()
        {
            UsersDAO dao = new UsersDAO();
            //ver o que quer mostrar do usuário: foto + login (email) + primeiro nome + segundo nome
            return View();
        }


    }
}
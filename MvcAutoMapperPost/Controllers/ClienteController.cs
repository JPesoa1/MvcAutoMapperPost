using Microsoft.AspNetCore.Mvc;
using MvcAutoMapperPost.Models;
using MvcAutoMapperPost.Repositories;

namespace MvcAutoMapperPost.Controllers
{
    public class ClienteController : Controller
    {

        private ClienteRepository repo;

        public ClienteController(ClienteRepository repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            Cliente cliente= repo.GetCliente();
            return View(cliente);
        }
    }
}

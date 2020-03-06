using crmall.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace crmall.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
       

        [HttpGet("{id}")]
        public async Task<ActionResult<ClienteViewModel>> GetTodoItem(long id)
        {

            Console.WriteLine("Opaa");
            return null;
        }

        [HttpPost]
        public async Task<ActionResult<ClienteViewModel>>Cadastrar(ClienteViewModel cliente)
        {
            //salvar app

            return null;

        }

    }
}
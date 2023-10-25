using AgendaDeAulas.Models;
using AgendaDeAulas.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AgendaDeAulas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessoresController : ControllerBase
    {
        // GET: api/<ProfessoresController>
        [HttpGet]
        public async Task<IEnumerable<Professor>> Get()
        {
            return await new ProfessorRepository().GetProfessores();  
        }        
    }
}

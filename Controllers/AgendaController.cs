using AgendaDeAulas.Models;
using AgendaDeAulas.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AgendaDeAulas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgendaController : ControllerBase
    {
        // POST api/<AgendaController>
        [HttpPost]
        public async Task Post([FromBody] Agenda novaAgenda)
        {
            AgendaRepository agendaRepository = new AgendaRepository();

            await agendaRepository.AgendaAula(novaAgenda);
        }        
    
        // GET: api/<AgendaController>
        [HttpGet]
        public async Task<IEnumerable<Aula>> Get()
        {
            return await new AgendaRepository().GetAgenda();  
        }       
        
        // DELETE: api/<AgendaController>
        [HttpDelete]
        public async Task Delete([FromBody] int id)
        {
            AgendaRepository agendaRepository = new AgendaRepository();

            await agendaRepository.DeletaAula(id);
        }  

    }
}

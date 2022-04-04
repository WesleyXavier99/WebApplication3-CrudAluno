using Microsoft.AspNetCore.Mvc;
using WebApplication3.ViewModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        // GET: api/<AlunoController>
        [HttpGet]
        public IEnumerable<string> Get( )
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<AlunoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AlunoController>
        [HttpPost]
        public string Post([FromBody] AlunoViewModel aluno)
        {
            //validar nome e turno
            if (!aluno.ValidaNome())
            {
                return "O nome do aluno não é válido!";
            }

            //validar matricula
            if (!aluno.ValidaMat() )
            {
                return "A matricula do aluno não é válida!";
            }

            //validar turno
            if (!aluno.ValidaTurno())
            {
                return "O turno do aluno não é válido!";
            }

            return "Aluno foi cadastrado com sucesso!";

        }

        // PUT api/<AlunoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AlunoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

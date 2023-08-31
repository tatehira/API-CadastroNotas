using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Taerefas.Context;
using Taerefas.Dados;

namespace Taerefas.RegasNegocio
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefasController : ControllerBase
    {
        private readonly DadoContext _context;

        public TarefasController(DadoContext context)
        {
            _context = context;
        }

        [HttpGet("GetTarefa")]
        public async Task<ActionResult<Dado>> GetTarefa(int id)
        {
            Dado getId = await _context.Dados.FindAsync(id);
            
            if(getId == null)
                return NotFound("Id não encontrado!");

            return Ok(getId);
        }

        [HttpPost("CreateTarefa")]
        public async Task<ActionResult<Dado>> CreateTarefa(string assunto, string descricao)
        {
            if (assunto == null)
                return BadRequest("Preencha o campo assunto!");

            if (descricao == null)
                return BadRequest("Preencha o campo descrição!");

            Dado dado = new Dado()
            {
                Assunto = assunto,
                Descricao = descricao,
                DataAtual = DateTime.Now,
            };

            await _context.Dados.AddAsync(dado);

            await _context.SaveChangesAsync();

            return Ok(dado);
        }

        [HttpPut("Edit")]
        public async Task<ActionResult<Dado>> EditTarefa(Dado dado)
        {
            Dado getId = await _context.Dados.FindAsync(dado.Id);

            if (getId == null)
                return NotFound("Não foi localizado tarefas com esse identificador!");

            getId.Descricao = dado.Descricao;
            getId.Assunto = dado.Assunto;
            getId.DataAtual = DateTime.Now;

            await _context.SaveChangesAsync();

            return Ok(getId);
        }

        [HttpDelete("Delete")]
        public async Task<ActionResult<Dado>> DeleteTarefa(int id)
        {
            Dado getId = await _context.Dados.FindAsync(id);

            if (getId == null)
                return NotFound("Id não localizado!");

            _context.Dados.Remove(getId);

            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}

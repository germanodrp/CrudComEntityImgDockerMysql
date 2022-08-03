using CrudComImgMysqlEntity.Context;
using CrudComImgMysqlEntity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrudComImgMysqlEntity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculosController : ControllerBase
    {
        private readonly ContextVeiculos _context;

        public VeiculosController(ContextVeiculos context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("BuscarTodosVeiculos")]
        public async Task<ActionResult<List<Veiculo>>>BuscarTodosVeiculos()
        {
            var buscarTodosVeiculos = _context.Veiculos.ToList();
            return Ok(buscarTodosVeiculos);
        }
        [HttpGet]
        [Route("BuscarVeiculoPorPlaca/{placa}")]
        public async Task<ActionResult<Veiculo>>BuscarVeiculoPorPlaca(string placa)
        {
            var buscarVeiculoPorPlaca = _context.Veiculos.FirstOrDefault(v => v.Placa == placa);
            return Ok(buscarVeiculoPorPlaca);
        }



        [HttpPost]
        [Route("AdicionarVeiculo")]
        public async Task<string>AdicionarVeiculo([FromBody]Veiculo veiculos)
        {
            _context.Veiculos.Add(veiculos);
            _context.SaveChanges();

            return ("Veiculo Adicionado!!");
        }

        [HttpPut]
        [Route("AtualizarVeiculo/{placa}")]
        public async Task<ActionResult<string>> AtualizarVeiculo(Veiculo veiculos,string placa)
        {
            if(veiculos.Placa != placa)
            {
                return BadRequest("Placa do veiculo não encontrada!");
            }

            _context.Veiculos.Update(veiculos);
            _context.SaveChanges();

            return Ok("Caracteristica do veiculo Atualizado com sucesso!");
        }

        [HttpDelete]
        [Route("DeletarVeiculo/{id}")]
        public async Task<ActionResult<Veiculo>>DeletarVeiculo(int id)
        {
            if(id == null)
            {
                return BadRequest("Veiculo não encontrado,Favor verificar placa!");
            }
            var buscarVeiculoPorPlaca =  _context.Veiculos.Find(id);
             _context.Veiculos.Remove(buscarVeiculoPorPlaca);
            _context.SaveChanges();

            return Ok("Veiculo deletado do sistema!!");

        }


    }
}

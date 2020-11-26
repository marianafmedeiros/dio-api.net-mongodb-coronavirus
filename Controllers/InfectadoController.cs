using Api.Data.Collections;
using Api.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using System;

namespace Api.Controllers
{   
    [ApiController]
    [Route("[controller]")]
    public class InfectadoController : ControllerBase
    {
        Data.MongoDB _mongoDB;
        IMongoCollection<Infectado> _infectadosCollection;

        public InfectadoController(Data.MongoDB mongoDB)
        {
            _mongoDB = mongoDB;
            _infectadosCollection = _mongoDB.DB.GetCollection<Infectado>(typeof(Infectado).Name.ToLower());
        }

        [HttpPost]
        public ActionResult SalvarInfectado([FromBody] InfectadoDto dto)
        {
            var infectado = new Infectado(dto.DataNascimento, dto.Sexo, dto.Latitude, dto.Longitude, dto.Id, dto.Curado);
            
            _infectadosCollection.InsertOne(infectado);

            return StatusCode(201, "Infectado adicionado com sucesso");
        }

        [HttpGet]
        public ActionResult ObterInfectados()
        {
            var infectados = _infectadosCollection.Find(Builders<Infectado>.Filter.Empty).ToList();

            return Ok(infectados);
        }
        
        [HttpPatch]
        public ActionResult AtualizarInfectado([FromBody] InfectadoDto dto)
        {
            
            _infectadosCollection.UpdateOne(
                Builders<Infectado>.Filter.Where( _ => _.DataNascimento == dto.DataNascimento), 
                Builders<Infectado>.Update.Set("sexo", dto.Sexo)
                );

            return Ok($"Infectado com id {dto.Id} atualizado com sucesso");
        }
        
        [HttpDelete ("{id}")]
        public ActionResult DeletarInfectado(string id)
        {
            
            _infectadosCollection.DeleteOne(
                Builders<Infectado>.Filter.Where( _ => _.Id == id) 
                );

            return Ok($"Infectado com id {id} deletado com sucesso");
        }
        
    }
}
using Microsoft.AspNetCore.Mvc;
using Nancy.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TodoListAPI.Models;
using TodoListAPI.Repository.Interface;
using TodoListAPI.Services;
using System.Web.Http.Cors;

namespace TodoListAPI.Controllers
{   
    [ApiController]
    [Route("[controller]")]
    public class TodoController : Controller
    {
        private ITarefaService _tarefaService;

        public TodoController(ITarefaService tarefaService)
        {
            _tarefaService = tarefaService;
        }

        [HttpGet]
        public List<Tarefa> ObterTodasTarefas()
        {
            var tarefas = _tarefaService.ObterTodasTarefas();
            return tarefas;
        }

        [HttpDelete("deletetask/{id}")]
        public void FinalizarTarefa(int id)
        {
            _tarefaService.FinalizarTarefa(id);
        }

        [HttpPost("addtask")]
        public void Post([FromBody] Tarefa tarefa)
        {
            _tarefaService.AdicionarTarefa(tarefa);
        }
    }
}

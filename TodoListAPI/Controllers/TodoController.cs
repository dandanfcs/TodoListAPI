using Microsoft.AspNetCore.Mvc;
using Nancy.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoListAPI.Models;
using TodoListAPI.Repository.Interface;
using TodoListAPI.Services;

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

        [HttpGet("{id}")]
        public void FinalizarTarefa(int id)
        {
            var teste = "aaa";

        }


        [HttpPost]
        public void AdicionarTarefa(Tarefa tarefa)
        {
            _tarefaService.AdicionarTarefa(tarefa);

        }
    }
}

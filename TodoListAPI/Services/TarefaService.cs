using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoListAPI.Models;
using TodoListAPI.Repository.Interface;

namespace TodoListAPI.Services
{
    public class TarefaService: ITarefaService
    {
        private readonly ITarefaRepository _tarefaRepository;

        public TarefaService(ITarefaRepository tarefaRepository)
        {
            _tarefaRepository = tarefaRepository;
        }

        public void AdicionarTarefa(Tarefa tarefa)
        {
            _tarefaRepository.AdicionarTarefa(tarefa);
        }

        public void FinalizarTarefa(int id)
        {
            _tarefaRepository.FinalizarTarefa(id);
        }

        public List<Tarefa> ObterTodasTarefas()
        {
          return _tarefaRepository.ObterTodasTarefas();
        }
    }
}

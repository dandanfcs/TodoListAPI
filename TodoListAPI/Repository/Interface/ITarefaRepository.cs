using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoListAPI.Models;

namespace TodoListAPI.Repository.Interface
{
    public interface ITarefaRepository
    {
        void AdicionarTarefa(Tarefa tarefa);
        void FinalizarTarefa(int id);
        List<Tarefa> ObterTodasTarefas();
    }
}

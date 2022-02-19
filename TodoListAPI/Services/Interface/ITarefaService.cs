using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoListAPI.Models;

namespace TodoListAPI.Services
{
    public interface ITarefaService
    {
        void AdicionarTarefa(Tarefa tarefa);
        List<Tarefa> ObterTodasTarefas();
    }
}

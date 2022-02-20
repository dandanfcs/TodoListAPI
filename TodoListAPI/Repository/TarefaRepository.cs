using LojaDeMateriais.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoListAPI.Models;
using TodoListAPI.Repository.Interface;

namespace TodoListAPI.Repository
{
    public class TarefaRepository : BaseRepository<Tarefa>, ITarefaRepository
    {
        public TarefaRepository(ApplicationContext context) : base(context)
        {
        }

        public void AdicionarTarefa(Tarefa tarefa)
        {
            context.Add(tarefa);
            context.SaveChanges();
        }

        public void FinalizarTarefa(int id)
        {
            var obj = dbSet.Find(id);
            dbSet.Remove(obj);
            context.SaveChanges();
        }

        public List<Tarefa> ObterTodasTarefas()
        {
            return dbSet.ToList();
        }
    }
}

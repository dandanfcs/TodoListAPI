using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoListAPI.Models;

namespace LojaDeMateriais.Context
{
    public class ApplicationContext : DbContext
    {
        //Registra no banco de dados as entidades da aplicação
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Tarefa>().HasKey(c => c.Id);

        }
    }
}

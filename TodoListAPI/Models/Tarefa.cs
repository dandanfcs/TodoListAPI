using LojaDeMateriais.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoListAPI.Models
{
    public class Tarefa : BaseModel
    {
        public string Nome { get; set; }
    }
}

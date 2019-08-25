using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace todo_restcore.Modelos
{
        public class Tarefa
    {
        public long Id { get; set; }
        public string Conteudo { get; set; }
        public bool Concluida { get; set; }
    }
}


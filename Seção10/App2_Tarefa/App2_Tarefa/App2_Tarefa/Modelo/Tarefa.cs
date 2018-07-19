using System;
using System.Collections.Generic;
using System.Text;

namespace App2_Tarefa.Modelo
{
    public class Tarefa
    {
        public string nome { get; set; }
        public DateTime? DataFinalizacao { get; set; } //A interrogação (?) é para aceitar o valor Null
        public string Prioridade { get; set; }
    }
}

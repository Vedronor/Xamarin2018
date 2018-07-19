using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace App2_Tarefa.Modelo
{
    public class GerenciadorTarefa
    {
        private List<Tarefa> Lista { get; set; }

        public void Salvar(Tarefa tarefa) {
            Lista = Listagem();
            Lista.Add(tarefa);

            SalvarnoProperties(Lista);
        }

        public void RemoverTarefa(int index) {
            Lista = Listagem();
            Lista.RemoveAt(index);

            SalvarnoProperties(Lista);

        }

        public void Finalizar(int indice, Tarefa tarefa) {
            Lista = Listagem();
            Lista.RemoveAt(indice);

            tarefa.DataFinalizacao = DateTime.Now;

            Lista.Add(tarefa);
            SalvarnoProperties(Lista);
        }

        public List<Tarefa> Listagem() {
            return ListagemNoProperties();
        }

        private void SalvarnoProperties(List<Tarefa> lista) {
            if (App.Current.Properties.ContainsKey("Tarefas"))
            {
                App.Current.Properties.Remove("Tarefas");
            }
            string JsonValue = JsonConvert.SerializeObject(Lista);

            App.Current.Properties.Add("Tarefas", JsonValue);
        }

        private List<Tarefa> ListagemNoProperties() {
            if (App.Current.Properties.ContainsKey("Tarefas"))
            {
                String JsonVal = (String)App.Current.Properties["Tarefas"];

                List<Tarefa> Lista = JsonConvert.DeserializeObject<List<Tarefa>>(JsonVal);

                return Lista;

                //return (List<Tarefa>)App.Current.Properties["Tarefas"];
            }

            return new List<Tarefa>();
        }
    }
}

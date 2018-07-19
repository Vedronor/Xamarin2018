using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App2_Tarefa.Modelo;

namespace App2_Tarefa.Telas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Cadastro : ContentPage
	{
		public Cadastro ()
		{
			InitializeComponent ();
		}
        //variaveis
        private string Prioridade { get; set; }

        public void PrioridadeSelect(object sender, EventArgs args) {
            var Stacks = SLPrioridades.Children;

            foreach(var Linha in Stacks) {
                Label LblPrioridade = ((StackLayout)Linha).Children[1] as Label;
                LblPrioridade.TextColor = Color.Gray;
            }

            ((Label)((StackLayout)sender).Children[1]).TextColor = Color.Black;
            FileImageSource Source = ((Image)((StackLayout)sender).Children[0]).Source as FileImageSource;

            String Prioridade = Source.File.ToString().Replace("Resources/", "").Replace(".png", "");
            this.Prioridade = Prioridade;
                
        }

        public void SalvarAction(object sender, EventArgs args) {
            bool ErroExiste = false;

            if (!(TxtNome.Text.Trim().Length > 0)){
                DisplayAlert("ERRO!", "Nome não preenchido.", "Ok");
                ErroExiste = true;
            }

            if (!(Prioridade != "")){
                DisplayAlert("ERRO!", "Prioridade não informada.", "Ok");
                ErroExiste = true;
            }

            if (!ErroExiste) {
                Tarefa tarefa = new Tarefa();
                tarefa.nome = TxtNome.Text;
                tarefa.Prioridade = this.Prioridade;

                new GerenciadorTarefa().Salvar(tarefa);

                App.Current.MainPage = new NavigationPage(new Inicio());

            }
        }

    }
}
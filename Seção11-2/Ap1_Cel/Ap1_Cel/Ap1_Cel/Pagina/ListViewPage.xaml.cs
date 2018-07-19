using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Ap1_Cel.Modelo;
using Ap1_Cel.Detalhe;

namespace Ap1_Cel.Pagina
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViewPage : ContentPage
	{
		public ListViewPage ()
		{
			InitializeComponent ();

            List<Funcionario> Lista = new List<Funcionario>();

            Lista.Add(new Funcionario() { Nome = "José", Cargo = "Presidente" });
            Lista.Add(new Funcionario() { Nome = "Ane", Cargo = "Gerente de Vendas" });
            Lista.Add(new Funcionario() { Nome = "Julia", Cargo = "Gerente de Marketing" });
            Lista.Add(new Funcionario() { Nome = "Vitor", Cargo = "Presidente" });
            Lista.Add(new Funcionario() { Nome = "Renata", Cargo = "Vendedora" });

            ListaFuncionarios.ItemsSource = Lista;
        }

        public void ItemSelecionadoAction(object sender, SelectedItemChangedEventArgs args) {
            Funcionario func = (Funcionario)args.SelectedItem;

            Navigation.PushAsync(new DetailPage(func));
        }

        private void FeriasAction(object sender, EventArgs args) {
            MenuItem botao = (MenuItem)sender;
            Funcionario func = (Funcionario)botao.CommandParameter;

            DisplayAlert("Titulo: " + func.Nome, "Mensagem: " + func.Nome + " - " + func.Cargo, "Ok");
        }

        private void AbonoAction(object sender, EventArgs args) {
            MenuItem botao = (MenuItem)sender;
            Funcionario func = (Funcionario)botao.CommandParameter;

            DisplayAlert("funcionário: " + func.Nome,"Mensagem: Abonado(a) do cargo de " + func.Cargo, "Ok");
        }

    }
}
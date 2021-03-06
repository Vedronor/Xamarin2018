﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Ap1_Cel.Modelo;

namespace Ap1_Cel.Pagina
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViewButtonPage : ContentPage
	{
		public ListViewButtonPage ()
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

        private void FeriasAction(object sender, EventArgs args) {
            Button btnFerias = (Button)sender;
            Funcionario func = (Funcionario)btnFerias.CommandParameter;
            DisplayAlert("Ferias", "Funcionario: " + func.Nome, "OK");
        }
	}
}
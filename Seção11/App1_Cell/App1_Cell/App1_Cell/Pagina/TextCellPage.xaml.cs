﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1_Cell.Modelo;

namespace App1_Cell.Pagina
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TextCellPage : ContentPage
	{
		public TextCellPage ()
		{
			InitializeComponent ();

            List<Funcionario> Lista = new List<Funcionario>();

            Lista.Add(new Funcionario() { Nome = "José", Cargo="Presidente"});
            Lista.Add(new Funcionario() { Nome = "Ane", Cargo = "Gerente de Vendas" });
            Lista.Add(new Funcionario() { Nome = "Julia", Cargo = "Gerente de Marketing" });
            Lista.Add(new Funcionario() { Nome = "Vitor", Cargo = "Presidente" });
            Lista.Add(new Funcionario() { Nome = "Renata", Cargo = "Vendedora" });

            ListaFuncionarios.ItemsSource = Lista;

        }
	}
}
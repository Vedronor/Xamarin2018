using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1_ControleXF.Modelo;

namespace App1_ControleXF.Controles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViewPage : ContentPage
	{
		public ListViewPage ()
		{
			InitializeComponent ();

            List<Pessoa> lista = new List<Pessoa>();
            lista.Add(new Pessoa { Nome = "Vitor Lima", Idade = "23", ID = "29" });
            lista.Add(new Pessoa { Nome = "Ane Mayara", Idade = "21", ID = "32" });
            lista.Add(new Pessoa { Nome = "Julia Lima", Idade = "20", ID = "412" });
            lista.Add(new Pessoa { Nome = "Sabrina Bittenchurt", Idade = "23", ID = "21312" });
            lista.Add(new Pessoa { Nome = "Renata Ferreira", Idade = "25", ID = "2519" });

            ListaPessoas.ItemsSource = lista;
		}
	}
}
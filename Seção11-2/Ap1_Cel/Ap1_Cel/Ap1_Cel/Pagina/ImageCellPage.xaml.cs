using System;
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
	public partial class ImageCellPage : ContentPage
	{
		public ImageCellPage ()
		{
			InitializeComponent ();

            List<Funcionario> Lista = new List<Funcionario>();

            Lista.Add(new Funcionario() { Foto = "perfil.png", Nome = "José", Cargo = "Presidente" });
            Lista.Add(new Funcionario() { Foto = "perfil.png", Nome = "Ane", Cargo = "Gerente de Vendas" });
            Lista.Add(new Funcionario() { Foto = "perfil.png", Nome = "Julia", Cargo = "Gerente de Marketing" });
            Lista.Add(new Funcionario() { Foto = "perfil.png", Nome = "Vitor", Cargo = "Presidente" });
            Lista.Add(new Funcionario() { Foto = "perfil.png", Nome = "Renata", Cargo = "Vendedora" });

            ListaFuncionarios.ItemsSource = Lista;
        }
    }
}
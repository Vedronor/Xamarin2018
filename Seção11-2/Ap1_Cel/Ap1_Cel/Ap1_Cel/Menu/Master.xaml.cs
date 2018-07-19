using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ap1_Cel.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : MasterDetailPage
    {
        public Master()
        {
            InitializeComponent();
        }

        public void GoTextCell(object sender, EventArgs args) {
            Detail = new NavigationPage(new Pagina.TextCellPage());
            IsPresented = false;
        }

        public void GoImageCell(object sender, EventArgs args) {
            Detail = new NavigationPage(new Pagina.ImageCellPage());
            IsPresented = false;
        }

        public void GoEntryCellPage(object sender, EventArgs args) {
            Detail = new NavigationPage(new Pagina.EntryCellPage());
            IsPresented = false;
        }

        public void GoSwitchCellPage(object sender, EventArgs args) {
            Detail = new NavigationPage(new Pagina.SwitchCellPage());
            IsPresented = false;
        }

        public void GoViewCellPage(object sender, EventArgs args) {
            Detail = new NavigationPage(new Pagina.ViewCellPage());
            IsPresented = false;
        }

        public void GoListViewPage(object sender, EventArgs args) {
            Detail = new NavigationPage(new Pagina.ListViewPage());
            IsPresented = false;
        }

        public void GoListViewButtonPage(object sender, EventArgs args) {
            Detail = new NavigationPage(new Pagina.ListViewButtonPage());
            IsPresented = false;
        }
    }
}

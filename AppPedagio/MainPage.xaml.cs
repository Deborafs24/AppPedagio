using System.Collections.ObjectModel;
using AppPedagio.Models;

namespace AppPedagio
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<Pedagio> lista_pedagio =
           new ObservableCollection<Pedagio>();

        public MainPage()
        {
            InitializeComponent();

            lst_pedagio.ItemSource = lista_pedagio;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            
        }

        private void btnPedagio_Clicked(object sender, EventArgs e)
        {

        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }
    }

}

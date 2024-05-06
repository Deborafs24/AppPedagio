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
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            
        }

        private void btnPedagio_Clicked(object sender, EventArgs e)
        {
            double soma = lista_pedagio.Sum(i => (i.Distancia / i.Rendimento));
            string msg = $"O total é {soma:C}";
            DisplayAlert("Somatória", msg, "Fechar");
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.NovoPedagio());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }
    }

}

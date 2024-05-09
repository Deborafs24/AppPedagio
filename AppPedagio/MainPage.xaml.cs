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
            double Distancia = Convert.ToDouble(etyDistancia.Text);
            double Precogas = Convert.ToDouble(etyGasolinaP.Text);
            double Rendimento = Convert.ToDouble(etyRendimento.Text);

            double conta = Distancia / Rendimento;
            double conta2 = Precogas * conta;

            string msg = $"O total é {conta2:C}";
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

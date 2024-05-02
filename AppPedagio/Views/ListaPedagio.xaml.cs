using AppPedagio.Models;
using System.Collections.ObjectModel;

namespace AppPedagio.Views;

public partial class ListaPedagio : ContentPage
{
    ObservableCollection<Pedagio> lista_pedagios =
            new ObservableCollection<Pedagio>();
    public ListaPedagio()
	{
		InitializeComponent();
        lst_pedagios.ItemsSource = lista_pedagios;
    }

    protected async override void OnAppearing()
    {
        if (lista_pedagios.Count == 0)
        {

            List<Pedagio> tmp = await App.Db.GetAll();
            foreach (Pedagio p in tmp)
            {
                lista_pedagios.Add(p);
            }

        }
    }

    private void txt_search_TextChanged(object sender, TextChangedEventArgs e)
    {
        string q = e.NewTextValue;
        lista_pedagios.Clear();
        Task.Run(async () =>
        {
            List<Pedagio> tmp = await App.Db.Search(q);
            foreach (Pedagio p in tmp)
            {
                lista_pedagios.Add(p);
            }
        });
    }
}
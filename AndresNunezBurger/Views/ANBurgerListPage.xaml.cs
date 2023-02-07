using AndresNunezBurger.Models;
using AndresNunezBurger.Data;
using System.Linq;

namespace AndresNunezBurger.Views;

public partial class ANBurgerListPage : ContentPage
{
    ANBurger selected;
    public ANBurgerListPage()
    {
		InitializeComponent();
        
        burgerListAN.ItemsSource = UpdateList();
    }

    private async void OnItemAddedAN(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(ANBurgerItemPage));
    }

    private void ActualizarDatos(object sender, EventArgs e)
    {
        
        burgerListAN.ItemsSource = App.Repositorio.GetAllBurgers();
    }

    private async void ANselected(object sender, SelectionChangedEventArgs e)
    {
        selected = e.CurrentSelection[0] as ANBurger;
        await Navigation.PushAsync(new ANBurgerItemPage
        {
            ANaux = selected,
            BindingContext = selected,
        });
    }

    private static List<ANBurger> UpdateList()
    {
        List<ANBurger> burger = App.Repositorio.GetAllBurgers();
        return burger;
    }
}
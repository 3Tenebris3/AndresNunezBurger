using AndresNunezBurger.Data;
using AndresNunezBurger.Models;

namespace AndresNunezBurger.Views;

[QueryProperty(nameof(ANaux), "Aux")]
public partial class ANBurgerItemPage : ContentPage
{

    ANBurger Item = new ANBurger();
    ANBurger Aux = new ANBurger();
    bool _flag;
    public ANBurgerItemPage()
    {
        InitializeComponent();
    }
    public ANBurger ANaux
    {
        get => Aux;
        set => Aux = value;
    }
    private async void OnSaveClickedAN(object sender, EventArgs e)
    {
        Item = Aux;
        Item.Name = nameAN.Text;
        Item.Description = descAN.Text;
        Item.WithExtraCheese = _flag;

        if (string.IsNullOrEmpty(Item.Name) || string.IsNullOrEmpty(Item.Description))
        {
            return;
        }
        App.Repositorio.AddNewBurger(Item);
        await Shell.Current.GoToAsync("..");

    }

    private async void CancelClickedAN(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
    private void CheckedChangedAN(object sender, CheckedChangedEventArgs e)
    {
        _flag = e.Value;
    }

    private async void OnDeleteClickedAN(object sender, EventArgs e)
    {
        Item = Aux;
        App.Repositorio.DeleteBurger(Item);
        await Shell.Current.GoToAsync("..");

    }
}
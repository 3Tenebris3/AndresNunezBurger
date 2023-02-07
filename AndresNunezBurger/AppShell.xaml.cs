namespace AndresNunezBurger;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(Views.ANBurgerItemPage), typeof(Views.ANBurgerItemPage));
        Routing.RegisterRoute(nameof(Views.ANBurgerListPage), typeof(Views.ANBurgerListPage));
    }
}

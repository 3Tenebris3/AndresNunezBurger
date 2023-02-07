using AndresNunezBurger.Data;
namespace AndresNunezBurger;

public partial class App : Application
{
    public static ANBurgerDataBase Repositorio { get; private set; }
    public App(ANBurgerDataBase repo)
    {
        InitializeComponent();

        MainPage = new AppShell();
        Repositorio = repo;
    }
}

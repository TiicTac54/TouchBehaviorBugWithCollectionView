namespace TouchBehaviorBug;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        
        Routing.RegisterRoute(nameof(MainPage2), typeof(MainPage2));
    }
}
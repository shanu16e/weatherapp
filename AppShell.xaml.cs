using $safeprojectname$.Views;


namespace $safeprojectname$
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Register routes for navigation
            Routing.RegisterRoute(nameof(CitySearchPage), typeof(CitySearchPage));
        }
    }
}
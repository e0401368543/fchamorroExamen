using fchamorroExamen.Views;

namespace fchamorroExamen
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Login());
        }
    }
}

using Prism.Unity;
using NewBoy.Views;
using Xamarin.Forms;

namespace NewBoy
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("NavigationPage/SignUp");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<SignUp>();
            Container.RegisterTypeForNavigation<Login>();
        }
    }
}

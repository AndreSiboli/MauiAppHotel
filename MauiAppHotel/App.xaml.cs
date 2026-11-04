namespace MauiAppHotel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var page = new NavigationPage(new Views.ContratacaoHospedagem());

            var window = new Window(page)
            {
                Width = 400,
                Height = 600
            };

            return window;
        }
    }
}
using Microsoft.Maui.Controls;
using AppHotel.Views;

namespace AppHotel.Views
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new MainPage());  // Criando a janela com MainPage
        }
    }
}

using MauiAppHotel.Models;
using MauiAppHotel.Views;


namespace MauiAppHotel
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto()
            {
                Descricao = "Suíte Super Luxo",
                ValorDiariaAdulto = 120.0,
                ValorDiariaCrianca = 60.0,
                ValorDiariaMonstro = 200.0
            },
            new Quarto()
            {
                Descricao = "Suíte Luxo",
                ValorDiariaAdulto = 100.0,
                ValorDiariaCrianca = 50.0,
                ValorDiariaMonstro = 150.0
            },
            new Quarto()
            {
                Descricao = "Suíte Single",
                ValorDiariaAdulto = 70.0,
                ValorDiariaCrianca = 35.0,
                ValorDiariaMonstro = 100.0
            },
            new Quarto()
            {
                Descricao = "Suíte Crise",
                ValorDiariaAdulto = 40.0,
                ValorDiariaCrianca = 20.0,
                ValorDiariaMonstro = 80.0
            }
        };

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage (new PaginaInicial());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 725;

            return window;
        }
    }
}


using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto()
            {
              Descricao = "Suíte Royal",
              ValorDiariaAdulto = 500.0,
              ValorDiariaCrianca = 200.0
            },

            new Quarto()
            {
              Descricao = "Suíte Premium",
              ValorDiariaAdulto = 400.0,
              ValorDiariaCrianca = 150.0
            },

            new Quarto()
            {
              Descricao = "Suíte Smart",
              ValorDiariaAdulto = 180.0,
              ValorDiariaCrianca = 80.0
            },

            new Quarto()
            {
              Descricao = "Suíte Basic",
              ValorDiariaAdulto = 50,
              ValorDiariaCrianca = 30
            },

        };



        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {

            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 700;

            return window;
        }
    }
}

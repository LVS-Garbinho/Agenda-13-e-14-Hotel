
using Agenda_13_e_14_Hotel.Models;

namespace Agenda_13_e_14_Hotel
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto()
            {
                Descricao = "Suíte Presidencial",
                ValorDiariaAdulto = 750.0,
                ValorDiariaCrianca = 500.0
            },
            new Quarto()
            {
                Descricao = "Suíte Super Luxo",
                ValorDiariaAdulto = 500.0,
                ValorDiariaCrianca = 250.0
            },
            new Quarto()
            {
                Descricao = "Suíte Luxo",
                ValorDiariaAdulto = 250.0,
                ValorDiariaCrianca = 125.0
            },
            new Quarto()
            {
                Descricao = "Suíte mediana",
                ValorDiariaAdulto = 125.0,
                ValorDiariaCrianca = 75.0
            },
            new Quarto()
            {
                Descricao = "Suíte ",
                ValorDiariaAdulto = 75.0,
                ValorDiariaCrianca = 25.0
            }
        };
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window  = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}

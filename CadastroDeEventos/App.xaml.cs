using CadastroDeEventos.Models;

namespace CadastroDeEventos
{
    public partial class App : Application
    {
        public List<Locais> lista_locais = new List<Locais>
        {
            new Locais()
            {
                Descricao = "Valedouro de Lys",
                ValorPorPessoa = 100.0
            },
             new Locais()
            {
                Descricao = "Porto Salmoura",
                ValorPorPessoa = 70.0
            },
              new Locais()
            {
                Descricao = "Cidadela de Arkenfall",
                ValorPorPessoa = 250.0
            },
               new Locais()
            {
                Descricao = "Floresta de Murmúrios",
                ValorPorPessoa = 50.0
            }
        };
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.CadastroDeEventos());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;
            return window;
        }
    }
}
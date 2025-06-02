

using CadastroDeEventos.Models;

namespace CadastroDeEventos.Views;

public partial class CadastroDeEventos : ContentPage
{

	App PropriedadesApp;

	public CadastroDeEventos()
	{
		InitializeComponent();

		PropriedadesApp = (App)Application.Current;

		pck_local.ItemsSource = PropriedadesApp.lista_locais;

        dtpck_inicio.MinimumDate = DateTime.Now;
		dtpck_fim.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 2, DateTime.Now.Day );

		dtpck_fim.MinimumDate = dtpck_inicio.Date.AddDays(1);
		dtpck_fim.MaximumDate = dtpck_inicio.Date.AddMonths(6);
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Evento h = new Evento
			{
				LocalEscolhido = (Locais)pck_local.SelectedItem,
				QntPessoas = Convert.ToInt32(stp_pessoas.Value),
				DataInicio = dtpck_inicio.Date,
				DataFinal = dtpck_fim.Date,
			};



			await Navigation.PushAsync(new TotalDeEventos()
			{
				BindingContext = h
			});
		}
		catch (Exception ex)
		{
			await DisplayAlert("Ops", ex.Message, "Ok");
		}
    }

    private void dtpck_inicio_DateSelected(object sender, DateChangedEventArgs e)
    {
		DatePicker elemento = sender as DatePicker;

		DateTime data_selecionada_inicio = elemento.Date;

		dtpck_fim.MaximumDate = data_selecionada_inicio.AddDays(1);
		dtpck_fim.MaximumDate = data_selecionada_inicio.AddMonths(6);
    }
}
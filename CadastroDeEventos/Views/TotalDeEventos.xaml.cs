namespace CadastroDeEventos.Views;

public partial class TotalDeEventos : ContentPage
{
	public TotalDeEventos()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PopAsync();

		} catch (Exception ex)
		{
			DisplayAlert("Ops", ex.Message, "Ok");
		}
    }
}
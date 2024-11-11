namespace Agenda_13_e_14_Hotel.Views;

public partial class Informacoes : ContentPage
{
	public Informacoes()
	{
		InitializeComponent();
	}
    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PopAsync();

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}
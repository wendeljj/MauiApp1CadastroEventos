namespace MauiApp1CadastroEventos.Views;

public partial class PageCadastrada : ContentPage
{
	public PageCadastrada()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PopAsync();
        }
        catch (Exception ex) { DisplayAlert("Erro", ex.Message, "OK"); }
    }
}
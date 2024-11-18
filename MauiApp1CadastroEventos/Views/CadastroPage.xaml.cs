using MauiApp1CadastroEventos.Models;

namespace MauiApp1CadastroEventos.Views;

public partial class CadastroPage : ContentPage
{
	public CadastroPage()
	{
		InitializeComponent();

        data_checkin.MinimumDate = DateTime.Now;
        data_checkout.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

        data_checkout.MinimumDate = data_checkin.Date.AddDays(1);
        data_checkout.MaximumDate = data_checkin.Date.AddMonths(6);
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        Evento ev = new Evento
        {
            NomeEvento = event_name.Text,
            LocalEvento = local_event.Text,
            QntParticipantes = Convert.ToInt32(qnt_participantes.Text),
            CustoParticipantes = Convert.ToDouble(custo_participante.Text),
            DataInicio = data_checkin.Date,
            DataTermino = data_checkout.Date,
        };

        try
        {
            await Navigation.PushAsync(new PageCadastrada()
            {
                BindingContext = ev
            });
        }
        catch (Exception ex)
        {
            await DisplayAlert("Erro", ex.Message, "OK");
        }
    }

    private void data_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;
        DateTime data_selecionada = elemento.Date;

        data_checkout.MinimumDate = data_selecionada.Date.AddDays(1);
        data_checkout.MaximumDate = data_selecionada.Date.AddMonths(6);
    }
}
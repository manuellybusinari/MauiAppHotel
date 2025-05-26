namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    App PropriedadesApp;

    public ContratacaoHospedagem()
    {
        InitializeComponent();

        PropriedadesApp = (App)Application.Current;

        pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;
        // pck_quarto: Picker em 'ContratacaoHospedagem'- Selecione sua acomodação
        //ItemsSource: Aceita apenas LIST
        //PropriedadesApp: Declaração de App para permitir acesso
        //lista_quartos: é exatamente a lista criada em 'app.xaml.cs'- "Suítes Royal, Premium, Smart, Basic"


        dtpck_checkin.MinimumDate = DateTime.Now; // Checkin contando a partir do dia atual da reserva 

        dtpck_checkin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day); // Reserva de apenas 1 mês valido no app 


        dtpck_checkout.MinimumDate = dtpck_checkin.Date.AddDays(1); // Define ao menos 1 dia de hospedagem no hotel

        dtpck_checkout.MaximumDate = dtpck_checkin.Date.AddMonths(6); // Define no máximo 6 meses de hospedagem

    }

    private App? App()
    {
        throw new NotImplementedException();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {

            Navigation.PushAsync(new HospedagemContratada());

        }
        catch (Exception ex)
        {

            DisplayAlert("Ops", ex.Message, "Ok");

        }
    }

    private void Sobre_Clicked_1(object sender, EventArgs e)
    {
        try
        {

            Navigation.PushAsync(new NewPage1());

        }
        catch (Exception ex)
        {

            DisplayAlert("Ops", ex.Message, "Ok");

        }


    }

    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;

        DateTime data_selecionada_checkin = elemento.Date;

        dtpck_checkout.MinimumDate = data_selecionada_checkin.AddDays(1);
        dtpck_checkout.MaximumDate = data_selecionada_checkin.AddMonths(6);
    

    }

    private void Acomodacao_Clicked(object sender, EventArgs e)
    {
        try
        {

            Navigation.PushAsync(new DetalhesAcomodacao());

        }
        catch (Exception ex)
        {

            DisplayAlert("Ops", ex.Message, "Ok");

        }
    }

  
}

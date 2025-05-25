namespace MauiAppHotel.Views;

public partial class HospedagemContratada : ContentPage
{
	public HospedagemContratada()
	{
		InitializeComponent();
	}

    private void Button_Clicked_Voltar(object sender, EventArgs e)
    {
        try
        {

            Navigation.PopAsync();

        }
        catch (Exception ex)
        {
            DisplayAlert("Erro", "Ocorreu um erro: " + ex.Message, "OK");
        }
    }
}
namespace MauiAppHotel.Views;

public partial class Sobre : ContentPage
{
	public Sobre()
	{
		InitializeComponent();
	}

    private void Bt_voltar_mainpage_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new ContratacaoHospedagem());
    }
}
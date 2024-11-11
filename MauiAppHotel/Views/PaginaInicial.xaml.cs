namespace MauiAppHotel.Views;

public partial class PaginaInicial : ContentPage
{
	public PaginaInicial()
	{
		InitializeComponent();
	}
    private  void Button_Clicked_Quartos(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ContratacaoHospedagem());
    }
    private  void Button_Clicked_Sobre(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PaginaSobre());
    }
}
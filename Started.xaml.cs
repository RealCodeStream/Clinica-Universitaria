using Microsoft.Maui.Controls;
namespace CureLife;

public partial class Started : ContentPage
{
	public Started()
	{
		InitializeComponent();

	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
       
    }
}
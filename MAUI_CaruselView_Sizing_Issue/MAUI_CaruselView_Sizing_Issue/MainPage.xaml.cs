namespace MAUI_CaruselView_Sizing_Issue;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

		Carousel.ItemsSource = new List<string> { "First", "Second", "Third" };
    }
}



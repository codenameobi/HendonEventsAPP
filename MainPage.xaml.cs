using HendonEventsApp.ViewModel;

namespace HendonEventsApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		
	}
}


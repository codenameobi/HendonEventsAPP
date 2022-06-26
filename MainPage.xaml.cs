using HendonEventsApp.ViewModel;

namespace HendonEventsApp;

public partial class MainPage : ContentPage
{

	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

}


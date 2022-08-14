using Carlist.App.Maui.ViewModels;

namespace Carlist.App.Maui;

public partial class MainPage : ContentPage
{
	

	public MainPage(CarListViewModel carListViewModel)
	{
		InitializeComponent();
		BindingContext = carListViewModel;
		
	}

	
}


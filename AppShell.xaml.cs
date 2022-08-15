using Carlist.App.Maui.Views;

namespace Carlist.App.Maui;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(CarDetailsPage), typeof(CarDetailsPage));
	}
}

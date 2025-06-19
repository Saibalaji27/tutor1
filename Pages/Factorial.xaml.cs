using tutor.ViewModel;

namespace tutor.Pages;

public partial class Factorial : ContentPage
{
	public Factorial()
	{
		InitializeComponent();

		BindingContext = new FactorialViewModel();
	}
}
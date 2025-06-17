using tutor.ViewModel;
namespace tutor.Pages;

public partial class PrimeNumbers : ContentPage
{
	public PrimeNumbers()
	{
		InitializeComponent();

        BindingContext = new PrimeViewModel();
    }
}
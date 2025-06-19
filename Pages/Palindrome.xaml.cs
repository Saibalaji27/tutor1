using tutor.ViewModel;

namespace tutor.Pages;

public partial class Palindrome : ContentPage
{
	public Palindrome()
	{
		InitializeComponent();

		BindingContext = new PalindromeViewModel();
	}
}
using tutor.ViewModel;

namespace tutor.Pages;

public partial class OddEven : ContentPage
{
	public OddEven()
	{
		InitializeComponent();

		BindingContext = new OddEvenViewModel();
	}
}
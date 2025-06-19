using tutor.ViewModel;

namespace tutor.Pages;

public partial class Strong : ContentPage
{
	public Strong()
	{
		InitializeComponent();

		BindingContext = new StrongViewModel();
	}
}
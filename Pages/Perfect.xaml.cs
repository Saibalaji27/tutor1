using tutor.ViewModel;

namespace tutor.Pages;

public partial class Perfect : ContentPage
{
	public Perfect()
	{
		InitializeComponent();

		BindingContext = new PerfectViewModel();
	}
}
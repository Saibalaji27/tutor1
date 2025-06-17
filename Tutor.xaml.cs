

using tutor.Pages;

namespace tutor
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
       
        private void primenumber(object sender, TappedEventArgs e)
        {
            Navigation.PushAsync(new PrimeNumbers());
        }
    }

}

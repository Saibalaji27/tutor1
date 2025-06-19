

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

        private void oddeven(object sender, TappedEventArgs e)
        {
            Navigation.PushAsync(new OddEven());
        }

        private void factorial(object sender, TappedEventArgs e)
        {
            Navigation.PushAsync(new Factorial());
        }

        private void perfectnumber(object sender, TappedEventArgs e)
        {
            Navigation.PushAsync(new Perfect());
        }

        private void strongnumber(object sender, TappedEventArgs e)
        {
            Navigation.PushAsync(new Strong());
        }

        private void palindromenumber(object sender, TappedEventArgs e)
        {
            Navigation.PushAsync(new Palindrome());
        }
    }

}

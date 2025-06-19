

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using tutor.PrimeModelPage;


namespace tutor.ViewModel
{
    public partial class PrimeViewModel : ObservableObject
    {
        public int number { get; set; }

        [ObservableProperty]
        string value;
        public async Task checkNumber()
        {
            
            var prime = new PrimeModel();
            {
                number = Convert.ToInt32(value);

            }

            int j = 0;

            for (int i  = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    j++;
                }
            }
            if(j==2)
            {
                await Shell.Current.DisplayAlert("prime number", "Entered number is a prime number", "ok");
            }
            else
            {
                await Shell.Current.DisplayAlert("prime number", "Entered number is not a prime number", "ok");
            }
            
        }

        [RelayCommand]
        public async Task Check()
            {
            await checkNumber();          
        }

    }

}

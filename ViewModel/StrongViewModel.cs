using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using tutor.StrongModelPage;

namespace tutor.ViewModel;

    public partial class StrongViewModel : ObservableObject
    {
        public int number { get; set; }

        [ObservableProperty]
        string value;
        public async Task checkNumber()
        {

            var strong = new StrongModel();
            {
                number = Convert.ToInt32(value);

            }


        int sum = 0;
        int temp = number;

        while (temp > 0)
        {
            int digit = temp % 10;
            sum += Factorial(digit);
            temp /= 10;
        }


        if (sum == number)
            {
                await Shell.Current.DisplayAlert("Strong number", "Entered number is a Strong number", "ok");
            }
            else
            {
                await Shell.Current.DisplayAlert("Strong number", "Entered number is not a Strong number", "ok");
            }

        }


            private int Factorial(int n)
            {
                int fact = 1;
                for (int i = 1; i <= n; i++)
                {
                    fact *= i;
                }
                return fact;
            }


    [RelayCommand]
        public async Task Check()
        {
            await checkNumber();
        }

    }

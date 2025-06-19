using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using tutor.PrimeModelPage;

namespace tutor.ViewModel;

public partial class PerfectViewModel : ObservableObject
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

        int sum = 0;

        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                sum += i;
            }
        }

        if (sum == number)
        {
            await Shell.Current.DisplayAlert("perfect number", "Entered number is a perfect number", "ok");
        }
        else
        {
            await Shell.Current.DisplayAlert("perfect number", "Entered number is not a perfect number", "ok");
        }

    }

    [RelayCommand]
    public async Task Check()
    {
        await checkNumber();
    }

}


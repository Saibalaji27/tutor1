using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using tutor.PalindromeModelPage;

namespace tutor.ViewModel;

public partial class PalindromeViewModel : ObservableObject
{
    public int number { get; set; }

    [ObservableProperty]
    string value;
    public async Task checkNumber()
    {

        var prime = new PalindromeModel();
        {
            number = Convert.ToInt32(value);

        }

        int reversed = 0;
        int temp = number;

        while (temp > 0)
        {
            int digit = temp % 10;
            reversed = (reversed * 10) + digit;
            temp /= 10;
        }

        if (reversed == number)
        {
            await Shell.Current.DisplayAlert("palindrome number", "Entered number is a palindrome number", "ok");
        }
        else
        {
            await Shell.Current.DisplayAlert("palindrome number", "Entered number is not a palindrome number", "ok");
        }

    }

    [RelayCommand]
    public async Task Check()
    {
        await checkNumber();
    }
}
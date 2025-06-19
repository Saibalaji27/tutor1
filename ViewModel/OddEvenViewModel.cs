using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using tutor.OddEvenModelPage;

namespace tutor.ViewModel;

public partial class OddEvenViewModel : ObservableObject
{
         public int number { get; set; }

        [ObservableProperty]
        string value;
        public async Task checkNumber()
        {

        var prime = new OddEvenModel();
        {
                number = Convert.ToInt32(value);

            }
        if (number % 2 == 0)
        {
            await Shell.Current.DisplayAlert("ODD or EVEN", "Entered number is a Even number", "ok");
        }
        else 
        {
            await Shell.Current.DisplayAlert("ODD or EVEN", "Entered number is a ODD number", "ok");
        }

        }
    
        [RelayCommand]
        public async Task Check()
        {
            await checkNumber();
        }
    }

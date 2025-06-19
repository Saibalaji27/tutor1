using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using tutor.FactorialModelPage;

namespace tutor.ViewModel;

public partial class FactorialViewModel : ObservableObject
{
	
        public int number { get; set; }

        [ObservableProperty]
        string value;
        public async Task checkNumber()
        {

            var factorial = new FactorialModel();
            {
                number = Convert.ToInt32(value);

            }

            int fact = 1;

            for (int i = 1; i <= number; i++)
            {
            fact *= i;
            }
            
            await Shell.Current.DisplayAlert("Factorial number", "Entered Factorial Value of " +(number)+ " is " +(fact) , "ok");
            

        }

        [RelayCommand]
        public async Task Check()
        {
            await checkNumber();
        }

 }

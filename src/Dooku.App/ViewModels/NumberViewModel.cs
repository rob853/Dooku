using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace Dooku.App.ViewModels
{
    internal class NumberViewModel : ObservableObject
    {
        public int[] TheNumber { get; set; }

        public ICommand IncrementNumberCommand { get; }

        public NumberViewModel()
        {
            IncrementNumberCommand = new RelayCommand<string>(IncrementNumber);
            if (TheNumber == null)
            {
                TheNumber = new int[5];
            }
        }

        void IncrementNumber(string index)
        {
            TheNumber[int.Parse(index)]++;
            OnPropertyChanged(nameof(TheNumber));
        }
    }
}

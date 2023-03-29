using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace Dooku.App.ViewModels
{
    internal class NumberViewModel : ObservableObject
    {
        public int[,] TheNumbers { get; set; }

        public string ButtonHeight => "50";

        public string ButtonWidth => "10";

        public Thickness ButtonMargin => 10;

        public ICommand IncrementNumberCommand { get; }

        public NumberViewModel()
        {
            IncrementNumberCommand = new RelayCommand<string>(IncrementNumber);
            if (TheNumbers == null)
            {
                TheNumbers = new int[9, 9];
            }
        }

        void IncrementNumber(string index)
        {
            var rowIndex = int.Parse(index[0].ToString());
            var colIndex = int.Parse(index[1].ToString());
            var currentValue = TheNumbers[rowIndex, colIndex];
            if(currentValue == 9)
            {
                TheNumbers[rowIndex, colIndex] = 0;
            }
            else
            {
                TheNumbers[rowIndex, colIndex]++;
            }

            OnPropertyChanged(nameof(TheNumbers));
        }
    }
}

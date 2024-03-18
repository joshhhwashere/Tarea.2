using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TecnologicoApp.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public MainPageViewModel()
        {
            // Constructor público sin parámetros
        }

        private double _firstNumber;
        public double FirstNumber
        {
            get { return _firstNumber; }
            set
            {
                if (_firstNumber != value)
                {
                    _firstNumber = value;
                    OnPropertyChanged(nameof(FirstNumber));
                }
            }
        }

        private double _secondNumber;
        public double SecondNumber
        {
            get { return _secondNumber; }
            set
            {
                if (_secondNumber != value)
                {
                    _secondNumber = value;
                    OnPropertyChanged(nameof(SecondNumber));
                }
            }
        }

        private double _result;
        public double Result
        {
            get { return _result; }
            set
            {
                if (_result != value)
                {
                    _result = value;
                    OnPropertyChanged(nameof(Result));
                }
            }
        }

        public ICommand CalculateCommand => new Command(Calculate);

        private void Calculate()
        {
            // Lógica para realizar los cálculos
            Result = FirstNumber + SecondNumber; // Ejemplo de suma
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using WPF_workshopexo2.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace WPF_workshopexo2.VuModel
{
    internal class VuModele : ViewModelBase
    {
        private string _userInput;


        public string UserInput
        {
            get => UserInput;
            set
            {
                Set(ref _userInput, value);
                RaisePropertyChanged(nameof(UserInput));
            }
        }
        private string _result;
        public string Result
        {
            get => _result;
            set
            {
                Set(ref _result, value);
                RaisePropertyChanged(nameof(Result));
            }
        }
        public ICommand ConvertCommand { get; }
        public VuModele()
        {
            ConvertCommand = new RelayCommand(convert);
        }
        public void convert()
        {
            Modele model=new Modele();
            Result = model.toupper(UserInput);
        }

    }
}


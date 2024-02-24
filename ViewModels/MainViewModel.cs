using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace CommunityToolkit.Mvvm.Practice.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        //[ObservableProperty]
        //private string _textBox;

        //[ObservableProperty]
        //private string _textBlock;

        //[RelayCommand]
        //public void ClickOnButton()
        //{
        //    TextBlock = TextBox;
        //}

        private string _textBox;
        public string TextBox
        {
            get => _textBox;
            set => SetProperty(ref _textBox, value);
        }

        private string _textBlock;
        public string TextBlock
        {
            get => _textBlock;
            set => SetProperty(ref _textBlock, value);
        }

        public MainViewModel()
        {
            ClickOnButtonCommand = new RelayCommand(ClickOnButton);
        }
        public ICommand ClickOnButtonCommand { get; }
        private void ClickOnButton() => TextBlock = TextBox;
    }
}

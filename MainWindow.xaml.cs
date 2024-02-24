using CommunityToolkit.Mvvm.Practice.ViewModels;
using System.Windows;

namespace CommunityToolkit.Mvvm.Practice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainViewModel ViewModel { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            ViewModel = new MainViewModel();
            DataContext = ViewModel;
        }
    }
}
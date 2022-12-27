using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Introduction2
{
    /// <summary>
    /// Interaction logic for DynamicDataWindow.xaml
    /// </summary>
    public partial class DynamicDataWindow : Window, INotifyPropertyChanged
    {
        public ButtonClickViewModel ViewModel;

        public DynamicDataWindow()
        {
            InitializeComponent();

            ViewModel = new ButtonClickViewModel();

            DataContext = ViewModel;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.IncrementClicks();
        }
    }
}

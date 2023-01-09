using Introduction2.ViewModels;
using MahApps.Metro.Controls;
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
    /// Interaction logic for StudentsList.xaml
    /// </summary>
    public partial class StudentsList : MetroWindow, INotifyPropertyChanged
    {

        public StudentsListViewModel StudentsListVM { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;

        public StudentsList()
        {
            InitializeComponent();
            StudentsListVM = new StudentsListViewModel();

            DataContext = StudentsListVM;
        }
    }
}

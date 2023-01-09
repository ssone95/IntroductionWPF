using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction2.ViewModels
{
    public class StudentsListViewModel : INotifyPropertyChanged
    {
        private StudentViewModel selectedStudent;

        public StudentViewModel SelectedStudent
        {
            get { return selectedStudent; }
            set
            {
                if (selectedStudent != value)
                {
                    selectedStudent = value;
                    OnPropertyChanged(nameof(SelectedStudent));

                    HasSelectedStudent = selectedStudent != null;
                }
            }
        }

        private bool hasSelectedStudent;

        public bool HasSelectedStudent
        {
            get { return hasSelectedStudent; }
            set
            {
                if (hasSelectedStudent != value)
                {
                    hasSelectedStudent = value;
                    OnPropertyChanged(nameof(HasSelectedStudent));
                }
            }
        }

        private List<StudentViewModel> students;

        public List<StudentViewModel> Students
        {
            get { return students; }
            set 
            { 
                if(students != value)
                {
                    students = value;
                    OnPropertyChanged(nameof(Students));
                } 
            }
        }

        public StudentsListViewModel()
        {
            Students = new List<StudentViewModel>()
            {
                new StudentViewModel() { Name = "Petar Petrovic", DateOfBirth = DateTime.Now, Active = true },
                new StudentViewModel() { Name = "Petar Petrovic", DateOfBirth = DateTime.Now, Active = true },
                new StudentViewModel() { Name = "Petar Petrovic", DateOfBirth = DateTime.Now, Active = true },
                new StudentViewModel() { Name = "Petar Petrovic", DateOfBirth = DateTime.Now, Active = true },
                new StudentViewModel() { Name = "Petar Petrovic", DateOfBirth = DateTime.Now, Active = true },
                new StudentViewModel() { Name = "Petar Petrovic", DateOfBirth = DateTime.Now, Active = true },
                new StudentViewModel() { Name = "Petar Petrovic", DateOfBirth = DateTime.Now, Active = true },
                new StudentViewModel() { Name = "Petar Petrovic", DateOfBirth = DateTime.Now, Active = true },
                new StudentViewModel() { Name = "Petar Petrovic", DateOfBirth = DateTime.Now, Active = true },
                new StudentViewModel() { Name = "Petar Petrovic", DateOfBirth = DateTime.Now, Active = true },
            };
        }



        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

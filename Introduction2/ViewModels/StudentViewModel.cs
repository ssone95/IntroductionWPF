using Introduction2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction2.ViewModels
{
    public class StudentViewModel : INotifyPropertyChanged
    {
        private Guid id;

        public Guid Id
        {
            get { return id; }
            set
            {
                if (id != value)
                {
                    id = value;
                    OnPropertyChanged(nameof(Id));
                }
            }
        }

        private string uniqueNumber;
        public string UniqueNumber
        {
            get { return uniqueNumber; }
            set
            {
                if (uniqueNumber != value)
                {
                    uniqueNumber = value;
                    OnPropertyChanged(nameof(UniqueNumber));
                }
            }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }


        private string surname;
        public string Surname
        {
            get { return surname; }
            set
            {
                if (surname != value)
                {
                    surname = value;
                    OnPropertyChanged(nameof(Surname));
                }
            }
        }


        private DateTime dateOfBirth = new DateTime(1990, 1, 1);
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set
            {
                if (dateOfBirth != value)
                {
                    dateOfBirth = value;
                    OnPropertyChanged(nameof(DateOfBirth));
                }
            }
        }

        private bool active;
        public bool Active
        {
            get { return active; }
            set
            {
                if (active != value)
                {
                    active = value;
                    OnPropertyChanged(nameof(Active));
                }
            }
        }


        private DateTime updatedAt;
        public DateTime UpdatedAt
        {
            get { return updatedAt; }
            set
            {
                if (updatedAt != value)
                {
                    updatedAt = value;
                    OnPropertyChanged(nameof(UpdatedAt));
                }
            }
        }

        public StudentViewModel() { }

        public StudentViewModel(Student student)
        {
            Id = student.Id;
            UniqueNumber = student.UniqueNumber;
            Name = student.Name;
            Surname = student.Surname;
            DateOfBirth = student.DateOfBirth;
            Active = student.Active;
            UpdatedAt = student.UpdatedAt;
        }

        public StudentViewModel(Guid id, string uniqueNumber, string name, string surname, DateTime dateOfBirth, bool active, DateTime updatedAt)
        {
            Id = id;
            UniqueNumber = uniqueNumber;
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;
            Active = active;
            UpdatedAt = updatedAt;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

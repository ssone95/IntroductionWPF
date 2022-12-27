using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction2
{
    public class ButtonClickViewModel : INotifyPropertyChanged
    {
        private int _Clicks;
        public int Clicks
        {
            get { return _Clicks; }
            set
            {
                if (_Clicks != value)
                {
                    _Clicks = value;
                    OnPropertyChanged(nameof(Clicks));
                }
            }
        }

        private string _Number1;
        public string Number1
        {
            get
            {
                return _Number1;
            }
            set
            {
                if (_Number1 != value) 
                {
                    _Number1 = value;
                    OnPropertyChanged(nameof(Number1));

                    Sum = CalculateSum();
                }
            }
        }


        private string _Number2;
        public string Number2
        {
            get
            {
                return _Number2;
            }
            set
            {
                if (_Number2 != value)
                {
                    _Number2 = value;
                    OnPropertyChanged(nameof(Number2));

                    Sum = CalculateSum();
                }
            }
        }

        private int _Sum;
        public int Sum
        {
            get
            {
                return _Sum;
            }
            set
            {
                if (_Sum != value)
                {
                    _Sum = value;
                    OnPropertyChanged(nameof(Sum));
                }
            }
        }

        private int CalculateSum()
        {
            int val2;
            int val;
            if (Int32.TryParse(_Number1, out val) && Int32.TryParse(_Number2, out val2))
            {
                return val + val2;
            }

            return 0;
        }

        public void IncrementClicks()
        {
            Clicks++;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

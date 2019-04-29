using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ControlListView.ViewModels
{
    public class MultTableModel : INotifyPropertyChanged
    {
        private int _Value;
        public int Value
        {
            get { return this._Value; }
            set
            {
                this._Value = value;
                OnPropertyChanged("Value");
            }
        }
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}

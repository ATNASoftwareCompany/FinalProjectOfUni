using DataModel.Enum;
using DataModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using AppPresenter;

namespace FinalApp.Access.DTOs
{
    public class TreeViewItemModel : INotifyPropertyChanged
    {
        private string _name;
        private int _id;
        private bool _isChecked; // bool, not bool? -- for simple checked/unchecked

        public string Name
        {
            get => _name;
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        public int Id
        {
            get => _id;
            set
            {
                if (_id != value)
                {
                    _id = value;
                    OnPropertyChanged(nameof(Id));
                }
            }
        }

        public bool IsChecked
        {
            get => _isChecked;
            set
            {
                // Only update and notify if the value has actually changed
                if (_isChecked != value)
                {
                    _isChecked = value;
                    OnPropertyChanged(nameof(IsChecked));
                    // No more recursive calls or parent/child logic here!
                }
            }
        }

        // Note: Children and Parent properties are completely removed as they are not
        // needed for a flat tree structure, which was causing the StackOverflow.

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

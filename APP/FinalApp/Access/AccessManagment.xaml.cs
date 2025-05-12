using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace FinalApp.Access
{
    /// <summary>
    /// Interaction logic for AccessManagment.xaml
    /// </summary>
    public partial class AccessManagment : Window
    {
        public AccessManagment()
        {
            InitializeComponent();
        }
        
        
        
        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            //if (sender is CheckBox checkBox && checkBox.DataContext is AccessItem item)
            //{
            //    // You can access the unchecked item here.
            //    // MessageBox.Show($"Unchecked: {item.Name}");
            //    // No need to set IsChecked, it's already done by TwoWay binding
            //}
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            //if (sender is CheckBox checkBox && checkBox.DataContext is AccessItem item)
            //{
            //    // You can access the checked item here.  For example:
            //    // MessageBox.Show($"Checked: {item.Name}");
            //    // No need to set IsChecked, it's already done by TwoWay binding
            //}
        }
    }
}

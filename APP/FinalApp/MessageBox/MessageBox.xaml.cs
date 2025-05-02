using DataModel.ViewModel;
using System;
using System.Collections.Generic;
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

namespace FinalApp.MessageBox
{
    /// <summary>
    /// Interaction logic for MessageBox.xaml
    /// </summary>
    public partial class MessageBox : Window
    {
        public MessageBox()
        {
            InitializeComponent();
        }

        bool ok = false;
        bool yes = false;

        public void Show(MessageBox_VM inputModel)
        {

            if (inputModel.ErrorType == DataModel.Enum.ErrorType.Warning)
            {
                gridbase.Background = Brushes.Beige;
                imgIcon.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri("/Images/icons8-warning-40.png", UriKind.Relative));
            }

            if (inputModel.ErrorType == DataModel.Enum.ErrorType.Error)
            {
                gridbase.Background = Brushes.IndianRed;
                imgIcon.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri("/Images/icons8-error-40.png", UriKind.Relative));
            }

            lblTextTitle.Content = inputModel.Title;
            lblTextInfo.Content = inputModel.Message;

            if (inputModel.Yes)
            {
                btnYes.Visibility = Visibility.Visible;
            }

            if (inputModel.No)
            {
                btnNo.Visibility = Visibility.Visible;
            }

            if (inputModel.OK)
            {
                btnOk.Visibility = Visibility.Visible;
            }

            if (inputModel.Cancel)
            {
                btnCancle.Visibility = Visibility.Visible;
            }
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            ok = true;
        }
        private void btnYes_Click(object sender, RoutedEventArgs e)
        {
            yes = true;
        }

        private void btnCancle_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnNo_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}

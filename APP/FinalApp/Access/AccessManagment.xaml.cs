using AppPresenter;
using DataModel.Enum;
using DataModel.ViewModel;
using FinalApp.Access.DTOs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace FinalApp.Access
{
    /// <summary>
    /// Interaction logic for AccessManagment.xaml
    /// </summary>
    public partial class AccessManagment : Window
    {
        AppPresenter.AppPresenter _presenter;
        MessageBox _msgBox;
        List<int> actions = new List<int>();
        AccessOperation accessData;
        List<Access_VM> UserAccess;
        List<AccessOperation> accessOperations;
        List<Access_VM> ChangedAccess = new List<Access_VM>();
        public AccessManagment()
        {
            InitializeComponent();
            _presenter = new AppPresenter.AppPresenter();
            _msgBox = new MessageBox();
        }

        

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            GenerateActions();
            UserAccess = new AppPresenter.AppPresenter().GetUserAccessList(MainWindow.UserId).Result as List<Access_VM>;
            var result = GetAccesses(new AppPresenter.AppPresenter().GetUserAccessList(MainWindow.UserId).Result as List<Access_VM>);
            listView.ItemsSource = result;
        }

        public void GenerateActions()
        {
            var count = _presenter.GetActionsCount(0).Result;
            if (Convert.ToInt32(count) > 0)
            {
                return;
            }
            List<Action_VM> actions = new List<Action_VM>();
            var result = _presenter.GenerateEnumToObject("");
            foreach (var item in result.Result as List<EnumInfo>)
            {
                Action_VM action = new Action_VM
                {
                    ActionCode = item.Value,
                    ActionName = item.Description,
                    IsDelete = false,
                    Status = (int)BStatus.Active,
                    InsertDate = DateTime.Now,
                };
                actions.Add(action);
            }
            
            result = _presenter.InsertActions(actions);
        }

        
        private List<AccessOperation> GetAccesses(List<Access_VM> inputModel)
        {
            accessOperations = new List<AccessOperation>();
            AccessOperation access;
            for (int i = 0; i < inputModel.Count; i++)
            {
                access = new AccessOperation();
                access.AccessId = inputModel[i].Id;
                access.ActionCode = inputModel[i].ActionCode.ActionCode;
                access.ActionName = inputModel[i].ActionCode.ActionName;
                access._isSelected = false;
                if (inputModel[i].Status == (int)BStatus.Active)
                {
                    access._isSelected = true;
                }
                accessOperations.Add(access);
            }
            return accessOperations;
        }

        public class AccessOperation : INotifyPropertyChanged
        {
            public event PropertyChangedEventHandler PropertyChanged;
            protected void OnPropertyChanged(string propertyName)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            public int AccessId { get; set; }

            public int ActionCode { get; set; }
            public string ActionName { get; set; }
            public bool _isSelected;
            public bool IsSelected
            {
                get { return _isSelected; }
                set
                {
                    _isSelected = value;
                    OnPropertyChanged(nameof(IsSelected));
                }
            }
        }

        private static T GetVisualAncelator<T>(DependencyObject o) where T : DependencyObject
        {
            do
            {
                o = VisualTreeHelper.GetParent(o);
            } while (o != null && !typeof(T).IsAssignableFrom(o.GetType()));
            return (T)o;
        }
        
        private void chkBox_Checked(object sender, RoutedEventArgs e)
        {
            ListViewItem listViewItem = GetVisualAncelator<ListViewItem>((DependencyObject)sender);
            listView.SelectedItem = listView.ItemContainerGenerator.ItemFromContainer(listViewItem);
            accessData = (AccessOperation)listView.SelectedItem;
            Access_VM access_VM = UserAccess.Where(x => x.Id == accessData.AccessId).First();
            access_VM.Status = (int)BStatus.Active;
            ChangedAccess.Add(access_VM);
        }

        private void chkBox_Unchecked(object sender, RoutedEventArgs e)
        {
            ListViewItem listViewItem = GetVisualAncelator<ListViewItem>((DependencyObject)sender);
            listView.SelectedItem = listView.ItemContainerGenerator.ItemFromContainer(listViewItem);
            accessData = (AccessOperation)listView.SelectedItem;
            Access_VM access_VM = UserAccess.Where(x => x.Id == accessData.AccessId).First();
            access_VM.Status = (int)BStatus.DeActiva;
            ChangedAccess.Add(access_VM);
        }



        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var result = _presenter.UpdateAccessList(ChangedAccess);
            _msgBox.Show(new MessageBox_VM
            {
                OK = true,
                ErrorType = ErrorType.Sussess,
                Message = result.Message,
                Title = "بروزرسانی دسترسی ها"
            });
            return;
        }
    }
}

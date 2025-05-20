using DataModel;
using FinalApp.Users.DTOs;
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

namespace FinalApp.Users
{
    /// <summary>
    /// Interaction logic for UsersManagment.xaml
    /// </summary>
    public partial class UsersManagment : Window
    {
        AppPresenter.AppPresenter _presenter;
        MessageBox _msgBox;
        public UsersManagment()
        {
            InitializeComponent();
            _presenter = new AppPresenter.AppPresenter();
            _msgBox = new MessageBox();
        }

        public void GetPersonList()
        {
            var result = _presenter.GetPersonList(0);
            int rowNumber = 0;
            List<Person_VM> list = result.Result as List<Person_VM>;
            List<PersonDto>dtoList = new List<PersonDto>();
            foreach (Person_VM item in list)
            {
                rowNumber++;
                PersonDto dto = new PersonDto
                {
                    BirthDate = item.BirthDate,
                    E_Mail = item.E_Mail,
                    Family = item.Family,
                    Name = item.Name,
                    InsertDate = item.InsertDate,
                    IsDelete = item.IsDelete,
                    PhoneNo = item.PhoneNo,
                    RowNumber = rowNumber,
                    UpdateDate = item.UpdateDate,
                };
                if (item.Status == 10)
                {
                    dto.StatusStr = "در انتظار فعالسازی";
                }else if (item.Status == 1)
                {
                    dto.StatusStr = "فعال";
                }
                else
                {
                    dto.StatusStr = "غیرفعال";
                }
                dtoList.Add(dto);
            }
            prsGrid.ItemsSource = null;
            prsGrid.ItemsSource = dtoList;
        }

        public void GetUserList()
        {
            var result = _presenter.GetUserList(0);
            List<User_VM> list = result.Result as List<User_VM>;
            int rowNumber = 0;
            List<UserDto> dtoList = new List<UserDto>();
            foreach (var item in list)
            {
                rowNumber++;
                UserDto dto = new UserDto
                {
                    UserName = item.UserName,
                    InsertDate = item.InsertDate,
                    IsDelete = item.IsDelete,
                    RowNumber = rowNumber,
                    UpdateDate = item.UpdateDate,
                };
                dto.StatusStr = "غیرفعال";
                if (item.Status == 1)
                {
                    dto.StatusStr = "فعال";
                }
                dtoList.Add(dto);
            }

            userGrid.ItemsSource = null;
            userGrid.ItemsSource = dtoList;
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            GetUserList();
            GetPersonList();
        }
    }
}

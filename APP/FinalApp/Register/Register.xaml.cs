using DataModel;
using DataModel.Enum;
using DataModel.ViewModel;
using FinalApp;
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


namespace FinalApp
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        AppPresenter.AppPresenter _presenter;
        MessageBox msgBox;
        public Register()
        {
            InitializeComponent();
            _presenter = new AppPresenter.AppPresenter();
            msgBox = new MessageBox();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            Authentication();
            RegisterPerson();
            Autenticate autenticate = new Autenticate();
            autenticate.PhoneNo = txtMobile.Text.Trim();
            autenticate.authenticateType = DataModel.Enum.AuthenticateType.Register;
            autenticate.ShowDialog();
            //MainWindow mainWindow = new MainWindow();
            //mainWindow.Show();
            this.Close();
        }

        private void RegisterPerson()
        {
            if (txtConfirmPassword.Password != txtPassword.Password)
            {
                msgBox.Show(new DataModel.ViewModel.MessageBox_VM
                {
                    ErrorType = DataModel.Enum.ErrorType.Warning,
                    OK = true,
                    Message = "لطفا در وارد نمودن کلمه عبور و تکرار آن دقت فرمایید",
                    Title = "ثبت نام"
                });
                return;
            }

            FinalApp.RegisterDTO registerDTO = new FinalApp.RegisterDTO
            {
                PhoneNo = txtMobile.Text.Trim(),
                Name = txtName.Text.Trim(),
                Family = txtFamily.Text.Trim(),
                BirthDate = txtBirthDate.Text.Trim(),
                E_Mail = txtEmail.Text.Trim(),
                Password = txtPassword.Password,
            };

            Person_VM person = new Person_VM
            {
                PhoneNo = registerDTO.PhoneNo,
                Name = registerDTO.Name,
                Family = registerDTO.Family,
                BirthDate = registerDTO.BirthDate,
                E_Mail = registerDTO.E_Mail,
                Status = (int)PersonStatus.WaitForActive,
            };

            var result = _presenter.InsertPerson(person);
            if (result.ErrorCode != 0)
            {
                msgBox.Show(new DataModel.ViewModel.MessageBox_VM
                {
                    ErrorType = DataModel.Enum.ErrorType.Error,
                    OK = true,
                    Message = result.Message,
                    Title = "ثبت نام"
                });
                return;
            }

            User_VM user = new User_VM
            {
                IsDelete = false,
                Status = (int)UserStatus.AciveateWating,
                UserName = registerDTO.PhoneNo,
                Password = registerDTO.Password,
            };

            result = _presenter.InsertUser(user);
            if (result.ErrorCode != 0)
            {
                msgBox.Show(new DataModel.ViewModel.MessageBox_VM
                {
                    ErrorType = DataModel.Enum.ErrorType.Error,
                    OK = true,
                    Message = result.Message,
                    Title = "ثبت نام"
                });
                return;
            }
            List<AccessType> accessTypes = new List<AccessType>
            {
                AccessType.InsertPerson ,
                AccessType.InsertUser ,
                AccessType.InsertBook,
                AccessType.UserAuthentication,
                AccessType.UpdateUser ,
                AccessType.UpdateBook,
                AccessType.UpdateActivation,
                AccessType.UpdateBookGenre,
                AccessType.UpdateBookAuthor,
                AccessType.UpdateBookPublisher,
                AccessType.LoginToBookManagmentPage,
            };
            List<Access_VM> accesses = new List<Access_VM>();
            foreach (AccessType accessType in accessTypes)
            {
                EnumInfo @enum = _presenter.GenerateEnumToObject(Convert.ToInt32(accessType)).Result as EnumInfo;
                Access_VM access = new Access_VM
                {
                    ActionCode = new Action_VM
                    {
                        ActionCode = @enum.Value,
                        ActionName = @enum.Description
                    },
                    UserId = (int)result.Result,
                    IsDelete = false,
                    Status = (int)BStatus.Active,
                    InsertDate = DateTime.Now,
                };
                accesses.Add(access);
            }
            var saveAccess = _presenter.InsertAccess(accesses);
            if ((int)saveAccess.ErrorCode != 0)
            {
                msgBox.Show(new DataModel.ViewModel.MessageBox_VM
                {
                    ErrorType = DataModel.Enum.ErrorType.Error,
                    OK = true,
                    Message = "خطا در درج دسترسی های کاربر",
                    Title = "ثبت نام"
                });
                return;
            }
            msgBox.Show(new DataModel.ViewModel.MessageBox_VM
            {
                ErrorType = DataModel.Enum.ErrorType.Sussess,
                OK = true,
                Message = "عملیات با موفقیت انجام شد",
                Title = "ثبت نام"
            });
        }

        private void Authentication()
        {
            var result = _presenter.UserAuthentication(txtMobile.Text.Trim());
            if (result.ErrorCode != 0)
            {
                msgBox.Show(new DataModel.ViewModel.MessageBox_VM
                {
                    ErrorType = DataModel.Enum.ErrorType.Error,
                    OK = true,
                    Message = result.Message,
                    Title = "ثبت نام"
                });
                return;
            }
        }
    }
}

using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight;
using MaterialDesignThemes.Wpf;
using System;
using System.Threading;
using System.Threading.Tasks;
using Expenses.Domain.Models;

namespace Expenses.UI.ViewModel
{
    public class UserViewModel : ViewModelBase
    {
        #region Private members

        private User _user;

        #endregion

        #region .ctor

        public UserViewModel()
        {

        }

        public UserViewModel(User _user)
        {
            User = _user;
        }

        #endregion

        #region Properties

        public User User
        {
            get
            {
                return _user;
            }
            set
            {
                if (_user != value)
                {
                    FillProperties(value);
                    RaisePropertyChanged(() => User);
                }
            }
        }

        public int Id
        {
            get
            {
                return _user.Id;
            }
            set
            {
                if (_user.Id != value)
                {
                    RaisePropertyChanged(() => Id);
                }
            }
        }

        public string Login
        {
            get
            {
                return _user.Login;
            }
            set
            {
                if (_user.Login != value)
                {
                    RaisePropertyChanged(() => Login);
                }
            }
        }

        public string Password
        {
            get
            {
                return _user.Password;
            }
            set
            {
                if (_user.Password != value)
                {
                    RaisePropertyChanged(() => Password);
                }
            }
        }

        public string Name
        {
            get
            {
                return _user.Surname;
            }
            set
            {
                if (_user.Surname != value)
                {
                    RaisePropertyChanged(() => Name);
                }
            }
        }

        public string Surname
        {
            get
            {
                return _user.Surname;
            }
            set
            {
                if (_user.Surname != value)
                {
                    RaisePropertyChanged(() => Surname);
                }
            }
        }

        public int? Age
        {
            get
            {
                return _user.Age;
            }
            set
            {
                if (_user.Age != value)
                {
                    RaisePropertyChanged(() => Age);
                }
            }
        }

        #endregion

        #region Methods

        private void FillProperties(User user)
        {
            Id = user.Id;
            Login = user.Login;
            Password = user.Password;
            Name = user.Name;
            Surname = user.Surname;
            Age = user.Age;
        }

        #endregion
    }
}

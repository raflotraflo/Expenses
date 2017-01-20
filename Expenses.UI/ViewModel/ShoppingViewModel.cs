using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight;
using MaterialDesignThemes.Wpf;
using System;
using System.Threading;
using System.Threading.Tasks;
using Expenses.Domain.Models;

namespace Expenses.UI.ViewModel
{
    class ShoppingViewModel : ViewModelBase
    {
        #region Private members

        private Shopping _shopping;

        #endregion

        #region .ctor

        public ShoppingViewModel()
        {

        }

        public ShoppingViewModel(Shopping shopping)
        {
            Shopping = shopping;
        }

        #endregion

        #region Properties

        public Shopping Shopping
        {
            get
            {
                return _shopping;
            }
            set
            {
                if (_shopping != value)
                {
                    FillProperties(value);
                    RaisePropertyChanged(() => Shopping);
                }
            }
        }

        public int Id
        {
            get
            {
                return _shopping.Id;
            }
            set
            {
                if (_shopping.Id != value)
                {
                    RaisePropertyChanged(() => Id);
                }
            }
        }

        public string Login
        {
            get
            {
                return _shopping.Login;
            }
            set
            {
                if (_shopping.Login != value)
                {
                    RaisePropertyChanged(() => Login);
                }
            }
        }

        public string Password
        {
            get
            {
                return _shopping.Password;
            }
            set
            {
                if (_shopping.Password != value)
                {
                    RaisePropertyChanged(() => Password);
                }
            }
        }

        public string Name
        {
            get
            {
                return _shopping.Surname;
            }
            set
            {
                if (_shopping.Surname != value)
                {
                    RaisePropertyChanged(() => Name);
                }
            }
        }

        public string Surname
        {
            get
            {
                return _shopping.Surname;
            }
            set
            {
                if (_shopping.Surname != value)
                {
                    RaisePropertyChanged(() => Surname);
                }
            }
        }

        public int? Age
        {
            get
            {
                return _shopping.Age;
            }
            set
            {
                if (_shopping.Age != value)
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

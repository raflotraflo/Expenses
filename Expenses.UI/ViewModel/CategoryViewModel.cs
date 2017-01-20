using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight;
using MaterialDesignThemes.Wpf;
using System;
using System.Threading;
using System.Threading.Tasks;
using Expenses.Domain.Models;

namespace Expenses.UI.ViewModel
{
    public class CategoryViewModel : ViewModelBase
    {
        private Category _category;


        public CategoryViewModel()
        {

        }

        public CategoryViewModel(Category category)
        {
            _category = category;
        }


        public Category Category
        {
            get
            {
                return _category;
            }
            set
            {
                if (_category != value)
                {
                    FillProperties(value);
                    RaisePropertyChanged(() => Category);
                }
            }
        }

        public int Id
        {
            get
            {
                return _category.Id;
            }
            set
            {
                if (_category.Id != value)
                {
                    RaisePropertyChanged(() => Id);
                }
            }
        }

        public string Name
        {
            get
            {
                return _category.Name;
            }
            set
            {
                if (_category.Name != value)
                {
                    RaisePropertyChanged(() => Name);
                }
            }
        }

        #region Methods

        private void FillProperties(Category category)
        {
            Id = category.Id;
            Name = category.Name;
        }

        #endregion
    }
}

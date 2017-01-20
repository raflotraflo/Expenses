using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight;
using MaterialDesignThemes.Wpf;
//using SFCSDevicesGateway.Core.Enums;
//using SFCSDevicesGateway.Core.Helpers;
//using SFCSDevicesGateway.Core.Pipe;
//using SFCSDevicesGateway.UI.Managers;
//using SFCSDevicesGateway.UI.Helpers;
//using SFCSDevicesGateway.UI.View;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Expenses.UI.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
        }

        public bool IsActive { get; set; }
    }
}

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using Autofac;
using MaterialDesignColors;
using System;
using MaterialDesignThemes.Wpf;
using System.Linq;

namespace Expenses.UI.ViewModel
{

    public class ViewModelLocator
    {
        #region Private members

        public readonly IContainer container;

        #endregion Private members

        #region .ctor

        public ViewModelLocator()
        {
            //set correct path
            //System.IO.Directory.SetCurrentDirectory(System.AppDomain.CurrentDomain.BaseDirectory);

            //load Theme configuration

            new PaletteHelper().SetLightDark(Properties.Settings.Default.ThemeBase);

            if (Properties.Settings.Default.ThemeAccent != string.Empty)
            {
                try
                {
                    Swatch swatch = new SwatchesProvider().Swatches.Where(s => s.Name == Properties.Settings.Default.ThemeAccent).First();
                    new PaletteHelper().ReplaceAccentColor(swatch);
                }
                catch (Exception) { }
            }

            if (Properties.Settings.Default.ThemePrimary != string.Empty)
            {
                try
                {
                    Swatch swatch = new SwatchesProvider().Swatches.Where(s => s.Name == Properties.Settings.Default.ThemePrimary).First();
                    new PaletteHelper().ReplacePrimaryColor(swatch);
                }
                catch (Exception) { }
            }


            ////if (ViewModelBase.IsInDesignModeStatic)
            ////{
            ////    // Create design time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DesignDataService>();
            ////}
            ////else
            ////{
            ////    // Create run time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DataService>();
            ////}

            ContainerBuilder containerBulider = new ContainerBuilder();

            containerBulider.RegisterType<MainViewModel>().SingleInstance();
            containerBulider.RegisterType<ThemeViewModel>().SingleInstance();
            containerBulider.RegisterType<RootViewModel>().SingleInstance();

            container = containerBulider.Build();
        }

        #endregion

        #region Properties

        public ThemeViewModel ThemeVM
        {
            get
            {
                return container.Resolve<ThemeViewModel>();
            }
        }

        public RootViewModel RootVM
        {
            get
            {
                return container.Resolve<RootViewModel>();
            }
        }

        public MainViewModel MainVM
        {
            get
            {
                return container.Resolve<MainViewModel>();
            }
        }

        //public ApplicationSettingsViewModel ApplicationSettingsVM
        //{
        //    get
        //    {
        //        return container.Resolve<ApplicationSettingsViewModel>();
        //    }
        //}
        #endregion Properties

        #region Methods
        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
        #endregion Methods
    }
}
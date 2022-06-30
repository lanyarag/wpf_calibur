using System.Windows;
using Caliburn.Micro;
using wpfapp.ViewModels;


namespace wpfapp
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            base.Initialize();
        }
        protected override void OnStartup(object sender, StartupEventArgs e)

        {
            base.DisplayRootViewFor<MainViewModel>();
        }
    }
}

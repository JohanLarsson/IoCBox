namespace IoCBox
{
    using System.Reflection;
    using System.Windows;
    using Ninject; 
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            var kernel = new StandardKernel();
            kernel.Bind<IModel, Model>().To<Model>();
            kernel.Bind<IVm, Vm>().To<Vm>().InSingletonScope();
            kernel.Bind<ILogger, Logger>().To<Logger>().InSingletonScope();
            var window = kernel.Get<Window1>();
            window.Show();
            var window2 = kernel.Get<Window2>();
            window2.Show();
        }
    }
}

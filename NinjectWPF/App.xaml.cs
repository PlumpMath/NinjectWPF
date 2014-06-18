namespace NinjectWPF
{
    using System.Windows;

    using Ninject;

    /// <summary>
    ///     Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        #region Fields

        private IKernel container;

        #endregion

        #region Methods

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            this.ConfigureContainer();
            this.ComposeObjects();
            Current.MainWindow.Show();
        }

        private void ConfigureContainer()
        {
            this.container = new StandardKernel();
            this.container.Bind<IOpenGlProvider>().To<OpenGlProvider>().InSingletonScope();
            this.container.Bind<IWorldManager>().To<WorldManager>().InSingletonScope();
            this.container.Bind<IShapeProvider>().To<ShapeProvider>();
            this.container.Bind<IShapeManager>().To<ShapeManager>();
        }

        private void ComposeObjects()
        {
            Current.MainWindow = this.container.Get<MainWindow>();
            Current.MainWindow.Title = "DI with Ninject";
        }

        #endregion
    }
}
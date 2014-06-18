namespace NinjectWPF
{
    using Ninject;

    using SharpGL.SceneGraph;

    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        #region Constructors and Destructors

        public MainWindow()
        {
            this.InitializeComponent();
        }

        #endregion

        #region Public Properties

        [Inject]
        public IOpenGlProvider OpenGlProvider { get; set; }

        [Inject]
        public IWorldManager WorldManager { get; set; }

        #endregion

        #region Methods

        private void OpenGlControlOpenGlDraw(object sender, OpenGLEventArgs args)
        {
            // Get the OpenGL instance that's been passed to us.
            var gl = this.OpenGlProvider.GetOpenGlContext();

            this.WorldManager.DrawWorld(gl);
        }

        #endregion
    }
}
namespace NinjectWPF
{
    using SharpGL;

    internal class OpenGlProvider : IOpenGlProvider
    {
        #region Public Methods and Operators

        public OpenGL GetOpenGlContext()
        {
            return new OpenGL();
        }

        #endregion
    }
}
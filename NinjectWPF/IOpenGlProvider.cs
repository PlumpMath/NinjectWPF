namespace NinjectWPF
{
    using SharpGL;

    public interface IOpenGlProvider
    {
        #region Public Methods and Operators

        OpenGL GetOpenGlContext();

        #endregion
    }
}
namespace NinjectWPF
{
    using SharpGL;

    public interface IWorldManager
    {
        #region Public Methods and Operators

        void DrawWorld(OpenGL gl);

        #endregion
    }
}
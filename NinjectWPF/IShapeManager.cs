namespace NinjectWPF
{
    using SharpGL;

    public interface IShapeManager
    {
        #region Public Methods and Operators

        void AddShape(Shape shape);

        void ClearShapes();

        void DrawShapes(OpenGL gl);

        #endregion
    }
}
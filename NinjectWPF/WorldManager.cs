namespace NinjectWPF
{
    using Ninject;

    using SharpGL;

    internal class WorldManager : IWorldManager
    {
        #region Fields

        private float rotatePyramid = 0;

        private float rquad = 0;

        #endregion

        #region Public Properties

        [Inject]
        public IShapeProvider ShapeProvider { get; set; }

        [Inject]
        public IShapeManager ShapeManager { get; set; }

        #endregion

        #region Public Methods and Operators

        public void DrawWorld(OpenGL gl)
        {
            // Clear the color and depth buffers.
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);

            // Reset the modelview matrix.
            gl.LoadIdentity();

            // Move the geometry into a fairly central position.
            gl.Translate(-1.5f, 0.0f, -6.0f);

            // Draw a pyramid. First, rotate the modelview matrix.
            gl.Rotate(this.rotatePyramid, 0.0f, 1.0f, 0.0f);

            // Start drawing triangles.
            gl.Begin(OpenGL.GL_TRIANGLES);

            var pyramid = this.ShapeProvider.GetShape(ShapeType.Pyramid);
            this.ShapeManager.AddShape(pyramid);
            this.ShapeManager.DrawShapes(gl);
            
            gl.End();

            // Reset the modelview.
            gl.LoadIdentity();

            // Move into a more central position.
            gl.Translate(1.5f, 0.0f, -7.0f);

            // Rotate the cube.
            gl.Rotate(this.rquad, 1.0f, 1.0f, 1.0f);

            // Provide the cube colors and geometry.
            gl.Begin(OpenGL.GL_QUADS);

            var cube = this.ShapeProvider.GetShape(ShapeType.Cube);
            this.ShapeManager.AddShape(cube);
            this.ShapeManager.DrawShapes(gl);

            gl.End();

            // Flush OpenGL.
            gl.Flush();

            // Rotate the geometry a bit.
            this.rotatePyramid += 3.0f;
            this.rquad -= 3.0f;
        }

        #endregion
    }
}
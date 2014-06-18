namespace NinjectWPF
{
    using System.Collections.Generic;

    using SharpGL;

    internal class ShapeManager : IShapeManager
    {
        #region Fields

        private readonly List<Shape> shapes = new List<Shape>();

        #endregion

        #region Public Methods and Operators

        public void AddShape(Shape shape)
        {
            this.shapes.Add(shape);
        }

        public void ClearShapes()
        {
            this.shapes.Clear();
        }

        public void DrawShapes(OpenGL gl)
        {
            foreach (var shape in this.shapes)
            {
                if (shape.Drawn)
                {
                    continue;
                }

                var vertsPerColor = shape.Vertices.Count / shape.Colors.Count;
                for (var i = 0; i < shape.Colors.Count; i++)
                {
                    gl.Color(shape.Colors[i].X, shape.Colors[i].Y, shape.Colors[i].Z);

                    for (var j = i * vertsPerColor; j < (i * vertsPerColor) + vertsPerColor; j++)
                    {
                        gl.Vertex(shape.Vertices[j].X, shape.Vertices[j].Y, shape.Vertices[j].Z);
                    }
                }

                shape.Drawn = true;
            }
        }

        #endregion
    }
}
namespace NinjectWPF
{
    using System.Collections.Generic;

    internal class ShapeProvider : IShapeProvider
    {
        #region Public Methods and Operators

        public Shape GetShape(ShapeType type)
        {
            switch (type)
            {
                case ShapeType.Cube:
                    return GetCube();
                case ShapeType.Pyramid:
                    return GetPyramid();
                default:
                    return GetCube();
            }
        }

        #endregion

        #region Methods

        private static Shape GetCube()
        {
            return new Shape
                       {
                           Vertices =
                               new List<Vector3>
                                   {
                                       new Vector3(1.0f, 1.0f, -1.0f), 
                                       new Vector3(-1.0f, 1.0f, -1.0f), 
                                       new Vector3(-1.0f, 1.0f, 1.0f), 
                                       new Vector3(1.0f, 1.0f, 1.0f), 
                                       new Vector3(1.0f, -1.0f, 1.0f), 
                                       new Vector3(-1.0f, -1.0f, 1.0f), 
                                       new Vector3(-1.0f, -1.0f, -1.0f), 
                                       new Vector3(1.0f, -1.0f, -1.0f), 
                                       new Vector3(1.0f, 1.0f, 1.0f), 
                                       new Vector3(-1.0f, 1.0f, 1.0f), 
                                       new Vector3(-1.0f, -1.0f, 1.0f), 
                                       new Vector3(1.0f, -1.0f, 1.0f), 
                                       new Vector3(1.0f, -1.0f, -1.0f), 
                                       new Vector3(-1.0f, -1.0f, -1.0f), 
                                       new Vector3(-1.0f, 1.0f, -1.0f), 
                                       new Vector3(1.0f, 1.0f, -1.0f), 
                                       new Vector3(-1.0f, 1.0f, 1.0f), 
                                       new Vector3(-1.0f, 1.0f, -1.0f), 
                                       new Vector3(-1.0f, -1.0f, -1.0f), 
                                       new Vector3(-1.0f, -1.0f, 1.0f), 
                                       new Vector3(1.0f, 1.0f, -1.0f), 
                                       new Vector3(1.0f, 1.0f, 1.0f), 
                                       new Vector3(1.0f, -1.0f, 1.0f), 
                                       new Vector3(1.0f, -1.0f, -1.0f)
                                   }, 
                           Colors =
                               new List<Vector3>
                                   {
                                       new Vector3(0.0f, 1.0f, 0.0f), 
                                       new Vector3(1.0f, 0.5f, 0.0f), 
                                       new Vector3(1.0f, 0.0f, 0.0f), 
                                       new Vector3(1.0f, 1.0f, 0.0f), 
                                       new Vector3(0.0f, 0.0f, 1.0f), 
                                       new Vector3(1.0f, 0.0f, 1.0f)
                                   }
                       };
        }

        private static Shape GetPyramid()
        {
            return new Shape
                       {
                           Vertices =
                               new List<Vector3>
                                   {
                                       new Vector3(0.0f, 1.0f, 0.0f), 
                                       new Vector3(-1.0f, -1.0f, 1.0f), 
                                       new Vector3(1.0f, -1.0f, 1.0f), 
                                       new Vector3(0.0f, 1.0f, 0.0f), 
                                       new Vector3(1.0f, -1.0f, 1.0f), 
                                       new Vector3(1.0f, -1.0f, -1.0f), 
                                       new Vector3(0.0f, 1.0f, 0.0f), 
                                       new Vector3(1.0f, -1.0f, -1.0f), 
                                       new Vector3(-1.0f, -1.0f, -1.0f), 
                                       new Vector3(0.0f, 1.0f, 0.0f), 
                                       new Vector3(-1.0f, -1.0f, -1.0f), 
                                       new Vector3(-1.0f, -1.0f, 1.0f)
                                   }, 
                           Colors =
                               new List<Vector3>()
                                   {
                                       new Vector3(1.0f, 0.0f, 0.0f), 
                                       new Vector3(0.0f, 1.0f, 0.0f), 
                                       new Vector3(0.0f, 0.0f, 1.0f), 
                                       new Vector3(1.0f, 0.0f, 0.0f), 
                                       new Vector3(0.0f, 0.0f, 1.0f), 
                                       new Vector3(0.0f, 1.0f, 0.0f), 
                                       new Vector3(1.0f, 0.0f, 0.0f), 
                                       new Vector3(0.0f, 1.0f, 0.0f), 
                                       new Vector3(0.0f, 0.0f, 1.0f), 
                                       new Vector3(1.0f, 0.0f, 0.0f), 
                                       new Vector3(0.0f, 0.0f, 1.0f), 
                                       new Vector3(0.0f, 1.0f, 0.0f)
                                   }
                       };
        }

        #endregion
    }
}
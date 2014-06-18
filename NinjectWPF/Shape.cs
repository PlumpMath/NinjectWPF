namespace NinjectWPF
{
    using System.Collections.Generic;

    public class Shape
    {
        #region Public Properties

        public List<Vector3> Colors { get; set; }

        public List<Vector3> Vertices { get; set; }

        public bool Drawn { get; set; }

        #endregion
    }
}
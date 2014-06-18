namespace NinjectWPF
{
    public class Vector3
    {
        #region Constructors and Destructors

        public Vector3(float x, float y, float z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        #endregion

        #region Public Properties

        public float X { get; set; }

        public float Y { get; set; }

        public float Z { get; set; }

        #endregion
    }
}
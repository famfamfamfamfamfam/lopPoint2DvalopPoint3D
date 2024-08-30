using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace TINHCHATLOP
{
    public class Point3D : Point2D
    {
        private float z = 0.0f;
        public float get_z()
        {
            return z;
        }
        public void set_z(float z)
        {
            this.z = z;
        }
        public Point3D(float x, float y, float z) : base(x,y)
        {
            this.z = z;
        }
        public float[] get_xyz()
        {
            float[] get = {get_x(),get_y(),z};
            return get;
        }
        public void set_xyz(float x, float y, float z)
        {
            base.set_xy(x,y);
            this.z = z;
        }
        public Point3D(){}
        public override string ToString()
        {
            return $"({get_x()},{get_y()},{z})";
        }
    }
}
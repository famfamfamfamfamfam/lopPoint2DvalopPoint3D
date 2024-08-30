namespace TINHCHATLOP
{
    class KiemThu
    {
        static void Main(string[] args)
        {
            Point2D p1 = new Point2D(4.5f,2.2f);
            float[] xy = p1.get_xy();
            Console.WriteLine(p1.ToString()+"\n"+"x="+xy[0]+"\t"+"y="+xy[1]);

            Point3D p2 = new Point3D();
            p2.set_xyz(4.3f,5.6f,7.3f);
            Console.WriteLine(p2.ToString()+"\n"+"x="+p2.get_x()+"\t"+"y="+p2.get_y()+"\t"+"z="+p2.get_z());
        }
    }
}
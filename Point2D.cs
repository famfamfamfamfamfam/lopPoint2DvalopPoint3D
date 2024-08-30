namespace TINHCHATLOP
{
    public class Point2D
    {
        private float x = 0.0f;
        public float get_x()
        {
            return x;
        }
        public void set_x(float x)
        {
            this.x = x;
        }
        private float y = 0.0f;
        public float get_y()
        {
            return y;
        }
        public void set_y(float y)
        {
            this.y = y;
        }
        public Point2D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public float[] get_xy()
        {
            float[] get = {x,y};
            return get;
        }
        public void set_xy(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public Point2D(){}
        public override string ToString()
        {
            return $"({x},{y})";
        }

    }
}
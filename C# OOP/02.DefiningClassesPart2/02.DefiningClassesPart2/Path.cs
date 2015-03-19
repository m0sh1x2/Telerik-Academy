namespace Point3D
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class Path
    {
        private List<PointXYZ> points;

        public List<PointXYZ> Points
        {
            get
            {
                return new List<PointXYZ>(this.points);
            }
        }

        public void AddPointToPath(PointXYZ point)
        {
            this.points.Add(point);
        }

        
    }
}

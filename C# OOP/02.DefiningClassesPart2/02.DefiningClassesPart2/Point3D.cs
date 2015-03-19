using System;

public struct PointXYZ
{
    public double PointX, PointY, PointZ;

    public PointXYZ(double x, double y, double z)
    {
        this.PointX = x;
        this.PointY = y;
        this.PointZ = z;
    }

    private static readonly PointXYZ Start = new PointXYZ(0, 0, 0);
    public static PointXYZ GetStart { get { return Start; } }
    public static double CalculateDistance(PointXYZ A, PointXYZ B)
    {
        double result = Math.Sqrt(Math.Pow(B.PointX - A.PointX, 2) + Math.Pow(B.PointY - A.PointY, 2) + Math.Pow(B.PointZ - A.PointZ, 2));
        return result;
    }
    public override string ToString()
    {
        return string.Format("{0}|{1}|{2}", this.PointX, this.PointY, this.PointZ);
    }
}
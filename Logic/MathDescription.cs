using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGLB2_3
{
    public class MathDescription
    {
        public class Points
        {
            public double x;
            public double y;
            public double z;

            public Points(double _x, double _y, double _z)
            {
                x = _x;
                y = _y;
                z = _z;
            }
            public Points(int _x, int _y, int _z)
            {
                x = _x;
                y = _y;
                z = _z;
            }
            public Points(float _x, float _y, float _z)
            {
                x = _x;
                y = _y;
                z = _z;
            }
            public Points(){}
        }
        //public class Edge
        //{
        //    public int Out;
        //    public int In;
        //    public Edge(int a, int b)
        //    {
        //        Out = b;
        //        In = a;
        //    }
        //    public Edge(){}
        //}
        private static Points RotateX(Points points, double sinDeg, double cosDeg)
        {
            double _y = (points.y * cosDeg) + (points.z * sinDeg);
            double _z = (points.y * -sinDeg) + (points.z * cosDeg);

            return new Points(points.x, _y, _z);
        }
        private static Points RotateY(Points points, double sinDeg, double cosDeg)
        {
            double _x = (points.x * cosDeg) + (points.z * sinDeg);
            double _z = (points.x * -sinDeg) + (points.z * cosDeg);

            return new Points(_x, points.y, _z);
        }
        private static Points RotateZ(Points points, double sinDeg, double cosDeg)
        {
            double _x = (points.x * cosDeg) + (points.y * sinDeg);
            double _y = (points.x * -sinDeg) + (points.y * cosDeg);

            return new Points(_x, _y, points.z);
        }
        public static Points[,] Perspective(Points[,] points)
        {
            const double Zk = 360;
            const double Zpl = 45;
            for (int i = 0; i < points.GetLength(0); i++)
                for (int j = 0; j < points.GetLength(1); j++)
                {
                    double perspective = (Zk - Zpl) / (Zk - points[i, j].z);
                    points[i, j] = new Points(points[i, j].x * perspective, points[i, j].y * perspective, points[i, j].z * perspective);
                }
            return points;
        }
        public static Points[,] RotateX(Points[,] points, double deg)
        {
            double radDeg = (Math.PI * deg) / 180.0;
            double cosDeg = Math.Cos(radDeg);
            double sinDeg = Math.Sin(radDeg);
            for (int i = 0; i < points.GetLength(0); i++)
                for (int j = 0; j < points.GetLength(1); j++)
                    points[i, j] = RotateX(points[i, j], sinDeg, cosDeg);
            return points;
        }
        public static Points[,] RotateY(Points[,] points, double deg)
        {
            double radDeg = (Math.PI * deg) / 180.0;
            double cosDeg = Math.Cos(radDeg);
            double sinDeg = Math.Sin(radDeg);
            for (int i = 0; i < points.GetLength(0); i++)
                for (int j = 0; j < points.GetLength(1); j++)
                    points[i, j] = RotateY(points[i, j], sinDeg, cosDeg);
            return points;
        }
        public static Points[,] RotateZ(Points[,] points, double deg)
        {
            double radDeg = (Math.PI * deg) / 180.0;
            double cosDeg = Math.Cos(radDeg);
            double sinDeg = Math.Sin(radDeg);
            for (int i = 0; i < points.GetLength(0); i++)
                for (int j = 0; j < points.GetLength(1); j++)
                    points[i, j] = RotateZ(points[i, j], sinDeg, cosDeg);
            return points;
        }
    }
    public class _3Points
    {
        public MathDescription.Points point_1;
        public MathDescription.Points point_2;
        public MathDescription.Points point_3;

        public _3Points(MathDescription.Points _point_1, MathDescription.Points _point_2, MathDescription.Points _point_3)
        {
            point_1 = _point_1;
            point_2 = _point_2;
            point_3 = _point_3;
        }
    }
    public class _4Points
    {
        public MathDescription.Points point_1;
        public MathDescription.Points point_2;
        public MathDescription.Points point_3;
        public MathDescription.Points point_4;

        public _4Points(MathDescription.Points _point_1, MathDescription.Points _point_2, MathDescription.Points _point_3, MathDescription.Points _point_4)
        {
            point_1 = _point_1;
            point_2 = _point_2;
            point_3 = _point_3;
            point_4 = _point_4;
        }
    }
    public class Surface
    {
        /// Отражательная способность направленного света
        public double Ks { get; set; }
        /// Отражательная способность рассеянного света
        public double Kd { get; set; }
        /// Коэффициент гладкости поверхности
        /// Чем больше коэффициент, тем лучше свойства направленного отражения
        /// Для N = 100 мы приближаемся к зеркальным свойствам
        public double N { get; set; }
        /// Интенсивность света в окружающей среде объекта (одинаково для всех объектов)
        public double Ia { get; set; }
        /// Интенсивность точечного света
        public double Ip { get; set; }
        /// Отражательная способность окружающего света (фон)
        public double Ka { get; set; }
    }
}
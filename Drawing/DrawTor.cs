using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace KGLB2_3
{
    class Tor
    {
        Pen pen = new Pen(Color.Black, 0.1f);
        readonly MathDescription.Points[,] countP;
        readonly MathDescription.Points[,] viewP;
        public MathDescription.Points Source = new MathDescription.Points(0, 0, 100);
        int N = 100, n = 100, R = 100;
        double R1 = 50, R2 = 50;
        double[,] arr;
        Color clr;
        public const int Step = 5;
        public double Speed { get; set; }
        public Tor()
        {
            countP = new MathDescription.Points[N, n];
            viewP = new MathDescription.Points[countP.GetLength(0), countP.GetLength(1)];
            CreateCoordinates();
            Array.Copy(countP, viewP, countP.Length);
        }
        private void CreateCoordinates()
        {
            for (int i = 0; i < N; i++)
                for (int j = 0; j < n; j++)
                    countP[i, j] = Expansion(R, R2, R1, (i * 360 / (N - 1)), j * 360 / (n - 1));
        }
        public MathDescription.Points Expansion(double _R, double _r, double _r1, double A, double B)
        {
            MathDescription.Points point = new MathDescription.Points();
            point.x = (_R + _r * Math.Cos(A * Math.PI / 90)) * Math.Cos(B * Math.PI / 90);
            point.y = (_R + _r * Math.Cos(A * Math.PI / 90)) * Math.Sin(B * Math.PI / 90);
            point.z = _r1 * Math.Sin(A * Math.PI / 90);
            return point;
        }
        public Bitmap DrawingTor(int _width, int _height, int d, bool type, bool shade, bool sort, Surface material, int red, int green, int blue)
        {
            Bitmap bmp = new Bitmap(_width, _height);
            Graphics graph = Graphics.FromImage(bmp);

            graph.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graph.PixelOffsetMode = PixelOffsetMode.HighQuality;
            graph.CompositingQuality = CompositingQuality.HighQuality;
            graph.CompositingMode = CompositingMode.SourceOver;
            graph.SmoothingMode = SmoothingMode.AntiAlias;

            MathDescription.Points[,] points = new MathDescription.Points[N, n];

            Array.Copy(viewP, points, viewP.Length);
            points = MathDescription.RotateX(points, Speed);
            points = MathDescription.RotateY(points, Speed);
            points = MathDescription.Perspective(points);
            //DrawingPoint(points, d);

            Point[] p = new Point[4];
            List<_4Points> coordList = new List<_4Points>();
            for (int i = 0; i < N - 1; i++)
                for (int j = 0; j < n - 1; j++)
                    coordList.Add(new _4Points(points[i, j], points[i, j + 1], points[i + 1, j], points[i + 1, j + 1]));

            double cur = 0;
            arr = new double[coordList.Count, 2];
            for (int i = 0; i < coordList.Count(); i++)
            {
                cur = 0;
                cur = (coordList[i].point_1.z + coordList[i].point_2.z + coordList[i].point_3.z + coordList[i].point_4.z) / 8;
                arr[i, 0] = cur;
                arr[i, 1] = i;
            }

            double[] NormAngle = new double[coordList.Count];
            for (int m = 0; m < coordList.Count; m++)
            {
                NormAngle[m] = CosNormal(coordList[m]);
            }

            if (sort)QSort(arr, 0, coordList.Count - 1);

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                p[0].X = (int)coordList[(int)arr[i, 1]].point_1.x + d;
                p[0].Y = (int)coordList[(int)arr[i, 1]].point_1.y + d;

                p[1].X = (int)coordList[(int)arr[i, 1]].point_2.x + d;
                p[1].Y = (int)coordList[(int)arr[i, 1]].point_2.y + d;

                p[2].X = (int)coordList[(int)arr[i, 1]].point_4.x + d;
                p[2].Y = (int)coordList[(int)arr[i, 1]].point_4.y + d;

                p[3].X = (int)coordList[(int)arr[i, 1]].point_3.x + d;
                p[3].Y = (int)coordList[(int)arr[i, 1]].point_3.y + d;

                if (type)
                {
                    if(!shade)
                    {
                        clr = Color.FromArgb(255, red, green, blue);
                        SolidBrush dr = new SolidBrush(clr);
                        graph.FillPolygon(dr, p);
                    }
                    if(shade)
                    {
                        double _alpha = Math.Abs(NormAngle[(int)arr[i, 1]]); 
                        var I = CalculateLightReflection(material, _alpha/2, _alpha);
                        clr = Color.FromArgb(Check(255 + I * _alpha), Check(red + I *_alpha), Check(green + I * _alpha), Check(blue + I * _alpha));
                        SolidBrush dr = new SolidBrush(clr);
                        graph.FillPolygon(dr, p);
                    }
                }
                else
                    graph.DrawPolygon(pen, p);
            }
            return bmp;
        }
        private double CosNormal(_4Points p)
        {
            double cos = new double();
            double[] coord = new double[3];
            coord[0] = (p.point_2.y - p.point_1.y) * (p.point_3.z - p.point_1.z) - (p.point_2.z - p.point_1.z) * (p.point_3.y - p.point_1.y);  //координаты нормали по x
            coord[1] = (p.point_2.z - p.point_1.z) * (p.point_3.x - p.point_1.x) - (p.point_2.x - p.point_1.x) * (p.point_3.z - p.point_1.z);  //координаты нормали по y
            coord[2] = (p.point_2.x - p.point_1.x) * (p.point_3.y - p.point_1.y) - (p.point_2.y - p.point_1.y) * (p.point_3.x - p.point_1.x);  //координаты нормали по z
            cos = (coord[0] * Source.x + coord[1] * Source.y + coord[2] * Source.z) / (Math.Sqrt(Math.Pow(coord[0], 2) + Math.Pow(coord[1], 2) + Math.Pow(coord[2], 2)) * Math.Sqrt(Math.Pow(Source.x, 2) + Math.Pow(Source.y, 2) + Math.Pow(Source.z, 2)));
            return cos;
        }
        private void QSort(double[,] _facets, int _in, int _out)
        {
            if (_in >= _out) return;
            int temp = Partition(_facets, _in, _out);
            QSort(_facets, _in, temp - 1);
            QSort(_facets, temp + 1, _out);
        }
        private static int Partition(double[,] _facets, int _in, int _out)
        {
            int marker = _in;
            for (int i = _in; i <= _out; i++)
            {
                if (_facets[i, 0] <= _facets[_out, 0])
                {
                    double temp = _facets[marker, 0];
                    _facets[marker, 0] = _facets[i, 0];
                    _facets[i, 0] = temp;
                    temp = _facets[marker, 1];
                    _facets[marker, 1] = _facets[i, 1];
                    _facets[i, 1] = temp;
                    marker++;
                }
            }
            return marker - 1;
        }
        private double CalculateLightReflection(Surface surface, double scalar, double cosAlpha)
        {
            return surface.Ia * surface.Ka + surface.Ip * surface.Kd * scalar + surface.Ip * surface.Ks * Math.Pow(cosAlpha, surface.N);
        }
        private int Check(double i)
        {
            if(i <= 0.0)
            {
                return 0;
            }
            else if(i >= 255.0)
            {
                return 255;
            }
            else
            {
                return (int)i;
            }
        }
        public void Left()
        {
            Source.x -= Step;
        }
        public void Right()
        {
            Source.x += Step;
        }
        public void Up()
        {
            Source.y -= Step;
        }
        public void Down()
        {
            Source.y += Step;
        }
        public void Forward()
        {
            Source.z -= Step;
        }
        public void Backward()
        {
            Source.z += Step;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise601
{
    class Program
    {
        static void Show(string name, Vector2D v)
        {
            Console.WriteLine("{0}=({1}, {2})", name, v.X, v.Y );
        }
        static void Main(string[] args)
        {
            Console.WriteLine("section1");
            Vector2D v1 = new Vector2D(1.0, 1.0);
            Show("v1",v1);
            Vector2D w = new Vector2D(1.0, -1.0);
            Vector2D v2 = new Vector2D(w);

            Show("v2",v2);

            v1.Add(v2);
            Show("v1",v1);
            v1.Sub(v2);
            Show("v1",v1);
            v1.Mul(2.0);
            Show("v1",v1);
            Console.WriteLine("v1,v2の内積: {0}", v1.DotProduct(v2));


            Console.Write("1つ目の数:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("1つ目の数:");
            int b = int.Parse(Console.ReadLine());
            int num = Numeric.Max(a,b);
            Console.WriteLine("2の数値のうちの最大値:{0}", num);

            Console.WriteLine("実数値を入力してください");
            double n = double.Parse(Console.ReadLine());
            if(n >= 0)
            {
                double r = Math.Sqrt(n);
                Console.WriteLine("{0}の平方根は{1}です。", n, r);
            }
            else
            {
                Console.WriteLine("星の数を入力してください。");
            }

            Console.Write("P1.X = ");
            double x1 = int.Parse(Console.ReadLine());
            Console.Write("P1.Y = ");
            double y1 = int.Parse(Console.ReadLine());
            Console.Write("P2.X = ");
            double x2 = int.Parse(Console.ReadLine());
            Console.Write("P2.Y = ");
            double y2 = int.Parse(Console.ReadLine());
            Point2D p1 = new Point2D(x1, y1);
            Point2D p2 = new Point2D(x2, y2);

            Console.WriteLine("p1 = {0} p2 = {1}", p1, p2);
            Console.WriteLine("p1,p2の距離:{0}", p1.Distance(p2));

            if(p1.Equals(p2))
            {
                Console.WriteLine("p1,p2は同一の点です。");
            }

            Bird[] bird = new Bird[4];
            bird[0] = new Crow();
            bird[1] = new Sparrow();
            bird[2] = new Chicken();
            bird[3] = new Pigeion();
            for(int i = 0; i < bird.Length; i++)
            {
                Console.Write(bird[i].Name +";");
                bird[i].Sing();
            }

            Data d = new Data()
            d.Write(1);
            int num  =  d.Read();
            Console.WriteLine("data = {0}", num);

        }
    }
}
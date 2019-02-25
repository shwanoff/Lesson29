using System;
using bb = System.Int32;

namespace Lesson29
{
    class Program
    {
        static void Main(string[] args)
        {
            // Домашнее задание
            // Переопределить методы ToString, Equals, GetHashCode
            // Поработать с остальными методами на практике.
            // Создайте клон объекта

            object obj = new object();

            int i = 5;
            int j = 5;

            Console.WriteLine(i.Equals(j));

            var oi = (object)i;
            object oj = j;

            Console.WriteLine(oi.Equals(oj));

            var p1 = new Point() { X = 5 };
            var p2 = new Point() { X = 5 };

            Console.WriteLine(p1.Equals(p2));
            Console.WriteLine(null == null);

            Console.WriteLine(i.GetHashCode());
            Console.WriteLine(oj.GetHashCode());
            Console.WriteLine(new MyClass().GetHashCode());
            Console.WriteLine(p1.GetHashCode());

            Console.WriteLine(i.ToString());
            Console.WriteLine(p1.ToString());

            Console.WriteLine(i.GetType());
            Console.WriteLine(oi.GetType());
            Console.WriteLine(p1.GetType());

            Console.WriteLine(typeof(Point) == p1.GetType());

            Console.WriteLine();
            Console.WriteLine(Object.Equals(5, 5));
            Console.WriteLine(Object.ReferenceEquals(5, 5));
            Console.WriteLine(Object.ReferenceEquals(p2, p2));

            Console.WriteLine();

            var pp = new Point() { X = 7, Y = new Point() };
            var pp2 = pp;
            pp2.X = 77;
            pp2.Y = new Point() { X = 99 };
            Console.WriteLine(pp);
            Console.WriteLine(pp.Y);

            var pp3 = pp.Clone();
            pp3.X = 88;
            pp3.Y.X = 222;
            Console.WriteLine(pp);
            Console.WriteLine(pp.Y);

            Console.ReadLine();
        }
    }
}

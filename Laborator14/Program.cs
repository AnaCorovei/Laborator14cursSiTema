    using System;
using System.Collections.Generic;
using static Laborator14.IParalipiped;

namespace Laborator14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //Calculator calc = new Calculator();
            //Calculator cal2 = new Calculator();

            //Func<int, int, int, int> x = (int x, int y, int z) => { return x * y * z; };
            //Console.WriteLine(x(1, 2, 3));

            //calc.Scale = 10;
            //ParalipipedVolumeCalculator dlg  = new ParalipipedVolumeCalculator(calc.Volum);
            //var para = new Paralipiped(2, 2, 2);

            //var v = para.GetVolum( (int x, int y, int z) => { return x * y * z; });
            //para.AfiseazaPrietenon((int x, int y, int z) => { Console.WriteLine($"afisam : {x} {y}, {z}"); });   

            //Func<int, int, int> addInt = calc.Add;
            //Func<int, int, int> subInt = calc.Sub;
            //Func<int, int, int> multiplyInt = calc.Multiply;

            List<Paralipiped> lista = new List<Paralipiped>();
            lista.Add(new Paralipiped(1, 1, 3));
            lista.Add(new Paralipiped(3, 3, 3));
            lista.Add(new Paralipiped(2, 2, 2));

            lista.ForEach(p => Console.WriteLine($"{p.X * p.Y * p.Z}"));

            lista.ForEach(p =>
            {
                var volum = p.X * p.Y * p.Z;
                if (volum % 2 == 0)
                {
                    return;
                }
                Console.WriteLine(volum);
            });

            lista.FindAll(p => p.X * p.Y * p.Z == 0).ForEach(p => Console.WriteLine(p));


        }
    }


    delegate int AddInt(int x, int y);
    delegate int SubInt(int x, int y);
    delegate int MultiplyInt(int x, int y);

    delegate int ParalipipedVolumeCalculator(IParalipiped p);
    public class Calculator
    {

        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Sub(int x, int y)
        {
            return x- y;
        }


        public int Multiply(int x, int y)
        {
            return x * y;
        }
        public int Scale { get; set; } = 1;

        public int Volum(int x, int y, int z)
        {
            return x * y * z;
        }
     
        public int Volum(IParalipiped para)
        {
            return para.X * para.Y * para.Z * Scale;
        }
    }

    public interface IParalipiped
    {
        public int X { get; }
        public int Y { get; }
        public int Z { get; }



        public class Paralipiped : IParalipiped
        {
            public int X { get; private set; }
            public int Y { get; private set; }
            public int Z { get; private set; }

            public Paralipiped(int x, int y, int z)
            {
                this.X = x;
                this.Y = y;
                this.Z = z;

            }

            public int GetVolum(Func<int, int, int, int> calculatowrDeVolum)
            {
                return calculatowrDeVolum(X, Y, Z);
            }

            public void AfiseazaPrietenon (Action<int,int,int> action)
            {
                action(X, Y, Z);
            }

        }

    }
}

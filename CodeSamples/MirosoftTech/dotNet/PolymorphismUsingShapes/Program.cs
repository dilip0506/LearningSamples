using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polyusingshapeex
{
    class Shape {
        public int x { get; set; }
        public int y { get; set; }

        private int _Height;
        public int Height{
            get { return _Height; }
            private set {
                if (value >= 0) {
                    _Height = value;
                }
                }
        }
        private int _Width;
        public int Width{
            get { return _Width; }
            set { _Width = value; }
        }
        //override property
        //private virtual int myVar;

        //public virtual int MyProperty
        //{
        //    get { return myVar; }
        //    set { myVar = value; }
        //}

        public virtual void Draw() {
            Console.WriteLine("base class draw tasks");
        }
    }

    class Triangle:Shape {
        public override void Draw()
        {
            Console.WriteLine("drawing triangle");
            base.Draw();
        }
    }

    class Rectangle : Shape {
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("draw Rectangle");
        }
    }
    class Circle : Shape{
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shape = new List<Shape>();
            shape.Add(new Triangle());
            shape.Add(new Rectangle());
            shape.Add(new Circle());
            foreach (Shape s in shape) {
                s.Draw();
            }
            Console.ReadKey();

        }
    }
}

namespace Udemy.Solid
{
    public enum Color
    {
        Red,
        Blue,
        Yellow
    }

    public enum Size
    {
        Small,
        Medium,
        Large
    }

    internal class Product
    {
        public string _name;
        public Color _color;
        public Size _size;
        public Product(string name, Color color, Size size)
        {
            _name = name ?? throw new ArgumentNullException(paramName: nameof(name));
            _color = color;
            _size = size;
        }
    }

    //internal class ProductFilter
    //{
    //    public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
    //    {
    //        foreach (var item in products)
    //        {
    //            if (item._size == size)
    //            {
    //                yield return item;
    //            }

    //        }
    //    }
    //}
    interface ISpecification<T>
    {
        bool IsSatisfied(T t);
    }

    internal class ProductFilterBySize : ISpecification<Product>
    {
        private Size _size { get; set; }

        public ProductFilterBySize(Size size)
        {
            _size = size;
        }
        public bool IsSatisfied(Product t)
        {
            return t._size == _size;
        }
    }

    internal class ProductFilterByColor : ISpecification<Product>
    {
        private Color _color { get; set; }

        public ProductFilterByColor(Color color)
        {
            _color = color;
        }
        public bool IsSatisfied(Product t)
        {
            return t._color == _color;
        }
    }

    internal class AndSpecification<T> : ISpecification<T>
    {
        private ISpecification<T> first, second;

        public AndSpecification(ISpecification<T> first, ISpecification<T> second)
        {
            this.first = first ?? throw new ArgumentNullException(paramName: nameof(first));
            this.second = second ?? throw new ArgumentNullException(paramName: nameof(second));
        }

        public bool IsSatisfied(T t)
        {
            return first.IsSatisfied(t) && second.IsSatisfied(t);
        }
    }
    interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
    }

    internal class OCProductFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
        {
            foreach (var item in items)
            {
                if (spec.IsSatisfied(item))
                {
                    yield return item;
                }
            }
        }
    }

    internal class OpenClosedPrinciple
    {
        public static void Main()
        {
            IList<Product> p = new List<Product>() {
               new Product("Sango", Color.Yellow, Size.Small),
               new Product("Mango", Color.Blue, Size.Small),
               new Product("Lango", Color.Yellow, Size.Large)
            };
            // var pf = new ProductFilter();
            //var filtered = pf.FilterBySize(p, Size.Small);
            // foreach (var item in filtered) {
            //     Console.WriteLine($"{item._name} {item._size}");
            // }

            var bf = new OCProductFilter();
            var filterednew = bf.Filter(p, new AndSpecification<Product>(
                new ProductFilterByColor(color: Color.Blue),
                new ProductFilterBySize(size: Size.Small)));
            foreach (var item in filterednew)
            {
                Console.WriteLine($"{item._name} {item._size}");
            }
            Console.Read();
        }
    }
}

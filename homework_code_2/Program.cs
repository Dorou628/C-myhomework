// 抽象基类
abstract class Shape
{
    public abstract double CalculateArea();
    public abstract bool IsValid();
}

// 长方形
class Rectangle : Shape
{
    private double _width;
    private double _height;

    public double Width
    {
        get => _width;
        set => _width = value > 0 ? value : throw new ArgumentException("宽度必须大于0");
    }
    public double Height
    {
        get => _height;
        set => _height = value > 0 ? value : throw new ArgumentException("高度必须大于0");
    }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double CalculateArea() => Width * Height;
    public override bool IsValid() => Width > 0 && Height > 0;
}

// 正方形（继承长方形）
class Square : Rectangle
{
    public Square(double side) : base(side, side) { }
}

// 圆形
class Circle : Shape
{
    private double _radius;
    public double Radius
    {
        get => _radius;
        set => _radius = value > 0 ? value : throw new ArgumentException("半径必须大于0");
    }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea() => Math.PI * Radius * Radius;
    public override bool IsValid() => Radius > 0;
}

// 主程序
class Program
{
    static void Main()
    {
        Random rand = new Random();
        Shape[] shapes = new Shape[10];
        double totalArea = 0;

        // 随机创建10个形状
        for (int i = 0; i < 10; i++)
        {
            int type = rand.Next(3); // 0:矩形, 1:正方形, 2:圆形
            switch (type)
            {
                case 0:
                    shapes[i] = new Rectangle(rand.NextDouble() * 10 + 1, rand.NextDouble() * 10 + 1);
                    break;
                case 1:
                    shapes[i] = new Square(rand.NextDouble() * 10 + 1);
                    break;
                case 2:
                    shapes[i] = new Circle(rand.NextDouble() * 10 + 1);
                    break;
            }
        }

        // 计算总面积
        foreach (var shape in shapes)
        {
            if (shape.IsValid())
            {
                totalArea += shape.CalculateArea();
                Console.WriteLine($"面积: {shape.CalculateArea()}");
            }
        }
        Console.WriteLine($"总面积: {totalArea}");
    }
}
class Program
{
  public static void Main(string[] args)
  {
    Shape[] shapes = {
      new Square(10),
      new Circle(30),
      new Rectangle(20, 30)
    };

    foreach (Shape shape in shapes)
    {
      if (shape is IColorable)
      {
        IColorable? colorable_shape = shape as IColorable;
        colorable_shape?.HowToColor();
      }
    }
  }
}
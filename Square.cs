public class Square : Rectangle, IResizeable, IColorable
{

    public Square()

    {

    }

    public Square(double side) : base(side, side)

    {

    }

    public Square(double side, String color, bool filled) : base(side, side, color, filled)

    {

    }

    public double GetSide()

    {

        return GetWidth();

    }

    public void SetSide(double side)

    {

        SetWidth(side);

        SetLength(side);

    }

    public override void SetWidth(double width)

    {

        SetSide(width);

    }

    public override void SetLength(double length)

    {

        SetSide(length);

    }

    public override String ToString()

    {

        return "A Square with side ="

                    + GetSide()

                    + ", which is a subclass of "

                    +base.ToString();

    }

    public override void Resize(double percent)
    {
        base.Resize(percent);
        Console.WriteLine("Resize Square");
    }

    public void HowToColor()
    {
        Console.WriteLine("Color all four sides.");
    }

}

public class Rectangle : Shape
{
    public new double Area => Width * Height;

    public Rectangle(double height, double width)
    {
        Height = height;
        Width = width;
    }
}

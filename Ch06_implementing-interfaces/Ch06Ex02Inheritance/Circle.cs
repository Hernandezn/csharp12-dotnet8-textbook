
public class Circle : Shape
{
    public Circle(double radius)
    {
        Height = 2 * radius;
        Width = 2 * radius;
        Area = Math.PI * radius * radius;
    }
}

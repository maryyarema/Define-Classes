using System;

class Rectangle
{
    public string ID { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }
    public double X { get; set; }
    public double Y { get; set; }

    public Rectangle(string id, double width, double height, double x, double y)
    {
        this.ID = id;
        this.Width = width;
        this.Height = height;
        this.X = x;
        this.Y = y;
    }

    public string Intersects(Rectangle rectangle)
    {
        if ((rectangle.Y >= this.Y && rectangle.Y - rectangle.Height <= this.Y && rectangle.X <= this.X && rectangle.X + rectangle.Width >= this.X) ||
            (rectangle.Y >= this.Y && rectangle.Y - rectangle.Height <= this.Y && rectangle.X >= this.X && rectangle.X <= this.X + this.Width) ||
            (rectangle.Y <= this.Y && rectangle.Y >= this.Y - this.Height && rectangle.X <= this.X && rectangle.X + rectangle.Width >= this.X) ||
            (rectangle.Y <= this.Y && rectangle.Y >= this.Y - this.Height && rectangle.X >= this.X && rectangle.X <= this.X + this.Width))
        {
            return "true";
        }

        return "false";
    }

}
public class Startup
{
    public static void Main()
    {
        var counts = Console.ReadLine().Split(new char[0], StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        var rectangles = new Rectangle[counts[0]];

        for (int i = 0; i < counts[0]; i++)
        {
            var tokens = Console.ReadLine().Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
            var id = tokens[0];
            var width = double.Parse(tokens[1]);
            var height = double.Parse(tokens[2]);
            var x = double.Parse(tokens[3]);
            var y = double.Parse(tokens[4]);

            rectangles[i] = new Rectangle(id, width, height, x, y);
        }

        for (int i = 0; i < counts[1]; i++)
        {
            var tokens = Console.ReadLine().Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
            var firstRectangle = rectangles.Where(r => r.ID == tokens[0]).First();
            var secondRectangle = rectangles.Where(r => r.ID == tokens[1]).First();

            Console.WriteLine(firstRectangle.Intersects(secondRectangle));
        }
    }
}
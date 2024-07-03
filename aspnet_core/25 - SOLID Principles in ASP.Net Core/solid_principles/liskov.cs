namespace solid_principles
{
    // Bad Example

    public class Rectangle_bad
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public int Area => Width * Height;
    }

    public class Square_bad : Rectangle_bad
    {
        public override int Width { set { base.Width = base.Height = value; } }

        public override int Height { set { base.Width = base.Height = value; } }
    }

    // Good Example
    public abstract class Shape
    {
        public abstract int Area { get; }
    }

    public class Rectangle_good : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public override int Area => Width * Height;
    }

    public class Square_good : Shape
    {
        public int SideLength { get; set; }
        public override int Area => SideLength * SideLength;
    }
}

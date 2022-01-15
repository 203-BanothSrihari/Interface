using System;

namespace Interface
{
    public interface Drawable
    {
        void draw();

    }
    class Program
    {
        static void Main(string[] args)
        {
            Drawable d;
            d = new Rectangle();
            d.draw();
            d = new Circle();
            d.draw();

        }
    }
}

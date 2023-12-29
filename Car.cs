using System.Drawing;

namespace Rally
{
    internal class Car
    {
        private RectangleF bounds;
        public enum CarLocation
        { 
            Left, Right
        }

        public CarLocation Location { get; set; }
        public RectangleF DrawBounds 
        {
            get => bounds;
            set => bounds = value;
        }

        public RectangleF CollisionBounds
        {
            get => new RectangleF(bounds.Left + 5, bounds.Top + 1,
                bounds.Width - 10, bounds.Height - 2);
        }

        public Bitmap Image { get; set; }

        public Car()
        {
            DrawBounds = new RectangleF(0, 0, 55, 100);
        }

        public Car(CarLocation location)
        {
            DrawBounds = new RectangleF(0, 0, 55, 100);
            Location = location;
        }

        public void MoveLeft(float x)
        {
            bounds.X -= x;
        }

        public void MoveRight(float x)
        {
            bounds.X += x;
        }

        public void MoveDown(float y)
        {
            bounds.Y += y;
        }

        public void SetPosition(float x, float y)
        {
            bounds.X = x;
            bounds.Y = y;
        }
    }
}

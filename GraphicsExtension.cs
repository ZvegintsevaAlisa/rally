using Rally;
using System.Drawing;

namespace Rally
{
    public static class GraphicsExtension
    {
        public static void DrawDashes(this Graphics graphics, Rectangle bounds,
            int xOffset, float yOffset)
        {
            var linePenWhite = new Pen(Color.White, 3.0f);
            var dashLineLength = (int)(bounds.Width * 0.07);
            var dashLineFullLength = (int)(bounds.Width * 0.23);
            var countDashes = (bounds.Height / dashLineFullLength) + 1;
            var dashesLength = countDashes * dashLineFullLength;

            for (int i = (int)yOffset; i <= yOffset + dashesLength; i += dashLineFullLength)
            {
                var y = i % dashesLength - dashLineLength;
                graphics.DrawLine(linePenWhite, xOffset, y,
                    xOffset, y + dashLineLength);
            }
        }

        public static void DrawRoad(this Graphics graphics, Rectangle bounds, float offset)
        {
            var roadWidth = (int)(bounds.Width * 0.88);
            var roadLeft = (bounds.Width - roadWidth) / 2;
            var leftLine = (int)(bounds.Width * 0.18);
            var leftDashLine = (int)(bounds.Width * 0.38);
            var rightDashLine = (int)(bounds.Width * 0.59);
            var rightLine = (int)(bounds.Width * 0.82);
            var roadColor = Color.FromArgb(70, 70, 70);
            var roadBrush = new SolidBrush(roadColor);
            var roadRect = new Rectangle(roadLeft, 0,
                roadWidth, bounds.Height);
            var linePenWhite = new Pen(Color.White, 3.0f);
            var yellowColor = Color.FromArgb(255, 243, 0);
            var linePenYellow = new Pen(yellowColor, 3.0f);

            graphics.Clear(Color.FromArgb(28, 178, 75));
            graphics.FillRectangle(roadBrush, roadRect);
            graphics.DrawLine(linePenWhite, leftLine, 0,
                leftLine, bounds.Height);
            graphics.DrawDashes(bounds, leftDashLine, offset);
            graphics.DrawDashes(bounds, rightDashLine, offset - 6);
            graphics.DrawLine(linePenYellow, rightLine, 0,
                rightLine, bounds.Height);
        }

        public static void DrawGif(this Graphics graphics, GifPlayer player)
        {
            graphics.DrawImage(player.GetNextFrame(), player.Bounds);
        }
    }
}

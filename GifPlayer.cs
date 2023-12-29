using System.Drawing.Imaging;
using System.Drawing;

namespace Rally
{
    public class GifPlayer
    {
        private bool play;
        private RectangleF bounds;
        private readonly Image image;
        private readonly FrameDimension dimension;
        private readonly int count;
        private float index;

        public RectangleF Bounds
        {
            set => bounds = value;
            get => bounds;
        }

        public GifPlayer(Image image)
        {
            this.image = image;
            dimension = new FrameDimension(image.FrameDimensionsList[0]);
            count = image.GetFrameCount(dimension);
            index = 0;
            play = false;
        }

        public void Play()
        {
            play = true;
        }

        public float GetProgress()
        {
            return (index + 1) / count;
        }

        public Image GetNextFrame()
        {
            if (play)
            {
                image.SelectActiveFrame(dimension, (int)index);
                index += 0.6f;
                if (index >= count)
                {
                    image.SelectActiveFrame(dimension, (int)index - 1);
                    index = 0;
                    play = false;
                }
            }
            return image;
        }
    }
}

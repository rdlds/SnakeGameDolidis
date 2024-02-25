using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace SnakeGameDolidis
{
    public static class Images
    {
        public readonly static ImageSource Apple = LoadImage("Apple.png");
        public readonly static ImageSource Empty = LoadImage("Empty.png");
        public readonly static ImageSource SnakeBody= LoadImage("SnakeBody.png");
        public readonly static ImageSource SnakeDeadHead = LoadImage("SnakeDeadHead.png");
        public readonly static ImageSource SnakeHead = LoadImage("SnakeHead.png");
        public readonly static ImageSource SnakeDeadBody = LoadImage("SnakeDeadBody.png");
        private static ImageSource LoadImage(string fileName)
        {
             return new BitmapImage(new Uri($"ImagesForProject/{fileName}", UriKind.Relative));
        }

    }
}

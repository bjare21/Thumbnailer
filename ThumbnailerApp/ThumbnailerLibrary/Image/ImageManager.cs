using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Img = SixLabors.ImageSharp.Image;

namespace ThumbnailerLibrary.Image
{
    public static class ImageManager
    {
        public static void Resize(string imagePath, int newWidth, int newHeight, ResizeOptions resizeOptions)
        {
            using (Img image = Img.Load(imagePath))
            {
                image.Mutate(i=>i.Resize(newWidth, newHeight));
                if (resizeOptions.Overwrite)
                {
                    image.Save(imagePath);
                    return;
                }
                else
                {
                    string newPath = imagePath + resizeOptions.Suffix;
                    image.Save(newPath);
                }
            }
        }
        public static void Resize(string imagePath, int newWidth, int newHeight)
        {
            using (Img image = Img.Load(imagePath))
            {
                image.Mutate(i => i.Resize(newWidth, newHeight));
                image.Save(imagePath);
            }
        }

    }
}

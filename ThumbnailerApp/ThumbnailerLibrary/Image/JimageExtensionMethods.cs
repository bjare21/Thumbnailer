using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThumbnailerLibrary.Image
{
    public static class JimageExtensionMethods
    {
        public static void ChangeSize(this IEnumerable<SharpJimage> self, int width, int height)
        {
            foreach(var image in self)
            {
                image.Resize(width, height);
            }
        }

        public static void SaveChanges(this IEnumerable<SharpJimage> self)
        {
            foreach (var image in self)
            {
                image.Save();
            }
        }

        public static void SaveChanges(this IEnumerable<SharpJimage> self, ImageSaveMode imageSaveMode)
        {
            foreach(var image in self)
            {
                image.Save(imageSaveMode);
            }
        }
    }
}

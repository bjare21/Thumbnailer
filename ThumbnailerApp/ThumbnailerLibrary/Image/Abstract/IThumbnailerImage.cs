using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThumbnailerLibrary.Image.Abstract
{
    public interface IThumbnailerImage
    {
        void Resize(int width, int height);
        void Crop(int width, int height, CropMode cropMode);
        void Save();
        void Save(ImageSaveMode imageSaveMode);
    }

    public enum CropMode
    {
        Center,
        TopLeft,
        TopRight,
        BottomLeft,
        BottomRight
    }
}

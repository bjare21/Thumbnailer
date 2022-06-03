using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThumbnailerLibrary.File;
using ThumbnailerLibrary.Image.Abstract;

namespace ThumbnailerLibrary.Image
{
    public class SharpJimageCollection : List<SharpJimage>, IThumbnailerImage
    {
        public SharpJimageCollection(string directoryPath)
        {
            var filePaths = FileManager.LoadFromDirectory(directoryPath);
            foreach (var file in filePaths)
            {
                SharpJimage image = new SharpJimage();
                image.Load(file);
                this.Add(image);
            }
        }

        public void Resize(int width, int height)
        {
            foreach (var image in this)
            {
                image.Resize(width, height);
            }
        }

        public void Crop(int width, int height, CropMode cropMode) { }

        public void Save()
        {
            foreach (var image in this)
            {
                image.Save();
            }
        }

        public void Save(ImageSaveMode imageSaveMode)
        {
            foreach(var image in this)
            {
                image.Save(imageSaveMode);
            }
        }
    }
}

using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThumbnailerLibrary.Image.Abstract;
using ThumbnailerLibrary.Image.SaveStrategies;
using Img = SixLabors.ImageSharp.Image;

namespace ThumbnailerLibrary.Image
{
    public class SharpJimage:IThumbnailerImage, IEnumerable<SharpJimage>
    {
        private Img _image;
        private string _path = string.Empty;
        private string _suffix = "_resized";
        private ISaveStrategy saveStrategy = new SameFileSaveStrategy();

        public void Load(string path)
        {
            _image = Img.Load(path);
            _path = path;
        }

        public void Save()
        {
            string savePath = saveStrategy.GetSavePath(_path);
            _image.Save(savePath);
        }

        public void Save(ImageSaveMode imageSaveMode)
        {
            setImageSaveMode(imageSaveMode);
            this.Save();
        }

        public void Resize(int width, int height)
        {
            if (_image == null) return;

            _image.Mutate(x => x.Resize(width, height));
        }

        public void Crop(int width, int height, CropMode cropMode)
        {
            if (_image == null) return;
            ResizeOptions options = new ResizeOptions();
            options.Mode = ResizeMode.Crop;
            options.Position = emulatePositionMode(cropMode);
            options.Size = new Size(width, height);
            _image.Mutate(x => x.Resize(options));
        }

        public IEnumerator<SharpJimage> GetEnumerator()
        {
            yield return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private AnchorPositionMode emulatePositionMode(CropMode cropMode)
        {
            switch (cropMode)
            {
                case CropMode.Center:
                    return AnchorPositionMode.Center;
                case CropMode.TopLeft:
                    return AnchorPositionMode.TopLeft;
                    case CropMode.TopRight:
                       return AnchorPositionMode.TopRight;
                    case CropMode.BottomLeft:
                        return AnchorPositionMode.BottomLeft;
                case CropMode.BottomRight:
                    return AnchorPositionMode.BottomRight;
                default:
                    return AnchorPositionMode.Center;
            }
        }

        public Img Image
        {
            get { return _image; }
        }

        public string Path
        {
            get { return _path; }
        }

        public string Suffix
        {
            get
            {
                return this._suffix;
            }
            set
            {
                this._suffix = value;
            }
        }

        private void setImageSaveMode(ImageSaveMode imageSaveMode)
        {
            switch (imageSaveMode)
            {
                case ImageSaveMode.SameFile:
                    saveStrategy = new SameFileSaveStrategy();
                    break;
                case ImageSaveMode.SuffixedName:
                    saveStrategy = new SameDirectorySuffixedNameSaveStrategy(Suffix);
                    break;
                default:
                    break;
            }
        }
    }

    public enum ImageSaveMode
    {
        SameFile,
        SuffixedName,
        OtherDirectory,
        OtherDirectorySuffixedName
    }
}

using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThumbnailerLibrary.Image.SaveStrategies;
using Img = SixLabors.ImageSharp.Image;

namespace ThumbnailerLibrary.Image
{
    public class Jimage:IJimage, IEnumerable<Jimage>
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
            saveStrategy.SaveImage(this);
        }

        public void Save(ImageSaveMode imageSaveMode)
        {
            setImageSaveMode(imageSaveMode);
            saveStrategy.SaveImage(this);
        }

        public void Resize(int height, int width)
        {
            if (_image == null) return;
            _image.Mutate(x => x.Resize(height, width));
        }

        public IEnumerator<Jimage> GetEnumerator()
        {
            yield return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
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

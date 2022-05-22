using SixLabors.ImageSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThumbnailerLibrary.Image.SaveStrategies
{
    public class SameDirectorySuffixedNameSaveStrategy : ISaveStrategy
    {
        string _suffix = string.Empty;
        public SameDirectorySuffixedNameSaveStrategy(string suffix)
        {
            this._suffix = suffix;
        }
        public void SaveImage(Jimage jimage)
        {
            string path = jimage.Path;
            int dotNdx = path.LastIndexOf('.');
            path = path.Insert(dotNdx, _suffix);
            jimage.Image.Save(path);
        }
    }
}

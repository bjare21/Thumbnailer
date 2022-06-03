using SixLabors.ImageSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThumbnailerLibrary.Image.Abstract;

namespace ThumbnailerLibrary.Image.SaveStrategies
{
    public class SameDirectorySuffixedNameSaveStrategy : ISaveStrategy
    {
        string _suffix = string.Empty;
        public SameDirectorySuffixedNameSaveStrategy(string suffix)
        {
            this._suffix = suffix;
        }
        public string GetSavePath(string filePath)
        {
            string path = filePath;
            int dotNdx = path.LastIndexOf('.');
            path = path.Insert(dotNdx, _suffix);
            return path;
        }
    }
}

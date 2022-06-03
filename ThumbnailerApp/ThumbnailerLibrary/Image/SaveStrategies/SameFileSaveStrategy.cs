using SixLabors.ImageSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThumbnailerLibrary.Image.Abstract;

namespace ThumbnailerLibrary.Image.SaveStrategies
{
    public class SameFileSaveStrategy:ISaveStrategy
    {
        public string GetSavePath(string filePath)
        {
            return filePath;
        }
    }
}

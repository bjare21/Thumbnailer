using SixLabors.ImageSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThumbnailerLibrary.Image.SaveStrategies
{
    public class SameFileSaveStrategy:ISaveStrategy
    {
        public void SaveImage(Jimage jimage)
        {
            jimage.Image.Save(jimage.Path);
        }
    }
}

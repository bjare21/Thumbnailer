using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SixLabors.ImageSharp;

namespace ThumbnailerApp.Image
{
    public class ImageCollection:List<SixLabors.ImageSharp.Image>
    {
        public void Load(string[] filepaths)
        {
            foreach(string filepath in filepaths)
            {
                this.Add(SixLabors.ImageSharp.Image.Load(filepath));
            }
        }
    }
}

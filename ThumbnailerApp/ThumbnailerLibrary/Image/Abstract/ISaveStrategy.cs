using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThumbnailerLibrary.Image.Abstract
{
    public interface ISaveStrategy
    {
        string GetSavePath(string filePath);
    }
}

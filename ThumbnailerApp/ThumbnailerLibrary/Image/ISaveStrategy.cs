using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThumbnailerLibrary.Image
{
    public interface ISaveStrategy
    {
        void SaveImage(Jimage jimage);
    }
}

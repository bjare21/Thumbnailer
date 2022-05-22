using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThumbnailerLibrary.Image
{
    public interface IJimage
    {
        public void Load(string path);
        void Resize(int width, int height);
        public void Save();
    }
}

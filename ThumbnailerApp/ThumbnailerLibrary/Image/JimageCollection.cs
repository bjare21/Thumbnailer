using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThumbnailerLibrary.File;

namespace ThumbnailerLibrary.Image
{
    public class JimageCollection:List<Jimage>
    {
        public JimageCollection(string directoryPath)
        {
            var filePaths = FileManager.LoadFromDirectory(directoryPath);
            foreach (var file in filePaths)
            {
                Jimage image = new Jimage();
                image.Load(file);
                this.Add(image);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThumbnailerLibrary.Image
{
    public class ResizeOptions
    {
        private bool saveToNewFolder = false;
        private bool overwrite = false;
        private string newFolderName = "Thumbnailer resized";

        private string suffix = "_resized";
        public bool Overwrite
        {
            get
            {
                return overwrite;
            }
            set
            {
                this.overwrite = value;
            }
        }

        public bool SaveToNewFolder
        {
            get
            {
                return this.saveToNewFolder;
            }
            set
            {
                this.saveToNewFolder = value;
            }
        }
        public string Suffix
        {
            get
            {
                return suffix;
            }
            set
            {
                this.suffix = value;
            }
        }

        public string NewFolderName
        {
            get
            {
                return this.newFolderName;
            }
            set
            {
                this.newFolderName = value;
            }
        }
    }
}

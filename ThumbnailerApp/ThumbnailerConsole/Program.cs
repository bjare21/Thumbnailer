using System;
using System.IO;
using ThumbnailerLibrary.File;
using ThumbnailerLibrary.Image;
using ThumbnailerLibrary.Image.Abstract;

namespace ThumbnailerConsole
{
    internal class Program
    {
        #region PathStrings
        private static readonly string absolutePath = @"c:\Users\Hp\source\repos\ThumbnailerProject\ThumbnailerConsoleApp\TestFolder";
        private static readonly string imageName = @"Dsc01587.jpg";
        private static readonly string imagePath = @"C:\Users\Hp\Pictures";
        private static readonly string jpgsDirPath = @"SameJPG\";
        private static readonly string mixedDirPath = @"Mieszane\";
        private static readonly string otherDirPath = @"TestFolder\INNE\";
        private static readonly string singlePicPath = @"TestFolder\Zdjecie\";
        private static readonly string singlePic = @"goralArgentyna.png";
        #endregion
        static void Main(string[] args)
        {
            //ImageCollection images = new ImageCollection();
            //images.Load(FileManager.LoadFromDirectory(Path.Combine(absolutePath, mixedDirPath),"*.jpg"));
            //Console.WriteLine("Liczba zdjęć: " + images.Count);

            //Console.WriteLine("Próba zmiany rozmiaru obrazu.");
            //string nm = Path.Combine(absolutePath, singlePicPath, singlePic);
            //Console.WriteLine(nm);
            //SixLabors.ImageSharp.Image img = SixLabors.ImageSharp.Image.Load(nm);
            //ResizeOptions options = new ResizeOptions
            //{
            //    Suffix = "_minimalized"
            //};

            //ImageManager.Resize(nm, 350, 272, options);

            //string image = Path.Combine(absolutePath, jpgsDirPath);
            //JimageCollection jimages = new JimageCollection(image);

            //jimages.ChangeSize(100, 100);
            //jimages.SaveChanges(ImageSaveMode.SuffixedName);


            SharpJimage jimage = new SharpJimage();
            string path = Path.Combine(absolutePath, imageName);
            jimage.Load(path);

            jimage.Crop(200, 200, CropMode.BottomRight);
            jimage.Suffix = "_cropped";
            jimage.Save(ImageSaveMode.SuffixedName);

            //string directoryPath = Path.Combine(absolutePath, mixedDirPath);
            //SharpJimageCollection jimages = new SharpJimageCollection(directoryPath);
            //jimages.Resize(100, 1300);
            //jimages.Save(ImageSaveMode.SuffixedName);
        }
    }
}

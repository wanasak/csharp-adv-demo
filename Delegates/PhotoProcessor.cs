using System;

namespace Delegates
{
    public class PhotoProcessor
    {
        //public delegate void PhotoFilterHandler(Photo photo);

        public void Processor(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);

            // Problem: cannot apply custom filter
            //var filters = new PhotoFilters();
            //filters.ApplyBrightness(photo);
            //filters.ApplyContrast(photo);
            //filters.Resize(photo);
            filterHandler(photo);

            photo.Save();
        }
    }
}

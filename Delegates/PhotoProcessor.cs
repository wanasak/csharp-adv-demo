namespace Delegates
{
    public class PhotoProcessor
    {
        public void Processor(string path)
        {
            var photo = Photo.Load(path);

            // Problem: cannot apply custom filter
            var filters = new PhotoFilters();
            filters.ApplyBrightness(photo);
            filters.ApplyContrast(photo);
            filters.Resize(photo);

            photo.Save();
        }
    }
}

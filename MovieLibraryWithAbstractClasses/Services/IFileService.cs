using MovieLibraryWithAbstractClasses.Models;

namespace MovieLibraryWithAbstractClasses.Services
{
    public interface IFileService
    {
        void Read();
        void Write(Movie movie, Show show, Video video);
        void MovieDisplay();
        void ShowDisplay();
        void VideoDisplay();
        void MovieInput();
        void ShowInput();
        void VideoInput();
    }
}
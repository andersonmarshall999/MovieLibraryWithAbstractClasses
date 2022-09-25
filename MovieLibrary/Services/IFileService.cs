/// <summary>
///     This service interface only exists an example.
///     It can either be copied and modified, or deleted.
/// </summary>

namespace MovieLibrary.Services
{
    public interface IFileService
    {
        void Read();
        void Write(int movieId, string movieTitle, string genresString);
        void Display();
        void Input();
    }
}
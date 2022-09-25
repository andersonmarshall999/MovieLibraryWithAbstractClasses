using System;

/// <summary>
///     You would need to inject your interfaces here to execute the methods in Invoke()
///     See the commented out code as an example
/// </summary>

namespace MovieLibrary.Services
{
    public class MainService : IMainService
    {
        private readonly IFileService _fileService;

        public MainService(IFileService fileService)
        {
            _fileService = fileService;
        }

        public void Invoke()
        {
            string choice;
            do
            {
                Console.WriteLine("1) Add Media");
                Console.WriteLine("2) Display Media");
                Console.WriteLine("X) Quit");
                choice = Console.ReadLine();

                // Logic would need to exist to validate inputs and data prior to writing to the file
                // You would need to decide where this logic would reside.
                // Is it part of the FileService or some other service?
                if (choice == "1")
                {
                    _fileService.Input();
                    //_fileService.Write(999999, "My Super Cool Movie", "Action|Horror");
                }
                else if (choice == "2")
                {
                    _fileService.Read();
                    _fileService.Display();
                }
            } while (choice.ToLower() != "x");
        }
    }
}
using System;

/// <summary>
///     You would need to inject your interfaces here to execute the methods in Invoke()
///     See the commented out code as an example
/// </summary>

namespace MovieLibraryWithAbstractClasses.Services
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
            _fileService.Read();
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
                    Console.WriteLine("1) Add Movie");
                    Console.WriteLine("2) Add Show");
                    Console.WriteLine("3) Add Video");
                    choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "1":
                        {
                            _fileService.MovieInput();
                            break;
                        }
                        case "2":
                        {
                            _fileService.ShowInput();
                            break;
                        }
                        case "3":
                        {
                            _fileService.VideoInput();
                            break;
                        }
                    }
                    //_fileService.Write(999999, "My Super Cool Movie", "Action|Horror");
                }
                else if (choice == "2")
                {
                    Console.WriteLine("1) Display Movies");
                    Console.WriteLine("2) Display Shows");
                    Console.WriteLine("3) Display Videos");
                    choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "1":
                        {
                            _fileService.MovieDisplay();
                            break;
                        }
                        case "2":
                        {
                            _fileService.ShowDisplay();
                            break;
                        }
                        case "3":
                        {
                            _fileService.VideoDisplay();
                            break;
                        }
                    }
                }
            } while (choice != null && choice.ToLower() != "x");
        }
    }
}
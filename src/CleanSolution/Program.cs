using CleanSolution;

class Program
{
    static void Main(string[] args)
    {
        // Define the default path
        string defaultTargetDirectory = ".";
        string userInputTargetFolder = null;

        if (args.Length == 1)
        {
            if (args[0] == "-h" || args[0] == "--help")
            {
                Console.WriteLine("Usage: cleansolution [path]");
                return;
            }
            if (args[0] == "-v" || args[0] == "--version")
            {
                Console.WriteLine("Version 1.0.0");
                return;
            }

            var parameterTargetFolder = args[0];
            if (!Directory.Exists(parameterTargetFolder))
            {
                Console.WriteLine("Directory does not exist.");
                return;
            }
            else
            {
                userInputTargetFolder = args[0];
            }
        }

        if (args.Length == 0)
        {
            Console.WriteLine("Enter the path to the solution directory [or press Enter to use current path]");

            // Read user input
            userInputTargetFolder = Console.ReadLine();
        }

        // Use the user input if provided, otherwise use the default path
        var targetFolder = string.IsNullOrEmpty(userInputTargetFolder) ? defaultTargetDirectory : userInputTargetFolder;

        string targetFolderFullPath = Path.GetFullPath(targetFolder);

        if (!Directory.Exists(targetFolderFullPath))
        {
            Console.WriteLine("Directory does not exist.");
            return;
        }

        try
        {
            Console.WriteLine($"Cleaning up target: '{targetFolderFullPath}'");

            new SolutionCleaner().Run(targetFolderFullPath);

            Console.WriteLine("Cleanup completed successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }

        Console.WriteLine("");
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}

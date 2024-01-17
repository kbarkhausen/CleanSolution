namespace CleanSolution
{
    public class SolutionCleaner
    {
        private string _userInputToAction = "";

        public void Run(string path)
        {
            DeleteCompiledDirectories(path);
        }

        private string[] FoldersToDelete = new string[] { "bin", "obj", "TestResults", "node_modules", "packages" };

        public void DeleteCompiledDirectories(string parentDirectory)
        {
            var foldersinTarget = Directory.GetDirectories(parentDirectory);

            foreach (var folderPath in foldersinTarget)
            {
                string folderName = Path.GetFileName(folderPath);

                if (FoldersToDelete.Contains(folderName))
                {
                    if (_userInputToAction == "C")
                    {
                        Console.WriteLine($"Deleting '{folderPath}'.");
                        Directory.Delete(folderPath, true);
                    }
                    else
                    {
                        Console.WriteLine($"Can I delete '{folderPath}'?");
                        Console.WriteLine("Reply [Y] to delete, [N] to skip or [C] to delete all silently.");

                        var userInput = Console.ReadKey().KeyChar.ToString().ToUpper();
                        Console.WriteLine($"");

                        if (userInput == "Y")
                        {
                            Console.WriteLine($"Deleting '{folderPath}'.");
                            Directory.Delete(folderPath, true);
                        }
                        else if(userInput == "C")
                        {
                            _userInputToAction = "C";
                            Console.WriteLine($"Deleting '{folderPath}'.");
                            Directory.Delete(folderPath, true);
                        }
                        else if (userInput == "N")
                        {
                            Console.WriteLine($"Skipping '{folderPath}'.");
                        }
                        else
                        {
                            throw new Exception("Invalid input.");
                        }
                    }
                }
                else
                {
                    DeleteCompiledDirectories(folderPath);
                }
            }
        }
    }
}

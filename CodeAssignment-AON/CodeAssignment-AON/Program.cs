using System;
using System.IO;
using AONLibrary.BusinessLogic;

namespace CodeAssignment_AON
{
    class Program
    {
        /// <summary>
        /// Handle Multiple of the number
        /// </summary>
        /// <param name="number"></param>
        static void HandleMultiples(int number)
        {
            for (int i = 1; i <= number; i++)
            {

                Console.WriteLine(NumberMultiplier.GetResultForNumber(i));
            }
        }
        /// <summary>
        /// Responsible for Manipulate file with possible results based on conditions
        /// </summary>
        /// <param name="path"></param>
        static void ManageFileOperations(string path)
        {
            if (File.Exists(path))
            {
                FileHandler.ManipulateFile(path);
                Console.WriteLine("Done with validations,Please check the file - FilePath: " + path);
            }
            else
            {
                Console.WriteLine("File not found at specified path " + path);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("For multiples of numbers(First part) Enter '1' \n" +
                "For file operations(Second part) Enter '2'");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("Please enter the number");
                    int number = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("RESULT :\n");
                    HandleMultiples(number);
                    break;
                case 2:
                    Console.WriteLine("Please enter the File path");
                    string path = Console.ReadLine();
                    ManageFileOperations(path);
                    break;
            }

        }
    }
}

using System;

namespace PowersTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learn your squares and cubes!");

            while (true)
            {
                string userNumberString = "";
                int userNumber;

                Console.WriteLine("How many numbers should we practice?");
                userNumberString = Console.ReadLine();

                while (!IsValidInteger(userNumberString)) 
                {
                    userNumberString = GetUserResponse("Sorry, that's not a valid integer. How many numbers should we practice?");
                }

                userNumber = int.Parse(userNumberString);

                BuildPowersTable(userNumber);

                if (!UserWantsToContinue())
                {
                    Console.WriteLine("See you next time.");
                    break;
                }
            }
        }
        public static bool IsValidInteger(string numAsString)
        {
            int num;

            bool isInteger = int.TryParse(numAsString, out num);

            return isInteger;
        }
        public static void BuildPowersTable(int maxNumber)
        {
            Console.WriteLine("Number\tSquared\tCubed");
            Console.WriteLine("======\t=======\t=====");
            for (int i = 1; i <= maxNumber; i++)
            {
                Console.WriteLine($"{i}\t{SquareAnInteger(i)}\t{CubeAnInteger(i)}");
            }
        }
        public static bool UserWantsToContinue()
        {
            string userResponse;

            userResponse = GetUserResponse("Should we keep practicing? (y/n)").ToLower();

            while (userResponse != "n" && userResponse != "y")
            {
                userResponse = GetUserResponse("Sorry, I didn't understand that. Should we keep practicing? y/n").ToLower();
            }

            if (userResponse == "n")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static string GetUserResponse(string prompt)
        {
            string userResponse;

            Console.WriteLine(prompt);
            userResponse = Console.ReadLine();

            return userResponse;
        }
        public static int SquareAnInteger(int num) 
        {
            return num * num;
        }
        public static int CubeAnInteger(int num) 
        {
            return num * num * num;
        }
    }
}

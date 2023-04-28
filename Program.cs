namespace UnityJuniorDeveloper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isExit = false;
            string closeProgram = "exit";
            string programExitMessage = "The game is over";
            string userIput;
            string programGreeting = "Здравтсвуй пользователь!";
            string actionSuggestion = $"Введите собщение. \nДля выхода из программы наберите - \"{closeProgram}\" ";

            Console.WriteLine(programGreeting);

            while (isExit == false)
            {
                Console.WriteLine(actionSuggestion);
                userIput = Console.ReadLine();
                Console.WriteLine(userIput);

                if (userIput == closeProgram)
                {
                    Console.WriteLine(programExitMessage);
                    isExit = true;
                }
            }           
        }
    }
}
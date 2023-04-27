namespace UnityJuniorDeveloper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isExit = false;
            string closeProgram = "exit";
            string userIput;
            
            Console.WriteLine("Введите собщение: ");
            userIput = Console.ReadLine();

            while(isExit == false)
            {
                Console.WriteLine(userIput);
                userIput = Console.ReadLine();

                if (userIput == closeProgram)
                {
                    isExit = true;
                }
            }           
        }
    }
}
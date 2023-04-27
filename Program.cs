namespace UnityJuniorDeveloper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isExit = false;
            string closeProgram = "exit";
            string userIput;
            
           
            userIput = Console.ReadLine();

            while(isExit == false)
            {
                Console.WriteLine("Введите собщение: ");
                userIput = Console.ReadLine();
                Console.WriteLine(userIput);

                if (userIput == closeProgram)
                {
                    isExit = true;
                }
            }           
        }
    }
}
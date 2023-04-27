namespace UnityJuniorDeveloper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string closeProgram = "exit";
            string userIput;
            
            Console.WriteLine("Введите собщение: ");
            userIput = Console.ReadLine();

            while(userIput != closeProgram)
            {
                Console.WriteLine(userIput);
                userIput = Console.ReadLine();
            }           
        }
    }
}
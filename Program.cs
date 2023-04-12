namespace UnityJuniorDeveloper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfRepetitions;
            string userMessage;

            Console.WriteLine("Введите сообщение которое нужно вывести: ");
            userMessage = Console.ReadLine();
            Console.WriteLine("Введите сколько раз нужно вывести ваше сообщение: ");
            countOfRepetitions = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < countOfRepetitions; i++)
            {
                Console.WriteLine(userMessage);
            }

            Console.ReadKey();
        }
    }
}
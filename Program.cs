namespace UnityJuniorDeveloper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sequenceValue = 5;
            int progressionDifference = 7;          
            int finalSequenceValue = 96;

            for(int i = sequenceValue; i <= finalSequenceValue; i+= progressionDifference)
            {
                Console.WriteLine(i);
            }
        }
    }
}
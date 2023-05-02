namespace UnityJuniorDeveloper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sequenceValue;
            int progressionDifference = 7;          
            int finalSequenceValue = 96;

            for(sequenceValue = 5; sequenceValue <= finalSequenceValue; sequenceValue+= progressionDifference)
            {
                Console.WriteLine(sequenceValue);
            }


        }
    }
}
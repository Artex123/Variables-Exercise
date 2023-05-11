namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string myName = "Ben";
            int myWeight = 170;
            char myFirstInitial = 'B';
            bool isCoding = true;
            double myWeights = 170.00;
            decimal money = 1000.00m;
            Console.WriteLine($"Hello, my name is {myName}.  I weigh {myWeight}lbs and the first initial of my name is {myFirstInitial}.  It is {isCoding} that I enjoy this class." +
                $"If I did not weigh {myWeights}, I would most likely have more money than ${money}.");

        }
    }
}

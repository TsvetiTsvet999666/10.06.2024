namespace Exersice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int input;
            Console.WriteLine("Enter whole numbers. Enter 0 to end.");
            while ((input = int.Parse(Console.ReadLine())) != 0)
            {
                numbers.Add(input);
            }
            if (numbers.Count > 0)
            {
                int maxNumber = numbers.Max();
                int maxPosition = numbers.IndexOf(maxNumber) + 1; 
                int positiveCount = numbers.Count(n => n > 0);
                int negativeCount = numbers.Count(n => n < 0);
                int threeDigitCount = numbers.Count(n => n >= 100 && n <= 999 || n <= -100 && n >= -999);
                double average = numbers.Average();
                Console.WriteLine($"The largest of the numbers entered is {maxNumber},entered on {maxPosition} position.");
                Console.WriteLine($"Number of positive numbers - {positiveCount}.");
                Console.WriteLine($"Number of negative numbers- {negativeCount}.");
                Console.WriteLine($"Number of three-digit numbers - {threeDigitCount}.");
                Console.WriteLine($"Arithmetic average of the entered numbers is {average:F2}.");
            }         
        }
    }
}

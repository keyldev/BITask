using System.Diagnostics;

namespace LogicMicroservice.Services
{
    public class SummaryService : ISummaryService
    {
        public int CalculateSecondOdd(int[] numbers)
        {
            int[] oddNums = numbers.Where(n => n % 2 != 0).ToArray();
            int sum = 0;
            for (int i = 1; i < oddNums.Length; i += 2)
            {
                sum += oddNums[i];
               
            }

            return Math.Abs(sum);
        }
    }
}

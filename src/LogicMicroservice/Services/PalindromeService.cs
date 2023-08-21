namespace LogicMicroservice.Services
{
    public class PalindromeService : IPalindromeService
    {
        public bool IsPalindrome(string source)
        {
            bool isPalindrome = true;
            for (int i = 0; i < source.Length / 2; i++)
            {
                if (source[i] != source[source.Length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }
            return isPalindrome;
        }
    }
}

namespace Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 Divisible by 3 and 4
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine((num % 3 == 0 && num % 4 == 0) ? "Yes" : "No");
            #endregion

            #region Q2 Positive or Negative
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n < 0 ? "negative" : "positive");
            #endregion

            #region Q3 Max and Min of 3 Numbers
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Max = " + Math.Max(a, Math.Max(b, c)));
            Console.WriteLine("Min = " + Math.Min(a, Math.Min(b, c)));
            #endregion

            #region Q4 Even or Odd
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1 % 2 == 0 ? "Even" : "Odd");
            #endregion

            #region Q5 Vowel or Consonant
            char ch = char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();
            Console.WriteLine("aeiou".Contains(ch) ? "vowel" : "consonant");
            #endregion



        }


    }
}

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

            #region Q6 Print from 1 to N
            int num2 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num2; i++)
                Console.Write(i + " ");
            #endregion

            #region Q7 Multiplication Table
            int num3 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 12; i++)
                Console.Write(num3 * i + " ");
            #endregion

            #region Q8 Even Numbers from 1 to N
            int num4 = int.Parse(Console.ReadLine());
            for (int i = 2; i <= num4; i += 2)
                Console.Write(i + " ");
            #endregion

            #region Q9 Write a program that takes two integers then prints the power
            int NUM1 = int.Parse(Console.ReadLine());
            int NUM2 = int.Parse(Console.ReadLine());
            int result = 1;
            for (int i = 0; i < NUM2; i++)
                result *= NUM1;
            Console.WriteLine(result);
            #endregion

            #region Q10 Marks Total, Avg, %
            int total = 0;
            for (int i = 1; i <= 5; i++)
                total += int.Parse(Console.ReadLine());
            float average = total / 5f;
            float percentage = (total / 500f) * 100;
            Console.WriteLine($"Total = {total}, Avg = {average}, % = {percentage}");
            #endregion

            #region Q11 Days in Month
            int m = int.Parse(Console.ReadLine());
            int days = m switch
            {
                1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
                4 or 6 or 9 or 11 => 30,
                2 => 28,
                _ => 0
            };
            Console.WriteLine("Days in Month: " + days);
            #endregion

            #region Q12 Simple Calculator
            double x = double.Parse(Console.ReadLine());
            char op = char.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            double result1 = op switch
            {
                '+' => x + y,
                '-' => x - y,
                '*' => x * y,
                '/' => y != 0 ? x / y : double.NaN,
                _ => double.NaN
            };
            Console.WriteLine("Result: " + result);
            #endregion

            

        }


    }
}

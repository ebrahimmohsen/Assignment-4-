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

            #region Q13 Reverse a String
            string str = Console.ReadLine();
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            Console.WriteLine(new string(chars));
            #endregion

            #region Q14 Reverse an Integer
            int number = int.Parse(Console.ReadLine());
            int rev = 0;
            while (num != 0)
            {
                rev = rev * 10 + number % 10;
                number /= 10;
            }
            Console.WriteLine("Reversed: " + rev);
            #endregion

            #region Q15 Prime Numbers in Range
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                bool isPrime = true;
                if (i <= 1) isPrime = false;
                for (int j = 2; j * j <= i; j++)
                    if (i % j == 0) isPrime = false;
                if (isPrime) Console.Write(i + " ");
            }
            #endregion

            #region Q16 Decimal to Binary
            int number1 = int.Parse(Console.ReadLine());
            int binary = 0, baseVal = 1;

            while (number1 > 0)
            {
                int rem = number1 % 2;
                binary += rem * baseVal;
                baseVal *= 10;
                number1 /= 2;
            }
            Console.WriteLine("Binary: " + binary);
            #endregion

            #region Q17 Points on a Line
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());

            double area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
            Console.WriteLine(area == 0 ? "Points lie on a straight line" : "Not on a straight line");
            #endregion

            #region Q18 Worker Efficiency
            float hours = float.Parse(Console.ReadLine());
            if (hours >= 2 && hours < 3)
                Console.WriteLine("Highly Efficient");
            else if (hours >= 3 && hours < 4)
                Console.WriteLine("Increase Speed");
            else if (hours >= 4 && hours <= 5)
                Console.WriteLine("Training Required");
            else
                Console.WriteLine("Leave Company");
            #endregion

            #region Q19  Identity Matrix
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                    Console.Write(i == j ? "1 " : "0 ");
                Console.WriteLine();
            }
            #endregion

            #region Q20 Sum of Array
            int[] arr = { 1, 2, 3, 4, 5 };
            int sum = 0;
            foreach (int val in arr) sum += val;
            Console.WriteLine("Sum: " + sum);
            #endregion

            #region Q21 Merge Two Arrays Sorted
            int[] A = { 1, 3, 5 };
            int[] B = { 2, 4, 6 };
            int[] merged = A.Concat(B).OrderBy(x => x).ToArray();
            Console.WriteLine(string.Join(" ", merged));
            #endregion



        }


    }
}

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

        }
    }
}

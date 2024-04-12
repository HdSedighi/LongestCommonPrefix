
internal class Program
{
    private static void Main(string[] args)
    {
           //call solution class from mymethod.cs
            Solution sol = new Solution();
            string[] strs = new string[] { "flower", "flow", "flight" };
            Console.WriteLine(sol.LongestCommonPrefix(strs));
    }
}
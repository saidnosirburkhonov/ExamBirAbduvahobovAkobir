namespace Exam1;

internal class Program
{
    static List<int> lst = new List<int>() { 22, 1, 2, 1, 2, 12 };
    static void Main(string[] args)
    {
        Console.WriteLine(Task6(lst));
    }
    static int Task1(List<int> nums)
    {
        var count = 0;
        foreach (var num in nums)
        {
            if (num % 2 == 0)
            {
                ++count;
            }
        }
        return count;
    }
    static bool Task2(List<string> text)
    {
        return text.All(x => x.Length > 5);
    }
    static string Task3(string text)
    {
        return text.Substring(0, 3);
    }
    static bool Task4(string text)
    {
        if (text.StartsWith("PDP"))
        {
            return true;
        }
        return false;
    }
    static bool Task5(string text)
    {
        if (text.Contains("G13"))
        {
            return true;
        }
        return false;
    }
    static int Task6(List<int> nums)
    {
        var count = nums[0] + nums[1];
        return count;
    }
}

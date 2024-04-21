namespace NumbersInWords;

public static class NumberInWordsExt
{
    private static Dictionary<long, string> numbers = new Dictionary<long, string>()
    {
        {1, "one"},
        {2, "two"},
        {3, "three"},
    };

    public static string ToWord(this long n)
    {
        if(numbers.ContainsKey(n))
            return numbers[n];
        else
            return "unknown number";
    }
}

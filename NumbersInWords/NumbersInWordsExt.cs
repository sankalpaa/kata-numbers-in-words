namespace NumbersInWords;

public static class NumberInWordsExt
{
    public static string ToWord(this long n)
    {
        if(n == 3)
            return "three";
        else if(n == 2)
            return "two";
        else
            return "one";
    }
}

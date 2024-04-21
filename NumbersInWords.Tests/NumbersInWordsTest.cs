namespace NumbersInWords.Tests;

public class NumbersInWordsTest
{
    [Theory]
    [InlineData(1, "one")]
    [InlineData(2, "two")]
    [InlineData(3, "three")]

    public void ShouldReturnNumberInWord(long number, string expected)
    {
        Assert.Equal(expected, number.ToWord());
    }
}
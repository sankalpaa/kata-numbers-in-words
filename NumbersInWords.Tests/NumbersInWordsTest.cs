namespace NumbersInWords.Tests;

public class NumbersInWordsTest
{
    [Fact]
    public void ShouldReturnNumberOneInWord()
    {
        long number = 1;
        Assert.Equal("one", number.ToWord());
    }

    [Fact]
    public void ShouldReturnNumberTwoInWord()
    {
        long number = 2;
        Assert.Equal("two", number.ToWord());
    }
}
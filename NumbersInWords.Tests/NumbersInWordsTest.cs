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

    [Fact]
    public void ShouldReturnNumberThreeInWord()
    {
        long number = 3;
        Assert.Equal("three", number.ToWord());
    }
}
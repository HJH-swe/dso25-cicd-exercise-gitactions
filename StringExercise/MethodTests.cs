using System.Configuration.Assemblies;
using Xunit;

public class MethodTests
{
    [Fact]
    public void TestReverseString()
    {
        // given
        StringMethods sm = new StringMethods();
        string input = "abcde";
        string expected = "edcba";

        // when
        string result = StringMethods.ReverseString(input);

        // then
        Assert.Equal(expected, result);

    }

    public void TestMergeStrings()
    {
        // given
        StringMethods sm = new StringMethods();
        string str1 = "Hello, ";
        string str2 = "World!";
        string expected = "Hello, World!";

        // when
        string result = StringMethods.MergeStrings(str1, str2);

        // then
        Assert.Equal(expected, result);
    }

    public void TestRemoveWhitespace()
    {
        // given
        StringMethods sm = new StringMethods();
        string input = "te   sti ng, 1  23";
        string expected = "testing,123";

        // when
        string result = StringMethods.RemoveWhitespace(input);

        // then
        Assert.Equal(expected, result);
    }
}
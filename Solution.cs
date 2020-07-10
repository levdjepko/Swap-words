using System;

public class Solution
{
    public static void ReverseWords(char[] message)
    {
        // Decode the message by reversing the words
        ReverseChars (message, 0, message.Length - 1);
        Console.WriteLine ( message);
        int currentWordStartIndex = 0;
        
        for (int i = 0; i <= message.Length; i++ ){
            if (i == message.Length || message[i] == ' ') {
                ReverseChars(message, currentWordStartIndex, i - 1);
                currentWordStartIndex = i+1;
            }
        }

    }



    public static void ReverseChars(char[] message, int leftIndex, int rightIndex) {
        
        while (leftIndex < rightIndex) {
            //swaps all the chars in this message
            char temp = message[leftIndex];
            message[leftIndex] = message[rightIndex];
            message[rightIndex] = temp;
            
            leftIndex++;
            rightIndex--;
        }
    }














    // Tests

    [Fact]
    public void OneWordTest()
    {
        var expected = "vault".ToCharArray();
        var actual = "vault".ToCharArray();
        ReverseWords(actual);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TwoWordsTest()
    {
        var expected = "cake thief".ToCharArray();
        var actual = "thief cake".ToCharArray();
        ReverseWords(actual);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ThreeWordsTest()
    {
        var expected = "get another one".ToCharArray();
        var actual = "one another get".ToCharArray();
        ReverseWords(actual);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void MultipleWordsSameLengthTest()
    {
        var expected = "the cat ate the rat".ToCharArray();
        var actual = "rat the ate cat the".ToCharArray();
        ReverseWords(actual);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void MultipleWordsDifferentLengthsTest()
    {
        var expected = "chocolate bundt cake is yummy".ToCharArray();
        var actual = "yummy is cake bundt chocolate".ToCharArray();
        ReverseWords(actual);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void EmptyStringTest()
    {
        var expected = "".ToCharArray();
        var actual = "".ToCharArray();
        ReverseWords(actual);
        Assert.Equal(expected, actual);
    }

    public static void Main(string[] args)
    {
        TestRunner.RunTests(typeof(Solution));
    }
}

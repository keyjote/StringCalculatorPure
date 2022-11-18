namespace StringCalculatorPure.Test;

public class CalculatorAddTest
{
    /*
     *
     *
•    add("1,2,3") => 6
•    add("") => 0
•    add("42") => 42
•    add("-1,1") => 0  // negative numbers is extra, crash or ignore if you like. 😉Wink
•    add("1 3 5") => 9 // whitespace as separator is extra, crash if you like.
     * 
     */
    [Theory]
    [InlineData("1,2,3", 6)]
    [InlineData("", 0)]
    [InlineData("42", 42)]
    [InlineData("-1,1", 0)]
    [InlineData("1 3 5", 9)]
    [InlineData("1 A B", 1)]
    [InlineData("what is this all about?, I mean, come on dude! this has been broken since 1969", 1969)]
    public void add_test(string inputData, int expectedResult)
    {
        var result = Calculator.Add(inputData);
        
        Assert.Equal(expectedResult, result);
    }
}
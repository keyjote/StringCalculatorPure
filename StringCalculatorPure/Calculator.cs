namespace StringCalculatorPure;

public static class Calculator
{
    public static int Add(string dataAsString)
    {
        if (string.IsNullOrWhiteSpace(dataAsString))
        {
            return 0;
        }

        var splitList = dataAsString.Replace(" ", ",")
                                    .Split(",")
                                    .ToList();

        var result = splitList.Sum(sValue => int.TryParse(sValue, out var intValue) ? intValue : 0);

        return result;
    }
}
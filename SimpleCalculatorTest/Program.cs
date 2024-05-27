namespace SimpleCalculatorTest
{
    internal class Program
    {
        private const string Usage = "Usage: <firstNumber> <secondNumber> <operator>";
        private static string InvalidOperation => $"Invalid Operation Provided\r\n{Usage}\r\n";
        private static string NumericValue => $"Numeric Value Expected\r\n{Usage}\r\n";
        private static void Main()

        {
            List<string> Arguments;
            string ExpectedResult;

            var unitTests = new List<UnitTest>();

            Arguments = new List<string>() { "2", "2", "unknown" };
            ExpectedResult = InvalidOperation;
            unitTests.Add(new UnitTest(Arguments, ExpectedResult));

            Arguments = new List<string>() { "2", "2", "unknown", "invalid" };
            ExpectedResult = Usage;
            unitTests.Add(new UnitTest(Arguments, ExpectedResult));

            Arguments = new List<string>() { "2", "2", "multiply" };
            ExpectedResult = "4";
            unitTests.Add(new UnitTest(Arguments, ExpectedResult));

            Arguments = new List<string>() { "2", "2", "*" };
            ExpectedResult = "4";
            unitTests.Add(new UnitTest(Arguments, ExpectedResult));

            Arguments = new List<string>() { "2", "2", "/" };
            ExpectedResult = "1";
            unitTests.Add(new UnitTest(Arguments, ExpectedResult));

            Arguments = new List<string>() { "2", "2", "divide" };
            ExpectedResult = "1";
            unitTests.Add(new UnitTest(Arguments, ExpectedResult));

            Arguments = new List<string>() { "2", "2", "Subtract" };
            ExpectedResult = "0";
            unitTests.Add(new UnitTest(Arguments, ExpectedResult));

            Arguments = new List<string>() { "1", "2", "-" };
            ExpectedResult = "-1";
            unitTests.Add(new UnitTest(Arguments, ExpectedResult));

            Arguments = new List<string>() { "2", "2", "+" };
            ExpectedResult = "4";
            unitTests.Add(new UnitTest(Arguments, ExpectedResult));

            Arguments = new List<string>() { "zero", "2", "-" };
            ExpectedResult = NumericValue;
            unitTests.Add(new UnitTest(Arguments, ExpectedResult));


            foreach (var test in unitTests)
            {
                var result = SimpleCalculator.Program.Run(test.Arguments.ToArray());
                if (!result.Equals(test.ExpectedResult))
                    Console.WriteLine($"Fail: {result}");
            }
        }
    }

    internal class UnitTest
    {
        internal List<string> Arguments;
        internal string ExpectedResult;

        internal UnitTest(List<string> Arguments, string ExpectedResult)
        {
            this.Arguments = Arguments;
            this.ExpectedResult = ExpectedResult;
        }
    }
}
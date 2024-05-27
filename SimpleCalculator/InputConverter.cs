namespace SimpleCalculator
{
    internal class InputConverter
    {
        internal static double GetDouble(string input)
        {
            if (string.IsNullOrWhiteSpace(input) || !double.TryParse(input, out var result))
                throw Program.NumericValueException;

            return result;
        }

        internal static OperationEnum GetOperation(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                throw Program.InvalidOperationException;

            const bool ignoreCase = true;
            if (!Enum.TryParse<OperationEnum>(input, ignoreCase, out OperationEnum result))
            {
                result = input switch
                {
                    "+" => OperationEnum.Add,
                    "-" => OperationEnum.Subtract,
                    "*" => OperationEnum.Multiply,
                    "/" => OperationEnum.Divide,
                    _ => throw Program.InvalidOperationException
                };
            }

            return result;
        }
    }
}
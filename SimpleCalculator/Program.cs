using System.Text;

namespace SimpleCalculator
{
    internal enum OperationEnum
    {
        None,
        Add,
        Subtract,
        Multiply,
        Divide
    }

    public class Program
    {
        internal static ArgumentException InvalidOperationException => new("Invalid Operation Provided");
        internal static ArgumentException NumericValueException => new("Numeric Value Expected");
        internal static string Usage => "Usage: <firstNumber> <secondNumber> <operator>";

        internal static void Main(string[] args)
        {
            var result = Run(args);
            Console.WriteLine(result);
        }

        public static string Run(string[] args)
        {
            try
            {
                if (!(args.Length == 3))
                    return Usage;

                double firstNumber = InputConverter.GetDouble(args[0]);
                double secondNumber = InputConverter.GetDouble(args[1]);
                OperationEnum operation = InputConverter.GetOperation(args[2]);

                var result = CalculateEngine.Calculate(firstNumber, secondNumber, operation);
                return $"{result}";
            }
            catch (Exception e)
            {
                var sb = new StringBuilder();
                sb.AppendLine(e.Message);
                sb.AppendLine(Usage);
                return sb.ToString();
            }
        }
    }
}
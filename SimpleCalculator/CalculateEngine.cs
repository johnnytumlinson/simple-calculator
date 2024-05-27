namespace SimpleCalculator
{
    internal class CalculateEngine
    {
        internal static double Calculate(double firstNumber, double secondNumber, OperationEnum operation)
        {
            var result = operation switch
            {
                OperationEnum.Add => firstNumber + secondNumber,
                OperationEnum.Subtract => firstNumber - secondNumber,
                OperationEnum.Multiply => firstNumber * secondNumber,
                OperationEnum.Divide => firstNumber / secondNumber,
                _ => throw new ArgumentException("Invalid Operation"),
            };
            return result;
        }
    }
}
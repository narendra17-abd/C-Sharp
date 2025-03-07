namespace CalculatorLibrary
{
    public class Calculator
    {
        int num1, num2, sum, difference, product, quotient;
        public void getNumbers()
        {
            Console.WriteLine("Enter two numbers ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
        }
        public void Addition()
        {
            sum = num1 + num2;
            Console.WriteLine($"Addition Result {sum}");
        }
        public void Subtraction()
        {
            difference = num1 - num2;
            Console.WriteLine($"Subtraction Result {difference}");
        }
        public void Multiplication()
        {
            product = num1 * num2;
            Console.WriteLine($"Multiplication Result {product}");
        }
        public void Division()
        {
            quotient = num1 / num2;
            Console.WriteLine($"Division Result {quotient}");
        }
    }
}

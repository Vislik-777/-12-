using System; // Добавляем using для использования Console и DivideByZeroException

public static class Calculator
{
    public static double Add(double a, double b)
    {
        return a + b;
    }

    public static double Subtract(double a, double b)
    {
        return a - b;
    }

    public static double Multiply(double a, double b)
    {
        return a * b;
    }

    public static double Divide(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Division by zero is not allowed.");
        }
        return a / b;
    }
}

// Добавляем класс Program с методом Main
public class Program
{
    public static void Main(string[] args)
    {
        // Пример использования методов Calculator
        double num1 = 10.5;
        double num2 = 5.2;

        // Сложение
        double sum = Calculator.Add(num1, num2);
        Console.WriteLine($"Сложение: {num1} + {num2} = {sum}");

        // Вычитание
        double difference = Calculator.Subtract(num1, num2);
        Console.WriteLine($"Вычитание: {num1} - {num2} = {difference}");

        // Умножение
        double product = Calculator.Multiply(num1, num2);
        Console.WriteLine($"Умножение: {num1} * {num2} = {product}");

        // Деление
        try
        {
            double quotient = Calculator.Divide(num1, num2);
            Console.WriteLine($"Деление: {num1} / {num2} = {quotient}");

            // Пример деления на ноль
            double zeroResult = Calculator.Divide(num1, 0);
            Console.WriteLine($"Деление на ноль: {num1} / 0 = {zeroResult}"); // Эта строка не будет выполнена
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }

        Console.WriteLine("\nНажмите Enter для выхода...");
        Console.ReadLine(); // Ожидание нажатия Enter, чтобы окно консоли не закрылось сразу
    }
}

using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите значение дохода за год: ");
        double annualIncome = Convert.ToDouble(Console.ReadLine());

        // Визначення ставок податку для різних діапазонів річного доходу
        double taxRate1 = 0.1;
        double taxRate2 = 0.15;
        double taxRate3 = 0.2;

        double tax = 0;
        if (annualIncome <= 50000)
        {
            tax = annualIncome * taxRate1;
        }
        else if (annualIncome <= 100000)
        {
            tax = 50000 * taxRate1 + (annualIncome - 50000) * taxRate2;
        }
        else
        {
            tax = 50000 * taxRate1 + 50000 * taxRate2 + (annualIncome - 100000) * taxRate3;
        }
        Console.WriteLine($"Податок на дохід: {tax}");
    }
}
using System;

namespace CarShippingCostCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            ShippingCostInput input = new ShippingCostInput();

            Console.WriteLine("Калькулятор стоимости доставки автомобиля");

            Console.Write("Введите марку автомобиля: ");
            input.CarMake = Console.ReadLine();

            Console.Write("Введите модель автомобиля: ");
            input.CarModel = Console.ReadLine();

            Console.Write("Введите вес автомобиля (фунты): ");
            input.CarWeight = double.Parse(Console.ReadLine());

            Console.Write("Введите расстояние (мили): ");
            input.Distance = double.Parse(Console.ReadLine());

            Console.Write("Введите способ доставки (стандартный/экспресс): ");
            input.ShippingMethod = Console.ReadLine();

            ShippingCostCalculator calculator = new ShippingCostCalculator();
            double cost = calculator.CalculateShippingCost(input);
            Console.ReadKey();

            Console.WriteLine($"Ориентировочная стоимость доставки: ${cost:F2}");
            Console.ReadKey();
        }
    }
}

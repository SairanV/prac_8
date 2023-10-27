using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Получаем текущее время
            DateTime currentTime = DateTime.Now;

            // Устанавливаем время начала и окончания скидки (с 8:00 до 12:00)
            DateTime discountStartTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 8, 0, 0);
            DateTime discountEndTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 12, 0, 0);

            // Создаем массив продуктов
            Product[] products = new Product[]
            {
            new Product("Яблоки", 2.0),
            new Product("Молоко", 1.5),
            new Product("Хлеб", 1.0),
            };

            // Рассчитываем общую стоимость
            double totalCost = 0;

            foreach (Product product in products)
            {
                Console.Write($"Введите количество {product.Name}: ");
                int quantity = int.Parse(Console.ReadLine());

                // Проверяем, находится ли текущее время в интервале скидки
                if (currentTime >= discountStartTime && currentTime <= discountEndTime)
                {
                    // Применяем скидку 5%
                    totalCost += (product.Price * quantity) * 0.95;
                }
                else
                {
                    totalCost += product.Price * quantity;
                }
            }

            Console.WriteLine($"Общая стоимость покупки: {totalCost:C}");
        }
    }
}

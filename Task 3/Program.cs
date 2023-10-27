using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Заданные данные о продажах за пять последних месяцев
            double[] salesData = { 100, 120, 135, 155, 170 };

            // Вызов метода наименьших квадратов для прогнозирования следующих трех месяцев
            double[] forecastedSales = ForecastSales(salesData, 3);

            Console.WriteLine("Прогноз объемов продаж на следующие три месяца:");
            for (int i = 0; i < forecastedSales.Length; i++)
            {
                Console.WriteLine($"Месяц {i + 1}: {forecastedSales[i]}");
            }
        }

        static double[] ForecastSales(double[] salesData, int numMonths)
        {
            int n = salesData.Length;

            // Создаем массив для хранения прогнозируемых объемов продаж
            double[] forecastedSales = new double[numMonths];

            // Расчет коэффициентов линейной регрессии (a и b)
            double sumX = 0;
            double sumY = 0;
            double sumXY = 0;
            double sumX2 = 0;

            for (int i = 0; i < n; i++)
            {
                sumX += i + 1;
                sumY += salesData[i];
                sumXY += (i + 1) * salesData[i];
                sumX2 += (i + 1) * (i + 1);
            }

            double a = (n * sumXY - sumX * sumY) / (n * sumX2 - sumX * sumX);
            double b = (sumY - a * sumX) / n;

            // Прогнозируем объемы продаж для следующих месяцев
            for (int i = 0; i < numMonths; i++)
            {
                forecastedSales[i] = a * (n + i + 1) + b;
            }

            return forecastedSales;
        }
    }
}

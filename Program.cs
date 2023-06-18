using System;
using System.IO;
using System.Collections.Generic;
using ConsoleApp8;
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 100;
            List<int> numbers = One.GenerateValue(count);
            List<int> primeNumbers = One.GetPrimeNumbers(numbers);
            List<int> fibonacciNumbers = One.GetFibonacciNumbers(numbers);
            string primeFilePath = @"C:\\Users\\Admin\\Desktop\prime_numbers.txt";
            string fibonacciFilePath = @"C:\\Users\\Admin\\Desktop\fibonacci_numbers.txt";
            One.SaveNumbersToFile(primeNumbers, primeFilePath);
            One.SaveNumbersToFile(fibonacciNumbers, fibonacciFilePath);
            Console.WriteLine("Тест завдання 1");
            Console.WriteLine("Кiлькiсть простих чисел: " + primeNumbers.Count);
            Console.WriteLine("Кiлькiсть чисел Фiбоначчi: " + fibonacciNumbers.Count);
            Console.WriteLine("Простi числа збережено у файл: " + primeFilePath);
            Console.WriteLine("Числа Фiбоначчi збережено у файл: " + fibonacciFilePath);
            Console.WriteLine( );
            Console.WriteLine("Тест завдання 4");
            /* string filePath = Console.ReadLine(); *///ВІД ШЛЯХУ Для завдання 4 
            One.ReverseFileContent(primeFilePath);
            Console.WriteLine( );
            Console.WriteLine("Тест завдання 5");
            string arrfile = @"C:\\Users\\Admin\\Desktop";
            One.SaveNumbersToFile(numbers, arrfile+ "\\arr.txt");
            One.AnalyzeFile(arrfile+ "\\arr.txt");
            One.CreateNumberFiles(numbers, arrfile);
        }
    }
}


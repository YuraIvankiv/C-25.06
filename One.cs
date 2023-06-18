using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp8
{
    internal class One
    {
        public List<int> arr = new List<int>();
        public One() { }
        public One(List<int> _arr)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                arr[i] = _arr[i];
            }
        }
        public static List<int> GenerateValue(int count)
        {
            List<int> arr = new List<int>();
            Random random = new Random();

            for (int i = 0; i < count; i++)
            {
                arr.Add(random.Next(1, 100));
                /*arr.Add(random.Next(-1000, 1000));*///Для завдання 5
            }

            return arr;
        }
        public static List<int> GetPrimeNumbers(List<int> numbers)
        {
            List<int> primeNumbers = new List<int>();

            foreach (int number in numbers)
            {
                if (IsPrime(number))
                {
                    primeNumbers.Add(number);
                }
            }

            return primeNumbers;
        }
        public static bool IsPrime(int number)
        {
            if (number < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
        public static List<int> GetFibonacciNumbers(List<int> numbers)
        {
            List<int> fibonacciNumbers = new List<int>();

            foreach (int number in numbers)
            {
                if (IsFibonacci(number))
                {
                    fibonacciNumbers.Add(number);
                }
            }

            return fibonacciNumbers;
        }
        public static bool IsFibonacci(int number)
        {
            int a = 0;
            int b = 1;

            while (b < number)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }

            return b == number;
        }
        public static void SaveNumbersToFile(List<int> numbers, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (int number in numbers)
                {
                    writer.WriteLine(number);
                }
            }
        }
        public static void ReverseFileContent(string filePath)//Метод для завдання 4
        {
            string reversedFilePath = Path.GetFileNameWithoutExtension(filePath) + "_reversed" + Path.GetExtension(filePath);

            string[] lines = File.ReadAllLines(filePath);
            Array.Reverse(lines);

            File.WriteAllLines(@"C:\\Users\\Admin\\Desktop\" + reversedFilePath, lines);

            Console.WriteLine("Вмiст файлу перевернуто та збережено у новому файлi: "+ @"C:\\Users\\Admin\\Desktop\" + reversedFilePath);
        }
        //ЗАВДАННЯ 5
        public static void AnalyzeFile(string filePath)
        {
            int positive = 0;
            int negative = 0;
            int twoDigit = 0;
            int fiveDigit = 0;

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    int number = int.Parse(line);

                    if (number > 0)
                        positive++;
                    else if (number < 0)
                        negative++;

                    if (number >= 10 && number <= 99)
                        twoDigit++;
                    else if (number >= 10000 && number <= 99999)
                        fiveDigit++;
                }
            }

            Console.WriteLine("Статистика файла:");
            Console.WriteLine("Кiлькiсть додатних чисел: " + positive);
            Console.WriteLine("Кiлькiсть вiд'ємних чисел: " + negative);
            Console.WriteLine("Кiлькiть двозначних чисел: " + twoDigit);
            Console.WriteLine("Кiлькiсть п'ятизначних чисел: " + fiveDigit);
        }
        public static void CreateNumberFiles(List<int> _arr,string filePath)
        {
            List<int> positive = new List<int>();
            List<int> negative = new List<int>();
            List<int> twoDigit = new List<int>();
            List<int> fiveDigit = new List<int>();

            foreach (int number in _arr)
            {
                if (number > 0)
                    positive.Add(number);
                else if (number < 0)
                    negative.Add(number);

                if (number >= 10 && number <= 99)
                    twoDigit.Add(number);
                else if (number >= 10000 && number <= 99999)
                    fiveDigit.Add(number);
            }

            SaveNumbersToFile(positive, filePath + @"\positive.txt");
            SaveNumbersToFile(negative, filePath + @"\negative.txt");
            SaveNumbersToFile(twoDigit, filePath + @"\two_digit.txt");
            SaveNumbersToFile(fiveDigit, filePath + @"\five_digit.txt");
        }
    }

}

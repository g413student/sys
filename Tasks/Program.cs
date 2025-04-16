using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var arr = new int[] { 2, 3, 5, 4, 5, 2, 4, 3, 5, 2, 4, 4, 2 };

            //int ElementOddTimes = Task8Ver1(arr);
            //Console.WriteLine(ElementOddTimes);

            //int task8 = Task8Ver2(arr);
            //Console.WriteLine(task8);


            //Task9();


            //Task10("Мое приложение", "Привет, это мой проект!", ConsoleColor.Yellow, ConsoleColor.Blue, ConsoleColor.Black);


            //Task13();


            Task14();
        }


        // Если в массиве все числа встречаются четное количество раз, кроме одного числа,
        // которое встречается нечетное количество раз, то результат XOR всех элементов массива
        // даст нам это единственное число, встречающееся нечетное количество раз.
        public static int Task8Ver1(int[] arr)
        {
            int xorResult = 0;

            // Проходим по всем элементам массива и выполняем XOR
            foreach (int num in arr)
            {
                xorResult ^= num;
            }

            // В конце xorResult будет содержать число, встречающееся нечетное количество раз
            return xorResult;
        }

        public static int Task8Ver2(int[] arr) 
        {
            foreach (int num in arr)
            {
                if (arr.Count(n => n == num) % 2 != 0)
                {
                    return num;
                }
            }

            throw new Exception("Не дойдет сюда, если передан массив, удовлетворяющий условию задания");
        }


        public static void Task9()
        {
            // Неточность: тип string должен начинаться с маленькой буквы
            // Ошибка: указание кол-ва элементов избыточно, т.к. автоматическое определение длины массива
            // Ошибка: некорректное объявление массива. Не указан тип массива справа при создании
            // 1 вариант:
            // string[] dogs = new string[] { "Hardly any", "More than a handful!", "Woah that's a lot of dogs!", "101 DALMATIONS!!!" };
            // string[] dogs = new string[4] { "Hardly any", "More than a handful!", "Woah that's a lot of dogs!", "101 DALMATIONS!!!" };
            var dogs = new string[4] { "Hardly any", "More than a handful!", "Woah that's a lot of dogs!", "101 DALMATIONS!!!" };
            // Неточность: тип string должен начинаться с маленькой буквы
            string respond;
            int number = 5;             // Ошибка в названии переменной: number

            if (number <= 10)           // Ошибка: отсутствуют скобки вокруг условия
            {
                respond = dogs[0];
            }
            else if (number <= 50)
            {
                respond = dogs[1];
            }
            else if (number == 101)      // Ошибка: отсутствует логическая операция, которая требуется в блоке if. Вместо этого - операция присваивания
            {
                respond = dogs[3];
            }
            else
            {
                respond = dogs[2];      // Ошибка: индекс массива за пределами границ (был 4, исправлен на 2)
            }

            Console.WriteLine(respond); // Ошибка: вывод на экран должен быть вне блока if, else, т.к. он един для всех условий и в данном случае символизирует конец функции
        }
        // Ошибка: пропущены } для метода Main и класса Program



        /// <summary>
        /// Метод настраивает внешний вид консоли в соответствии с переданными цветами и выводит переданное сообщение
        /// </summary>
        /// <param name="Title">Заголовок консольного интерфейса</param>
        /// <param name="Message">Сообщение</param>
        /// <param name="ForegroundColor">Цвет шрифта</param>
        /// <param name="PrimaryBackgroundColor">Основной цвет фона</param>
        /// <param name="SecondaryBackgroundColor">Вторичный цвет фона</param>
        public static void Task10(string Title, string Message, ConsoleColor ForegroundColor, ConsoleColor PrimaryBackgroundColor, ConsoleColor SecondaryBackgroundColor)
        {
            // Настраиваем консольный интерфейс (CUI)
            Console.Title = Title;
            Console.ForegroundColor = ForegroundColor;
            Console.BackgroundColor = PrimaryBackgroundColor;
            Console.WriteLine(Message);
            Console.BackgroundColor = SecondaryBackgroundColor;
            Console.ReadLine();

            // Метод общедоступный, его можно использовать везде в программе
        }


        public static int Task13()
        {
            Random random = new Random();
            const int n = 5;
            const int v = 20;
            int[,] a = new int[v, n];                       // Ошибка: поменяны местами строки и столбцы (было: n, v)
            int y = 5;
            int x = 0;
            for (int i = 0; i < v; i++)                     // Ошибка: индекс должен начинаться с нуля. Последний элемент имеет индекс = длина - 1, т.е. нужно невключительно
            {
                for (int z = 0; z < n; z++)                 // Ошибка: индекс должен начинаться с нуля. Последний элемент имеет индекс = длина - 1, т.е. нужно невключительно
                {
                    a[i, z] = random.Next(1, 5 + 1);        // Ошибка: последнее число невключительно ==> нужно +1
                    Console.Write(a[i, z] + " ");
                    if (a[i, z] == y)                       // Ошибка: отсутствует логическая операция, которая требуется в блоке if. Вместо этого - операция присваивания
                    {
                        x++;
                    }
                }
                Console.WriteLine();                        // Ошибка: перенос строки был после каждого значения в строке. Должен быть после каждой строки
                // Console.WriteLine(x);                    // Ошибка: вывод x после каждой строки, а нужно только итоговое значение
                // Console.ReadLine();                      // Ошибка: чтение с консоли после каждой строки. Из-за этого после первой строки будет бесконечное ожидание ввода
            }

            Console.WriteLine(x);
            return x;
        }

        public static void Task14() 
        {
            Random random = new Random();

            // Ввод длины последовательности
            Console.Write("Введите длину последовательности (не меньше 3): ");
            int length = int.Parse(Console.ReadLine());

            if (length < 3)
            {
                Console.WriteLine("Длина последовательности должна быть не менее 3");
                return;
            }

            // четное: 4, 6, 14, ...
            // 0 ... 1 1 ... 2          // две единицы. Половина оставшегося места - нули, половина - двойки

            // неч: 5, 7, 13, 21
            // 0 ... 1 ... 2            // одна единица. Половина оставшегося места - нули, половина - двойки

            int oneCount = length % 2 == 0 ? 2 : 1;
            int zeroCount = (length - oneCount) / 2;
            int twoCount = zeroCount;

            int[] numbers = Enumerable.Repeat(0, zeroCount)                     // Добавляем нули
                                     .Concat(Enumerable.Repeat(2, twoCount))    // Добавляем двойки
                                     .Concat(Enumerable.Repeat(1, oneCount))    // Добавляем единицы
                                     .ToArray();

            Array.Sort(numbers);

            foreach (var num in numbers)
            {
                Console.Write($"{num} ");
            }
        }
    }
}

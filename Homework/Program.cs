namespace Homework;
class Program
{
    static void Main(string[] args)
    {
        void Task_41()
        {
            /* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
                    0, 7, 8, -2, -2 -> 2
                    1, -7, 567, 89, 223-> 3 */
            Console.WriteLine("                --Задача 41--");
            Console.WriteLine(" Для решения задачи 41, необходимо ввести числа!");
            Console.WriteLine("    Вы хотите ввести числа через клавиатуру?");
            Console.Write("     Нажмите 'Y' - это ДА, 'N' - это нет -> ");
            string enteringNumber = Console.ReadLine();           
            if (enteringNumber.ToLower() == "y") Task_41_1();
            else if (enteringNumber.ToLower() == "n") Task_41_2();
            else Console.WriteLine(" Ввод неверный! ");
        }

        void Task_41_1() // вариант I, с вводом числа с клавиатуры через пробел
        {
            /* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
                    0, 7, 8, -2, -2 -> 2
                    1, -7, 567, 89, 223-> 3 */
            Console.WriteLine();
            Console.Write("Введите число, обязательно каждое число вводите через пробел:_");
            string container = Console.ReadLine();
            string[] numberS = container.Split();
            int size = numberS.Length;
            int[] num = new int[size];
            ConvertArrayToInt(numberS, num);
            int temp = 0;
            for (int i = 0; i < size; i++)
            {
                if (num[i] > 0) temp++;
            }
            Console.Write(" Введены числа: ");
            PrintArray(num);
            Console.Write($" -> {temp}");
            Console.WriteLine();

        }

        void Task_41_2() // вариант II, числа вводит компьютер
        {
            /* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
                    0, 7, 8, -2, -2 -> 2
                    1, -7, 567, 89, 223-> 3 */
            Console.WriteLine();
            Console.Write(" Введены числа: ");
            Random rand = new Random();
            int size = rand.Next(3, 20);
            int[] num = new int[size];
            FillArray(num, -10, 20);

            int temp = 0;
            for (int i = 0; i < size; i++)
            {
                if (num[i] > 0) temp++;
            }
            PrintArray(num);
            Console.Write($" -> {temp}");
            Console.WriteLine();
        }

        void Task_43()
        {
            /* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
            заданных уравнениями 
            y = k1 * x + b1, y = k2 * x + b2; 
            значения b1, k1, b2 и k2 задаются пользователем.
            b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

            Console.WriteLine();
            Console.WriteLine("                --Задача 43--");
            Console.Write("Введите координаты b1, K1 точки А через пробел :-> ");
            string point_A = Console.ReadLine();

            Console.Write("Введите координаты b2, k2 точки B через пробел :-> ");
            string point_B = Console.ReadLine();
            string[] pointSplit_A = point_A.Split();
            string[] pointSplit_B = point_B.Split();

            double b1 = Convert.ToDouble(pointSplit_A[0]);
            double k1 = Convert.ToDouble(pointSplit_A[1]);
            double b2 = Convert.ToDouble(pointSplit_B[0]);
            double k2 = Convert.ToDouble(pointSplit_B[1]);

            Console.Write($" A ({b1}, {k1}); ");
            Console.WriteLine($" B ({b2}, {k2}); ");
            // x = b2-b1 / k1-k2
            double x = Math.Round((b2 - b1) / (k1 - k2), 1);
            //y = k1 * x + b1, y = k2 * x + b2; 
            double equation1 = Math.Round(k1 * x + b1, 1);
            double equation2 = Math.Round(k1 * x + b1, 1);
            Console.WriteLine(" x = " + x);
            Console.WriteLine(" y = k1 * x + b1, y = " + equation1, 2);
            Console.WriteLine(" y = k2 * x + b2, y =  " + equation2, 2);

            if (equation1 == equation2) Console.WriteLine($"Tочка пересечения двух прямых - C ({x}, {equation1})");
            else Console.WriteLine($"Прямые не пересекаются в точке - C ({x}, {equation1}))");


        }

        void PrintArray(int[] nums)//печать массива
        {
            int length = nums.Length;
            Console.Write("[ ");
            for (int i = 0; i < length; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.Write("]");

        }

        void ConvertArrayToInt(string[] numString, int[] numInt)
        {
            for (int i = 0; i < numString.Length; i++)
            {
                numInt[i] = Convert.ToInt32(numString[i]);
            }
        }

        void FillArray(int[] numbers, int minValue = 0, int maxValue = 9) //метод заполнения массива случайными числами
        {
            maxValue++;
            Random rand = new Random();
            int length = numbers.Length;
            for (int i = 0; i < length; i++)
            {
                numbers[i] = rand.Next(minValue, maxValue);
            }
        }

        //Task_41();
        //Task_43();

    }
}

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool circleNext = true;
            while (circleNext)
            {
                string enter;
                Console.WriteLine("'1' - Сложение\n'2' - Вычитание\n'3' - Умножение\n'4' - Деление\n'5' - Возвести в степень\n'6' - Найти 1%\n'7' - Найти квадратный корень\n'8' - Найти факториал\n'9' - Выход из программы");
                enter = Console.ReadLine();
                if (enter == "9") { circleNext = false; }
                if (enter == "1") 
                {
                    Console.Write("Введите 1 число:");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите 2 число:");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Сумма: " + (a+b));
                }
                if (enter == "2")
                {
                    Console.Write("Введите 1 число:");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите 2 число:");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Разность: " + (a-b));
                }
                if (enter == "3")
                {
                    Console.Write("Введите 1 число:");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите 2 число:");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Результат: " + (a * b));
                }
                if (enter == "4")
                {
                    Console.Write("Введите 1 число:");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите 2 число:");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Результат: " + (a / b));
                }
                if (enter == "5")
                {
                    Console.Write("Введите 1 число:");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите 2 число:");
                    int b = Convert.ToInt32(Console.ReadLine());
                    int c = a;
                    for (int i = 1; i < b; i++) { c = c * a; }
                    Console.WriteLine("Результат: " + c);
                }
                if (enter == "6")
                {
                    Console.Write("Введите число:");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Результат: " + (a / 100));
                }
                if (enter == "7")
                {
                    Console.WriteLine("Введите число:");
                    int a = Convert.ToInt32(Console.ReadLine());
                    int b = 1;
                    for (int i = 1; i < a; i = i + 2)
                    {
                        a = a - i;
                        b++;
                    }
                    Console.WriteLine("Результат: " + b);
                }
                if (enter == "8")
                {
                    Console.Write("Введите число:");
                    int a = Convert.ToInt32(Console.ReadLine());
                    int b = 1;
                    for (int i = 1; i <= a; i++) 
                    {
                        b = b * i;
                    }
                    Console.WriteLine("Факториал: " + b);
                }
            }
        }
    }
}
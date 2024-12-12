using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = 10; // Приклад значення n
        var sum = Enumerable.Range(2, n - 1)  // Генеруємо числа від 2 до n
                            .Where(x => x % 2 == 0)  // Фільтруємо парні числа
                            .Sum();  // Обчислюємо суму парних чисел

        Console.WriteLine("Сума парних чисел від 2 до " + n + " = " + sum);
    }
}

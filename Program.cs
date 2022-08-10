// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь

void Zadacha41()
    {
    Console.Write("Сколько чисел будете вводить? ");
    int M = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[M];
    FillAndSortArray(array);
    }

    void FillAndSortArray(int[] array, int temp = 0)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Введите число: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
                if (array[i] > 0) temp++;
            }
        Console.WriteLine("Количество числе больше нуля, введенных пользователем: " + temp);
        }


// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

void Zadacha43()
    {
    Console.Write("Укажите переменную b первой прямой: ");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Укажите переменную b второй прямой: ");
    double b2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Укажите угловой коэффициент первой прямой: ");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Укажите угловой коэффициент второй прямой: ");
    double k2 = Convert.ToDouble(Console.ReadLine());
    double x = 0;
    double y = 0;

    if (k1 == k2)
        {
            Console.WriteLine("Прямые параллельны");
        }
    else
        {
        x = (b2-b1)/(k1-k2);
        y = (k1*x) + b1;
        }

    Console.WriteLine("Точка пересечения прямых: " +Math.Round(x, 2) + "; " + Math.Round(y, 2) );
    }
//Zadacha41();
Zadacha43();
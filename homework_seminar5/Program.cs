using System;
using System.Linq;
using System.Text;

Console.Clear();

/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

// // Создаем массив 
// int[] RandomMassive(int size)
// {
//     int[] result = new int [size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(100, 1000);

//     }
//     return result;
// }

// // Выводим массив на экран
// Console.WriteLine("Задайте размер массива, введите количество элементов: "); 
// int[] Mass = RandomMassive(int.Parse(Console.ReadLine()));
// Console.WriteLine($"[{String.Join(", ",Mass)}]");
// Console.WriteLine("-------------------------");

// // Создаем функцию подсчета суммы четных чисел массива
// int EvenNum (int[] array)
// {
//     int result = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0) result++;
//     }
//     return result;
// }

// // Выводим результат программы
// Console.WriteLine($"Количество четных чисел в массиве: {EvenNum(Mass)}");


/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

// // Создам массив случайных чисел
// int[] RandomMassive(int size, int min, int max)
// {
//     int[] result = new int [size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(min, max + 1);

//     }
//     return result;
// }

// // Выводим массив на экран
// Console.WriteLine("Задайте размер массива: "); 
// int size = int.Parse(Console.ReadLine());
// Console.WriteLine("Укажите минимальное значение массива: "); 
// int min = int.Parse(Console.ReadLine());
// Console.WriteLine("Укажите максимальное значение массива: ");
// int max = int.Parse(Console.ReadLine()); 
// int[] Mass = RandomMassive(size,min,max);
// Console.WriteLine($"[{String.Join(", ",Mass)}]");
// Console.WriteLine("-------------------------");

// // Создаем функцию поиска суммы элементов, стоящих на нечетных позициях

// int Summ (int[]array)
// {
//     int result = 0;
//     for (int i = 1; i < array.Length; i+=2)
//     {
//         result+=array[i];
//     }

//     return result;
// }

// // Выводим результат программы
// Console.WriteLine($"Сумма нечетных элементов массива равна {Summ(Mass)}");

/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

// Создам массив случайных вещественных чисел
double[] RandomMassive(int size)
{
    double[] result = new double [size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().NextDouble();
        result[i] = Math.Round(result[i],2);

    }
    return result;
}

// Выводим массив на экран

Console.WriteLine("Введите размер массива: ");
double[] Mass = RandomMassive(int.Parse(Console.ReadLine()));
Console.WriteLine($"[{String.Join(" ",Mass)}]");

// Создаем функцию расчета разницы между макс и мин значениями массива 

double Diff (double[]array)
{
    double result = 0;
    double min = array[0];
    double max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] <= min) min = array[i]; 
    }
    result = max - min;

    return result;
}

// Вывод результата на экран

Console.WriteLine($"Разница между максимальным и минимальным значением массива составляет {Diff(Mass)}");

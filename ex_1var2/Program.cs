// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
Console.WriteLine("Введите числа: ");
int [] num = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int Method1(int[] col)
{
    int count = 0;
    for (int i = 0; i < col.Length; i++)
    {
        if (num[i] > 0);
        {
            count++;
        }
    }
    return count;
}
int rez = Method1(num);
Console.WriteLine($"количество положительных чисел = {rez}");

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числа: ");
int[] num = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
//int rez = 0; // можно сразу через foreach
//foreach (int el in num)
//{
//  if (el > 0)
//{
//  rez = rez + 1;
//}
//}
//Console.WriteLine($"количество положительных числе = {rez}");

void PrintArray(int[] collection)
{
   for (int i = 0; i < collection.Length; i++)
{
   Console.Write($"{(i == 0 ? collection[i] : " " + collection[i])}");
}
Console.WriteLine();
}
PrintArray(num);

int PositiveNum(int[] col)
{ 
   int count = 0;
   for (int i = 0; i < col.Length; i++)
   {
    if (col[i] > 0)
   {
       count++;
   }
   }
    return count;
}
Console.WriteLine($"количество положительных чисел = {PositiveNum(num)}");

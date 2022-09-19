// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
Console.WriteLine("Введите количество чисел: ");
int elementsCount = int.Parse(Console.ReadLine());
int [] array = new int [elementsCount];
void FillArray(int[] collection)
{  
  for (int i = 0; i < collection.Length; i++)
{    
    Console.WriteLine($"Введите число {i}: ");
    collection[i] = int.Parse(Console.ReadLine());
}
}
void PrintArray(int[] col)
{
    for (int i = 0; i < col.Length; i++)
{
   Console.Write($"{(i == 0 ? col[i] : "," + col[i])}");
}
Console.WriteLine();
}
FillArray(array);
PrintArray(array);
int rez = 0;
foreach (int el in array)
{
  if (el > 0)
{
 int count = 0;
 rez = rez + 1;
}
}
Console.WriteLine($"количество положительных числе = {rez}");

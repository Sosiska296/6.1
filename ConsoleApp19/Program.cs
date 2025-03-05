Console.WriteLine("Введите размер массива:");
int a = int.Parse(Console.ReadLine());
int[] array = new int[a];
for (int i = 0; i < a; i++)
{
    Console.WriteLine($"Введите злемент {i + 1}:");
    array[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Содержимое массива:");
foreach (int элемент in array)
{
    Console.WriteLine(элемент);
}
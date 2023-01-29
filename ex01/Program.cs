// Дан список некоторых целых чисел, найдите значение 20 в нем и, если оно присутствует, замените его на 200. Обновите список только при первом
// вхождении числа 20
Console.Write("Введите количество элементов массива: ");
int N = int.Parse(Console.ReadLine());
int[] array = new int[N];

for (int i = 0; i < N; i++)
{
    array[i] = new Random().Next(15,26);
}

void PrintArray(int[] arg)
{
    int count = arg.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{arg[i]} ");
    }
    Console.WriteLine();
}
PrintArray(array);
for (int i = 0; i < N; i++)
{
    if (array[i] == 20) 
    {
        array[i] = 200;
        break;
    }
}
PrintArray(array);
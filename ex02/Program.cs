// Кегли
//N кеглей выставили в один ряд, занумеровав их слева направо числами от 1 до N. Затем по этому ряду бросили K шаров,
// при этом i-й шар сбил все кегли с номерами от li до ri включительно. Определите, какие кегли остались стоять на месте
// Программа получает на вход количество кеглей N и количество бросков K. Далее идет K пар чисел li, ri, при
// этом 1≤ li≤ ri≤ N.
//Программа должна вывести последовательность из N символов, где j-й символ есть “I”, если j-я кегля осталась стоять,
// или “.”, если j-я кегля была сбита.
Console.Write("Введите количество Кеглей: ");
int N = int.Parse(Console.ReadLine());
string[] array = new string[N];

Console.Write("Введите количество Бросков шара: ");
int K = int.Parse(Console.ReadLine());              //это колиество бросков шара

int Cagle_num = 0;                                  //переменная для сравнения
for (Cagle_num = 1; Cagle_num <= N; Cagle_num++)     //это ряд кеглей
{
    array[Cagle_num] = "I";
}

void PrintArray(string[] arg)
{
    int count = arg.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write(arg[i] + " ");
    }
    Console.WriteLine();
}
PrintArray(array);

string Ball_num = "Ball";

for (int i = 1; i <= K; i++)
{
    Ball_num = "Ball" + i;
    Console.Write(Ball_num + " ");          //показать номера шаров
}

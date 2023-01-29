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
for (Cagle_num = 0; Cagle_num < N; Cagle_num++)     //это ряд кеглей, наполняем его
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
Console.Write("Это ряд кеглей до прилета шаров: ");
PrintArray(array);

for (int i = 1; i <= K; i++)                //этот цикл "запускает шары"
{
    int Li = new Random().Next(1, N+1);
    int Ri = new Random().Next(1, N+1);
    if (Li > Ri) (Li, Ri) = (Ri, Li);       //т.к. в условии сказано что Li меньше Ri то проверем и меняем их местами, если надо
    Console.Write("Попадания шара " + i + ": ");
    for (int j = Li; j <= Ri; j++)          //показываем все значения сбитых кеглей этого шара
    {
        Console.Write($"{j} ");
        for (Cagle_num = 1; Cagle_num < N; Cagle_num++)
        {
            if (Cagle_num == j) array[Cagle_num - 1] = "."; //если шар попал, то "роняем" Кеглю
        }
    }
    Console.WriteLine();
}
Console.Write("А это ряд кеглей после прилета шаров: ");
PrintArray(array);
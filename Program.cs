// В прямоугольной матрице найти строку с наименьшей суммой элементов.

Console.Clear();

Console.Write("Введите количество строк массива: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int y = int.Parse(Console.ReadLine());

Random rnd = new Random();
int[,] array = new int[x, y];

for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        array[i, j] = rnd.Next(1, 10);
    }
}

void printmass(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

printmass(array);

int[] minres = new int[array.GetLength(0)];

void minsumm(int[,] minimum, int[] result)
{
    int min = 0;
    for (int i = 0; i < minimum.GetLength(0); i++)
    {
        for (int j = 0; j < minimum.GetLength(1); j++)
        {
            min = min + minimum[i, j];
        }
        result[i] = min;
        min = 0;
    }
}
Console.WriteLine();
minsumm(array, minres);

int index = 0;

for (int i = 0; i < minres.Length; i++)
{
    if (minres[i] < minres[index])
    {
        index = i;
    }    
}

Console.Write($"Строка с наименьшей суммой: {index + 1}");
Console.WriteLine("Запишите количество строк в матрице");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Запишите количество  столбцов в матрице");
int m = Convert.ToInt32(Console.ReadLine());

int i = 0, j, min;
int x =n*m;
int[] matr = new int[x];
x = 0;
Console.WriteLine( "Запишите значения матрицы(отделяя каждое значение клавишой enter)." );
int [,] mass = new int[n, m];
for (; i < n; i++)
{
    for (j = 0; j < m; j++) mass[i,j]= Convert.ToInt32(Console.ReadLine());  
}

i = 0;

do
{
    for (j = 0; j < m; j++)
    {
        matr[x] = mass[i, j];
        Console.WriteLine($"Значение переменной под индексом {x} = {matr[x]}");
        x++;
    }
    i++;
} while (i < n);

i = n*m;
x = 0;
min = matr[x];


for (; x < i; x++)
{
    if (matr[x] < min)
        min = matr[x];
    Console.WriteLine($"{matr[x]}");
}
Console.WriteLine($"Минимальное значение массива {min}");
Console.ReadKey();
//for (i = 0; i < n; i++)
//{
//    for (j = 0; j < m; j++)
//    { 
//    matr[x] = mass[n, m];
//        Console.WriteLine($"{matr[x]}");
//        x++;
//    }
//}

using Lesson4Mass;

MatrixMath matrixMath = new MatrixMath();
Console.WriteLine("Введите размерность массива");
Console.Write("X = ");
int str = int.Parse(Console.ReadLine());
Console.Write("Y = ");
int stolb = int.Parse(Console.ReadLine());

int[,] matrix = new int[str, stolb];

for (int i = 0; i < str; i++)
    for (int j = 0; j < stolb; j++)
    {
        Console.WriteLine("X: "+i+" Y: "+ j);
        matrix[i, j] = int.Parse(Console.ReadLine());
    }

matrixMath.MatrixOut(matrix, str, stolb);

Console.WriteLine("Меню действий");
Console.WriteLine("Нажать '1' Найти количество положительных/отрицательных чисел в матрице");
Console.WriteLine("Нажать '2' Сортировка элементов матрицы построчно");
Console.WriteLine("Нажать '3' Инверсия элементов матрицы построчно");
Console.Write("Ввыедите действие:");
int menu = int.Parse(Console.ReadLine());

if (menu == 1)
{
    matrixMath.MatrixPosNeg(matrix, str, stolb);
}
else if (menu == 2)
{
    matrixMath.MathSort(matrix, str, stolb);
}
else if (menu == 3)
{
    matrixMath.InversMatrix(matrix, str, stolb);
}


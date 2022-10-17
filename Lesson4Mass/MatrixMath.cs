using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4Mass
{
    internal class MatrixMath
    {
        public void MatrixOut(int[,] mat, int str, int stolb)
        {
            Console.WriteLine("Вывод Матрицы:");
            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < stolb; j++)
                Console.Write(String.Format("{0,4}", mat[i, j]));
                Console.WriteLine();
            }
            
        }
        public void MatrixPosNeg(int[,] mat, int str, int stolb)
        {
            int positive = 0;
            int negative = 0;
            for (int i = 0; i < str; i++)
                for (int j = 0; j < stolb; j++)
                    if (mat[i, j] > 0)
                        positive++;
            Console.WriteLine($"Количество положительных элементов: {positive}");
            for (int i = 0; i < str; i++)
                for (int j = 0; j < stolb; j++)
                    if (mat[i, j] < 0)
                        negative++;
            Console.WriteLine($"Количество отрицательных элементов: {negative}");
        }
        public void MathSort(int[,] mat, int str, int stolb)
        {
            Console.Write("Сортировка строк матрицы: если '+' - по возрастанию; '-' - по убыванию: ");
            char sort = char.Parse(Console.ReadLine());
            for (int c = 0; c < str; c++)
            {
                for (int j = 0; j < stolb; j++)
                {
                    for (int i = 0; i < stolb - 1; i++)
                    {
                        if (sort == '+')
                            if (mat[c, i] < mat[c, i + 1])//по-убыванию
                            {
                                int tmp = mat[c, i];
                                mat[c, i] = mat[c, i + 1];
                                mat[c, i + 1] = tmp;
                            }
                            else if (sort == '-')
                                if (mat[c, i] > mat[c, i + 1])//по-возрастанию
                                {
                                    int tmp = mat[c, i];
                                    mat[c, i] = mat[c, i + 1];
                                    mat[c, i + 1] = tmp;
                                }
                    }
                }
            }
            // вывод матрицы

            Console.WriteLine("Сортировка матрицы:");
            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < stolb; j++)
                    Console.Write(String.Format("{0,4}", mat[i, j]));
                Console.WriteLine();
            }
        }
        public void InversMatrix(int[,] mat, int str, int stolb)
        {
            Console.WriteLine("Инверсия построчно:");
            for (int i = 0; i < mat.GetLength(1) / 2; i++)
                for (int j = 0; j < mat.GetLength(0); j++)
                {
                    int temp = mat[j, i];
                    mat[j, i] = mat[j, mat.GetLength(1) - i - 1];
                    mat[j, mat.GetLength(1) - i - 1] = temp;
                }
            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < stolb; j++)
                    Console.Write(String.Format("{0,4}", mat[i, j]));
                Console.WriteLine();
            }
        }

    }
}

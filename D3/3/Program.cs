using System;

class Matrix
{
    private int[,] matrix;

    // Конструктор для создания матрицы заданного размера
    public Matrix(int rows, int cols)
    {
        matrix = new int[rows, cols];
    }

    // Конструктор для создания матрицы из двумерного массива
    public Matrix(int[,] array)
    {
        matrix = (int[,])array.Clone();
    }

    // Индексатор для доступа к элементам матрицы
    public int this[int row, int col]
    {
        get { return matrix[row, col]; }
        set { matrix[row, col] = value; }
    }

    // Перегрузка оператора > для сравнения сумм элементов главной диагонали
    public static bool operator >(Matrix a, Matrix b)
    {
        int sumA = 0;
        int sumB = 0;

        for (int i = 0; i < a.matrix.GetLength(0); i++)
        {
            sumA += a[i, i];
        }

        for (int i = 0; i < b.matrix.GetLength(0); i++)
        {
            sumB += b[i, i];
        }

        return sumA > sumB;
    }

    // Перегрузка оператора < для сравнения сумм элементов главной диагонали
    public static bool operator <(Matrix a, Matrix b)
    {
        int sumA = 0, sumB = 0;

        for (int i = 0; i < a.matrix.GetLength(0); i++)
        {
            sumA += a[i, i];
        }

        for (int i = 0; i < b.matrix.GetLength(0); i++)
        {
            sumB += b[i, i];
        }

        return sumA < sumB;
    }
    public void PrintMatrix()
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine(); // вывод перевода строки
        }
    }
}

class a3
{
    static void Main()
    {
        Matrix a = new Matrix(2, 2);
        a[0, 0] = 1;
        a[0, 1] = 2;
        a[1, 0] = 3;
        a[1, 1] = 4;

        Matrix b = new Matrix(new int[,] { { 5, 6 }, { 7, 8 } });

        Console.WriteLine("Матрица a:");
        a.PrintMatrix();

        Console.WriteLine("Матрица b:");
        b.PrintMatrix();

        if (a > b)
        {
            Console.WriteLine("Сумма элементов главной диагонали в матрице a больше, чем в матрице b");
        }
        else if (a < b)
        {
            Console.WriteLine("Сумма элементов главной диагонали в матрице a меньше, чем в матрице b");
        }
        else
        {
            Console.WriteLine("Сумма элементов главной диагонали в  a равна b матрице");
        }
    }
}
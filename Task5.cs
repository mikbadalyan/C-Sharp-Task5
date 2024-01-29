//Our matrix
int rows = 4;
int columns = 4;


int[,] Matrix =
{
    { 1, 2, 3, 4 },
    { 5, 6, 7, 8 },
    { 9, 10, 11, 12 },
    { 13, 14, 15, 16 }
};
//

//Matrix visualization
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write(Matrix[i, j] + " ");
    }
    Console.WriteLine();
}
//

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();


int finding_saddle_point(int rows, int columns, int[,] Matrix)
{
    int max = -1;
    int[] max_nums = new int[rows];
    int index_i;
    for (int i = 0; i < rows; i++)
    {
        max = Matrix[i, 0];
        index_i = 0;
        for (int j = 0; j < columns; j++)
        {
            if (Matrix[i, j] > max)
            {
                max = Matrix[i, j];
                index_i = j;
            }
        }

        max_nums[i] = index_i;
    }

    int min;
    int result = -1;
    for (int i = 0; i < rows; i++)
    {
        min = Matrix[i, max_nums[i]];
        for (int j = 0; j < rows; j++)
        {
            if (Matrix[j, max_nums[i]] <= min && Matrix[j, max_nums[i]] != Matrix[i, max_nums[i]])
            {
                result = -1;
                break;
            }
            else
            {
                result = min;
            }
        }

        if (result == min)
        {
            break;
        }
    
    }

    return result;
}

int res = finding_saddle_point(rows, columns, Matrix);

if (res == -1)
{
    Console.WriteLine("No");
}
else
{
    Console.WriteLine(res);
}








public static class SpiralMatrix
{
    private static readonly (int, int)[] directions =
    {
        (0, 1),
        (1, 0),
        (0, -1),
        (-1, 0),
    };

    public static int[,] GetMatrix(int size)
    {
        int[,] matrix = new int[size, size];
        (int, int) current = (0, 0);
        int currentDirectionIndex = 0;
        int matrixSize = size * size;
        for (var i = 1; i <= matrixSize; i++)
        {
            matrix[current.Item1, current.Item2] = i;
            (int, int) nextPosition = current.Add(directions[currentDirectionIndex]);
            if (!nextPosition.IsValid(size) 
                || matrix[nextPosition.Item1, nextPosition.Item2] != 0)
            {
                nextPosition = nextPosition.Add(directions[currentDirectionIndex].Negative());
                currentDirectionIndex = (currentDirectionIndex + 1) % directions.Length;
                nextPosition = nextPosition.Add(directions[currentDirectionIndex]);
            }
            current = nextPosition;
        }
        return matrix;
    }

    private static (int, int) Negative(this (int, int) value)
        => (-value.Item1, -value.Item2);
    

    private static (int, int) Add(this (int, int) a, (int, int) b)
        => (a.Item1 + b.Item1, a.Item2 + b.Item2);
    

    private static bool IsValid(this (int, int) value, int size)
        => value.Item1 < size 
            && value.Item2 < size 
            && value.Item1 >= 0 
            && value.Item2 >= 0;
}

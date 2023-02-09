int[,,] Create3DArrayRndInt(int x, int y, int z, int min, int max)
{
    int[,,] matr = new int[x, y, z];
    Random rnd = new Random();

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                int next = 0;
                while (true)
                {
                    next = rnd.Next(min, max);
                    if (!Contains(matr, next)) break;
                }

                matr[i, j, k] = next;
            }
        }
    }
    return matr;
}

bool Contains(int[,,] matr, int value)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                if (matr[i, j, k] == value) return true;
            }
        }
    }
    return false;
}

void Print3DArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.WriteLine($"{matr[i, j, k]} ({i}, {j}, {k})");
            }
        }
    }
}

int[,,] threeDArray = Create3DArrayRndInt(2, 2, 2, 0, 30);
Print3DArray(threeDArray);
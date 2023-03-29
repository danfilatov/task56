int[,] array = new int[4, 4];
FillArrayRandom(array);
PrintArray(array);

int minSum = 0;
int sumAll = SumElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tmpSum = SumElements(array, i);
  if (sumAll > tmpSum)
  {
    sumAll = tmpSum;
    minSum = i;
  }
}

Console.WriteLine($"\n{minSum+1} - строкa с наименьшей суммой. Сумма элементов строки: {sumAll}");


int SumElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}
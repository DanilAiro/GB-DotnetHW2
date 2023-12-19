/*
  Дан двумерный массив.
  732
  496
  185

  Отсортировать данные в нем по возрастанию.
 */

int[,] array = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };
PrintTwoDimArray(array);
Console.WriteLine();
SortTwoDimArray(array);
PrintTwoDimArray(array);

void SortTwoDimArray(int[,] arr)
{
  int[] temp = FillArrayFromTwoDimArray(arr);
  Array.Sort(temp);
  int k = 0;

  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      arr[i, j] = temp[k++];
    }
  }
}

int[] FillArrayFromTwoDimArray(int[,] arr)
{
  int[] temp = new int[arr.GetLength(0) * arr.GetLength(1)];
  int k = 0;

  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      temp[k++] = arr[i, j];
    }
  }

  return temp;
}

void PrintTwoDimArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
  }
}
int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)            //-1 potomusto ˇ
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)      //^zdesi+1
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}


PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);


//adapt code na zmenu v obracenem poradi
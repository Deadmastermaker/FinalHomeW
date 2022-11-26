string[,] CreateArray()
{
    Console.WriteLine("Строки: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Столбцы: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Элемент массива: ");
    string user = String.Empty;

    string[,] array = new string[rows,columns];

    for (int i = 0;i < rows;i++)
    {
        for(int j = 0;j < columns;j++)
        {
            Console.WriteLine("Элемент: ");
            user = Console.ReadLine();
            array[i,j] = user;
        }
    }
    return array;
}


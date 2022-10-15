string[] elementary = new string[6] {"Moscow", "123", "geek", "A4", "o", "hashtag"};
string[] finite = new string[elementary.Length];

Console.WriteLine("Начальный массив");
PrintArray(elementary);
Createfinite(elementary, finite);
Console.WriteLine();
Console.WriteLine("Массив с элементами не длиннее трех символов");
PrintArray(finite);

void Createfinite(string[] array, string[] array1)
{
    int n = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array1[n] = array[i];
            n++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}
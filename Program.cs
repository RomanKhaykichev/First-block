Console.Clear();


int Print(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

string PrintString(string message)
{
    Console.Write(message);
    return Convert.ToString(Console.ReadLine());
}

string[] FillArray(int lenght)
{
    string[] array = new string[lenght];
    for (int i = 0; i < lenght; i++)
    {
        array[i] = PrintString($"Введите строку массива {i+1}: ");
    }
    return array;
}

void PrintArray(string[] array)
{
    Console.Write($"Mas -> [{String.Join(", ", array)}]");
}



int lenght = Print("Введите длину массива: ");
string[] getArray = FillArray(lenght);
PrintArray(getArray);

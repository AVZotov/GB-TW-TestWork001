string[] GetArray()
{
    string[] userArray = new string[GetUint()];

    for (int i = 0; i < userArray.Length; i++)
    {
        Console.Write($"Enter {i + 1} string: ");
        userArray[i] = Console.ReadLine();
    }

    return userArray;
}

uint GetUint()
{
    uint userInput = 0;
    Console.Write("Enter number of strings: ");

    while ((uint.TryParse(Console.ReadLine(), out userInput)) == false)
        Console.Write("Error!, Enter positive number: ");

    return userInput;
}

void PrintArray(string[] array)
{
    foreach (var str in array)
    {
        Console.Write(str + " ");
    }
}

string[] GetResultArray(string[] array)
{
    string separator = "separator";
    string result = String.Empty;

    foreach (var str in array)
    {
        if (str.Length <= 3)
        {
            result = result + str + separator;
        }
    }

    return result.Split(separator);
}

string[] userArray = GetArray();
string[] resultArray = GetResultArray(userArray);
PrintArray(resultArray);
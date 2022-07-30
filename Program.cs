// Написать программу, которая из имеющегося массива формирует массив из строк, 
// длина которых меньше либо равна 3. Первоначальный массив задается на старте алгоритма

string[] MainTask(string[] inputArray)
{
    int CountCorrectElements(string[] arr)
    {
        int result = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length <= 3) result++;
        }
        return result;
    }


    int count = CountCorrectElements(inputArray);
    string[] newArray = new string[count];
    int index = 0;

    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            newArray[index] = inputArray[i];
            index++;
        }
    }
    return newArray;
}

string Print(string[] inputArray)
{
    string result = "";

    foreach (string el in inputArray)
    {
        result = result + el + ", ";
    }
    return result;
}


string[] startArray = { "start", "hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "end" };
System.Console.WriteLine($"Star Array \n{Print(startArray)}");
System.Console.WriteLine();

string[] finishArray = MainTask(startArray);
System.Console.WriteLine($"Finish Array \n{Print(finishArray)}");
System.Console.WriteLine();

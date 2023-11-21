// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

string[] CreateArray(string[] array)
{
    string[] newArray = new string [array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[i] = array[i];   
        }
    }
    return newArray;

}

string[] arr = { "1234", "1567", "-2", "computer science" };

string[] newArr = CreateArray(arr);
Console.WriteLine(string.Join(" ", newArr));




//  Написать программу, которая из имеющегося массива строк формирует 
// массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма.

// ["hello", "2", "world", "-)"] -> ["2", "-)"]

string[] inputArr = {"hello", "2", "world", "-)"};

void FindTreeLen(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length < 3)
        {
            System.Console.WriteLine(arr[i]);
        }
    }
}

FindTreeLen(inputArr);

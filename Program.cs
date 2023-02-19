// Итоговый проект
// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучшеstring[] array1 = new string[5] {"123", "23", "hello", "world", "res"};


string[] array1 = new string[4] { "hello", "22", "world", ":)" };
string[] array2 = new string[array1.Length];
SecondArray(array1, array2);
PrintArray(array2);

void SecondArray(string[] array1, string[] array2)
{
    int newSize = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[newSize] = array1[i];
            newSize++;
        }
    }
}
void PrintArray(string[] array2)
{
    Console.Write("[");
    for (int i = 0; i < array2.Length; i++)
    {
        if (i < array2.Length) Console.Write($"{array2[i]}, "); // Не получается убратть линшние запятые...
        else Console.Write($"");
    }
    Console.Write("]");
}


string[] arrayTest = new string[] { "hello", "2", "world", ":-)" };
//string[] arrayTest = { "1234", "1567", "-2", "computer science" };
//string[] arrayTest = new string[] { "Russia", "Denmark", "Kazan" };

//вывод массива
void PrintArray(string[] arrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write($"\"{arrayToPrint[i]}\"");
        if (i < arrayToPrint.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

//вычисление размера нового массива
int СalSizeArray(string[] arrayToСalculate)
{
    int size = 0;
    for (int i = 0; i < arrayToСalculate.Length; i++)
    {
        if (arrayToСalculate[i].Length <= 3)
        {
            size++;
        }
    }
    return size;
}

//создание массива из строк, длина которых меньше либо равна 3 символам
string[] CreatedArrayThreeCharacters(string[] initialArray, int sizeNewArray)
{
    string[] newArray = new string[sizeNewArray];
    int indexNewArray = 0;
    for (int i = 0; i < initialArray.Length; i++)
    {
        if (initialArray[i].Length <= 3)
        {
            newArray[indexNewArray] = initialArray[i];
            indexNewArray++;
        }
    }
    return newArray;
}

PrintArray(arrayTest);

int sizeNewArray = СalSizeArray(arrayTest);
string[] newArray = CreatedArrayThreeCharacters(arrayTest, sizeNewArray);

Console.Write(" массив из строк, длина которых меньше либо равна 3 символам -> ");
PrintArray(newArray);
Console.WriteLine();

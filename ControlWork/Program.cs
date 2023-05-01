/*
Итоговая контрольная работа по основному блоку

Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

Console.WriteLine("Введите размерность массива");
int size = IsParsedInt();

string[] array =  GenerateArray(size);
Console.WriteLine("Первоначальный массив:");
PrintArray(array);
Console.WriteLine();

int sizeResult = FindCountElementToArray(array);

string[] resultArray = GenerateResultArray(sizeResult, array);
Console.WriteLine("Новый массив:");
PrintArray(resultArray);


// Метод создание массива типа string и заполнение пользоаателем через консоль
string[] GenerateArray(int size)
{
    string[] array = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите значение {i} элемента массива:");
        array[i] = Console.ReadLine();
    }

    return array;
}


// Рекурсивный метод проверки правильности ввода значения в консоль
int IsParsedInt()
{

    bool status = int.TryParse(Console.ReadLine(), out int a);
    if (status) { return a; }

    if (!status)
    {
        Console.WriteLine("Введено не число, повторите ввод");
    }

    return IsParsedInt();

}


// Метод поиска в массиве количества элементов значение которых меньше или равно 3 символам
int FindCountElementToArray(string[] array)
{
    int resultCount = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            resultCount++;
        }
    }

    return resultCount;
}


// Метод поиска в первоначальном массиве элементов длина которых меньше или равна 3 и копирования их в новый массив
string[] GenerateResultArray(int sizeResult, string[] array)
{
    string[] resultArray = new string [sizeResult];

    for (int i = 0; i < sizeResult; )
    {
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j].Length <= 3)
            {
                resultArray[i] = array[j];
                i++;
            }
        }
    }

    return resultArray;
}


// Метод вывода массива в консоль
void PrintArray(string[] array)
{
    Console.WriteLine($"Массив: [{string.Join(", ", array)}]"); // вывод в консоль
}
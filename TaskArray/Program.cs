//Задаём параметры массива
Console.WriteLine("Задайте число которое будет равно количеству элементов массива:");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите элементы массива по одному!");

var array = GetArray(); // функция через которую заносим элементы в массив
PrintArrayToConsole(array); // функция которая показывает исходный массив


string[] GetArray()
{
    var array = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите элемент {0}", i + 1);
        array[i] = String.Format(Console.ReadLine());
    }

    return array;
}

void PrintArrayToConsole(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        // Console.WriteLine(array[i]);        
    }
    Console.WriteLine($"Ваш массив [{string.Join(",", array)}] ");
}



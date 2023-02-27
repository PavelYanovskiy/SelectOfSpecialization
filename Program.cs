// Написать программу, которая из имеющегося массива строк формирут массив из строк,
// длинна которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется 
// пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] arr = new string[] { "hello", "2", "world", ":-)" };
string[] res = new string[arr.Length];
int j = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i].Length <= 3)
    {
        res[j] = arr[i];
        j++;
    }
}
res = res.Where(x => !string.IsNullOrEmpty(x)).ToArray();

Print1DArr(res);

void Print1DArr(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

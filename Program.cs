Console.WriteLine("Введите слова (символы, или числа) через запятую: ");
string[] intArray = Console.ReadLine().Split(',');

string[] filteredArray = new string[intArray.Length];
int count = 0;
for (int i = 0; i < intArray.Length; i++)
{
    if (intArray[i].Length <= 3)
    {
        filteredArray[count] = intArray[i];
        count++;
    }
}
Array.Resize(ref filteredArray, count);
Console.WriteLine("Слова (символы, или числа) имеющие 3 или меньше значение: ");
Console.WriteLine(string.Join(", ", filteredArray));
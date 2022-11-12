Console.Clear();

string[] array_given = new string[5] { "yes", "world", "8793", "hi", ":-)" };
int count_elements = AmountElements(array_given);
string[] array_result = new string[count_elements];

ТhreeCharacterSelection(array_given, array_result);
PrintArray(array_result);

int AmountElements(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

void ТhreeCharacterSelection(string[] arraarray_give, string[] array_result)
{
    int count = 0;
    for (int i = 0; i < array_given.Length; i++)
    {
        if (array_given[i].Length <= 3)
        {
            array_result[count] = array_given[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    int count = array.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        Console.Write(array[i]);
        if (i == count - 1)
            Console.WriteLine("]");
        else
            Console.Write(", ");
    }
}
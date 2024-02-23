
string[] array = new string[] {"1234", "1567", "-2", "computer science"};
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length < 4)
    {
        count ++;
    }
}
string[] newArray = new string[count];
int j = 0;
for (int k = 0; k < array.Length; k++)
{
    if (array[k].Length < 4)
    {
        newArray[j] = array[k];
        j ++;
    }
}

Console.Write($"[{String.Join(", ", newArray)}]");

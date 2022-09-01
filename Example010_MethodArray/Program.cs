int[] array = {1, 12, 31, 4, 18, 152, 16, 24, 46};

int n = array.Length;
int find = 152;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
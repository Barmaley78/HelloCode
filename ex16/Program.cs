void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int pos = -1;
    while(index < count)
    {
        if(collection[index] == find)
        {
            pos = index;
            break;
        }
        index++;
    }
    return pos;
}


int[] ar = new int [10];

FillArray(ar);
PrintArray(ar);
Console.WriteLine();
int pos = IndexOf(ar, 4);
Console.WriteLine(pos);

int[] ar = { 123, 435, 678, 23, 23, 687, 13, 356 };

int n = ar.Length;
int find = 23;
int index = 0;

while(index < n)
{
    if(ar[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
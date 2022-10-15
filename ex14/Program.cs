// нахождение максимума из 9 чисел методом
int Max(int arg1, int arg2, int arg3)
{
    int res = arg1;
    if (res < arg2) res = arg2;
    if (res < arg3) res = arg3;
    return res;
}

int [] array = {11,21,31,41,15,61,17,18,19};

int max = Max(
    Max(array[0], array[1], array[2]), 
    Max(array[3], array[4], array[5]), 
    Max(array[6], array[7], array[8])
    );

Console.WriteLine(max);
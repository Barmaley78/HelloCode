int count = 0, dist = 10000, ffs = 1, sfs = 2, ds = 5, friend = 2, time = 0;
while(dist > 10)
{
    if(friend == 1)
    {
        time = dist / (ffs + ds);
        friend = 2;
    }
    else
    {
        time = dist / (sfs + ds);
        friend = 1;
    }

    dist = dist - (ffs + sfs) * time;
    count++;
}
Console.Write("Собака пробежала ");
Console.Write(count);
Console.Write(" раз");

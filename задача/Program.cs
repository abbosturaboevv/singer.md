int[] array = new int[new Random().Next(1,1000)];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-1000,1000);
}
int max = 0;
for (int i = 0; i < array.Length; i++)
{
    System.Console.WriteLine(array[i] + " ");
    if(array[i] > max)
    {
        max = array[i];
    }
}
System.Console.WriteLine("Самое большое число = " + max);
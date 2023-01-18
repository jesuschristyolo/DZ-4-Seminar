using static System.Console;

Clear();


int[] arr = GetArray();
int[] arr1 = new int [8];


FullArray(arr1);
PrintArray(arr1);



void FullArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next (0, 99);
    }
}



int [] GetArray ()
{
    int [] array = new int [8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0 , 99);
    }
    return array;
}


void PrintArray(int[] arr)
{
    

    for (int i = 0; i < arr.Length; i++)
    {
        WriteLine($"{arr[i]}");
    }
}

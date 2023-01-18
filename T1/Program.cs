using static System.Console;
Clear();

WriteLine("Input your number: ");
int.TryParse(ReadLine(), out int number);


WriteLine(Numsum(number));





int Numsum(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num /= 10;
    
    }
    return sum;
}
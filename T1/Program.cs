using static System.Console;

Clear();

WriteLine("Input your number: ");
int.TryParse(ReadLine(), out int number);

int Length1 = NumberLen(number);

int Sum1 = NumberSum(Length1, number);


WriteLine($"Сумма цифр в числе {number}, составляет : {Sum1}");


int NumberLen(int a)
{
    int count = 1;
    while (a > 0)
    {
        a /= 10;
        count++;
    }
    return count;
}


int NumberSum(int Length1, int num)
{
    int sum = 0;
    for (int i = 0; i <= num; i++)
    {
        sum += num %10;
        num /= 10;
    }
    return sum;
}
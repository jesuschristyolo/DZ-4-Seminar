using static System.Console;

Clear();

Write ("Введите число: ");
int.TryParse(ReadLine(), out int number1);

Write ("Введите степень в которую вы хотите возвести это число: ");
int.TryParse(ReadLine(), out int number2);

int Pow1 = Pow(number1, number2);



WriteLine($"Число {number1} в степени {number2} = {Pow( number1, number2)}");



int Pow(int num1, int num2)
{
    int degree = 1;
    
    for (int i = 1; i <= num2; i++)
    {
        degree *= num1;
        
    }
    return degree;
}






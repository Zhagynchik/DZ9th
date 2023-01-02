/* Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30   */


int GetNumber(string text)
{
    int result = 0;
    Console.WriteLine(text);
    while(true)
    {
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }
    return result;
}

int m = GetNumber("Введите число M:"); 
int n = GetNumber("Введите число N (больше числа M): "); 

int CalculateSumm(int m, int n)
{
	int start = m;
	int end = n;
	if(m > n)
		{
			start = n;
			end = m;
		}
		return (end + start)*(end - start + 1)/2;
}
		
Console.WriteLine(CalculateSumm(m, n));





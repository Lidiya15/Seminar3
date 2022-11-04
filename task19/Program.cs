// / ДЗ Задача 19. напишите программу которая на вход принимает пятизначное число 
// и проверяет является ли оно палиндромом. Через строку решать нельзя
// 14212--Нет
// 12821- да
// 23432 - да

int Rev(int num1)
{
    int rev = 0;
    while (num1 > 0)
    {
        rev = rev * 10;
        rev = rev + num1 % 10;
        num1 = num1 / 10;
    }
    return (rev);
}

Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

while (num < 10000 || num > 99999)
{
    Console.WriteLine("Введите пятизначное число: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    num = num2;
}
if (num == Rev(num))
{
    Console.WriteLine($"Да! число {num} палиндром");
}
else
{
    Console.WriteLine($"Нет! число {num} не палиндром");
}

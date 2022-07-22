
void Zadacha10()
{
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
    int number = 981;
    Console.WriteLine(number);
    if (number > 99 && number < 1000)
    {
        Console.WriteLine("Вторая цифра числа: " + (number / 10 % 10));
    }
    else
    {
        Console.WriteLine("Введено не трёхзначное число");
    }
}


void Zadacha13()
{
// Напишите программу, которая с помощью деления 
// выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int number = 32679;
if (number < 100)
{
    Console.WriteLine("В числе менее трёх символов");
}
else
{
    while (number > 999)
    {
    number = number / 10;   
    }
    Console.WriteLine(number%10);
}
}


void Zadacha15()
{
    //Напишите программу, которая принимает на вход цифру, обозначающую 
    //день недели, и проверяет, является ли этот день выходным.
    Console.WriteLine("Введите число дня недели:  ");
    int day = Convert.ToInt32(Console.ReadLine());
    if (day == 6 || day ==7)
    {
        Console.WriteLine("выходной день");
    }
    else if(day >= 1 && day <= 5)
    {
        Console.WriteLine("рабочий день");
    }
    else
    {
        Console.WriteLine ("некорректный ввод");
    }

}


//Zadacha10();
//Zadacha13();
Zadacha15();






















//Миронова Анастасия 22-ИСП-2/1
//6.1  Уровень высокий
//Вариант 4

int FibRec(int number)
{
    if (number == 1 || number == 2)
    {
        return 1;
    }
    return FibRec(number - 1) + FibRec(number - 2);
}

for (var i = 1; i < 35; i++)
{
    Console.Write($"{FibRec(i)} ");
}
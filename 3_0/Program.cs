

Console.Write("ввидите цифру обозначающую день недели ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber)
{
 if (dayNumber == 6 || dayNumber == 7)
 {
    Console.WriteLine("да это выходной");
 }

 else if (dayNumber < 1 || dayNumber > 7)
 {
    Console.WriteLine("ты помоему перепутал");
 }

 else Console.WriteLine("это не выходной  ");

}
CheckingTheDayOfTheWeek(dayNumber);


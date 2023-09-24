// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
void WeekDay(int num){
        if (num < 6 && num > 0)
            Console.WriteLine("It's a weekday");

        if (num < 8 && num > 5)
            Console.WriteLine("It's a weekend");
        if (num < 0 | num > 8)
            Console.WriteLine("It's not a day of the week");    
}
Console.WriteLine("Enter the serial number of the day of the week 1 to 7");
int number = Convert.ToInt32(Console.ReadLine());
WeekDay(number);
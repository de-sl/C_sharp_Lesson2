// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
void ThirdNumber(int num){
    int trnum = num%10;
    if (num<99)
        Console.WriteLine("There is no third number");
    else
        Console.WriteLine($"The third number is {trnum}");
}
Console.WriteLine("Enter your number");
int number = Convert.ToInt32(Console.ReadLine());
ThirdNumber(number);

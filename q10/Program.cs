//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
void SecondNum(int num){
    if (num >= 100 && num<1000){
        int secnum = num/10;
        int secnum2 = secnum%10;
        Console.WriteLine($"Second number {secnum2}.");
    }
    else
    {
       Console.WriteLine($"Incorrect number entered.");
    }
}
Console.WriteLine("Enter a number from 100 to 999");
int number = Convert.ToInt32(Console.ReadLine());
SecondNum(number);

// See https://aka.ms/new-console-template for more information
//task1
//Console.WriteLine("task1");

//Console.WriteLine("It's easy to win forgiveness for being wrong; ");
//Console.WriteLine("being right is what gets you into real trouble.");
//Console.WriteLine("Bjarne Stroustrup");
//Console.WriteLine("task2");
////task2
//int count = 0;
//int max = 0;
//int temp3;
//Console.WriteLine("find max");
////поиск максимума
//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine("Input value");
//    temp3 = int.Parse(Console.ReadLine());
//    if (temp3 > max)
//    {
//        max = temp3;
//    }
//    count++;
//}
//Console.WriteLine($"Its max: {max}");
////поиск минимума
//count = 0;
//int min = 0;
//for (int i = 0; i < 5; i++)
//{
//    if (i == 0)
//    {
//        Console.WriteLine("Input value");
//        min = int.Parse(Console.ReadLine());

//    }else if (int.Parse(Console.ReadLine()) < min)
//    {
//        min = int.Parse(Console.ReadLine());
//    }
//    count++;
//}
//Console.WriteLine($"Its min: {min}");
////сумма
//int sum = 0;
//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine("Input value");
//    sum += int.Parse(Console.ReadLine());
//    count++;
//}
//Console.WriteLine($"Its sum: {sum}");

//int mult = 1;
//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine("Input value");
//    mult *= int.Parse(Console.ReadLine());
//    count++;
//}
//Console.WriteLine($"Its multiple: {mult}");

////task3
//Console.WriteLine("task3");
//Console.WriteLine("Input number");

//string number = Console.ReadLine();
//string reverse = "";
//for (int i = number.Length - 1; i >= 0; i--)
//{
//    reverse += number[i];
//}
//Console.WriteLine($"Reverse num = {reverse}");

////task4
//Console.WriteLine("Введите 1-е число диапазона");
//int num1 = int.Parse(Console.ReadLine());

//Console.WriteLine("Введите 2-е число диапазона");
//int num2 = int.Parse(Console.ReadLine());


//int current = num1;
//int next = num1 + 1;


//Console.WriteLine(current);


//while (next <= num2)
//{
//    Console.WriteLine(next);


//    int tempStorage = next;
//    next += current; 
//    current = tempStorage; 
//}
////task5
//Console.WriteLine("Введите число а");
//int a = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите число b");
//int b = int.Parse(Console.ReadLine());

//for (int i = a; i <= b; i++)
//{
//    string str = "";
//    for (int j = 0; j < i; j++)
//    {
//        str += i;
//    }
//    Console.WriteLine(str);
//}

////task6
Console.WriteLine("Input length of line: ");
int len = int.Parse(Console.ReadLine());
Console.WriteLine("Input vector line: - , | ");
string sign = Console.ReadLine();
Console.WriteLine("Input symbol: ");
string symbol = Console.ReadLine();

string str = "";
if (sign == "-")
{
    for (int i = 0; i < len; i++)
    {
        str += symbol;
    }
    Console.WriteLine(str);
}
else if (sign == "|")
{
    for (int i = 0; i < len; i++)
    {
        Console.WriteLine(symbol);
    }
}

// See https://aka.ms/new-console-template for more information
Console.WriteLine("What is your name?");// output

var name = Console.ReadLine();// input

Console.WriteLine("What is your favorite color");// output

var color = Console.ReadLine();// input

Console.WriteLine("What is your favorite animal");// output

var animal = Console.ReadLine();// input

Console.WriteLine("What is your favorite band");// output

var band = Console.ReadLine();// input

Console.WriteLine($"Hello,{name} your favorit color is {color} what is your favorite animal{animal} and what is your favorite band? {band}");

Add(4, 9);
Console.WriteLine(Sub(4, 9));
Console.WriteLine(Multiply(4, 9));
Console.WriteLine(Devide(4, 9)); 

static void Add(int num1, int num2)
{
    var sum = num1 + num2;
    Console.WriteLine($"{num1} + {num2} ={sum}");
}

static int Sub(int num1, int num2)
{
    return num1 - num2;
    
}

static int Multiply(int num1, int num2)
{
    return num1 * num2;
}


static int Devide(int num1, int num2)
{
    return num1 / num2;
}






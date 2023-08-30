using System;
using System.Drawing;

string[] questions = new string[]
{
    "What is the capital of Azerbaijan?",
    "What is the capital of France?",
    "Which city serves as the capital of Japan?",
    "What is the capital of Brazil?",
    "Which city is the capital of India?",
    "What is the capital of Australia?",
    "Which city serves as the capital of Egypt?",
    "What is the capital of South Africa?",
    "Which city is the capital of Canada?",
    "What is the capital of Argentina?",
};

string[,] variants = new string[,]
{
    { "Baki", "Gence", "Istanbul", "Baki" },
    { "Paris", "London", "Berlin", "Paris" },
    { "Tokyo", "Beijing", "Seoul", "Tokyo" },
    { "Brasilia", "Rio de Janeiro", "Sao Paulo", "Brasilia" },
    { "New Delhi", "Mumbai", "Kolkata", "New Delhi" },
    { "Canberra", "Sydney", "Melbourne", "Sydney" },
    { "Cairo", "Alexandria", "Giza", "Cairo" },
    { "Pretoria", "Johannesburg", "Cape Town", "Pretoria" },
    { "Ottawa", "Vancouver", "Toronto", "Ottawa" },
    { "Buenos Aires", "Cordoba", "Rosario", "Buenos Aires" },
};



string[] var = { "a)", "b)", "c)" };
int i;

int index = 0;
int point = 0;
Random rand = new Random();

int say = 0;
int number;
int var_index;
while (index < questions.Length)
{
    int[] numbers = { 0, 1, 2 };
    Console.WriteLine("Question " + (index + 1) + ":" + questions[index]);
    Console.WriteLine();
    number = 0;
    var_index = 0;
    i = 0;

    while (true)
    {
        while (true)
        {
            number = rand.Next(0, 3);
            var_index = numbers[number];
            if (var_index == 0 || var_index == 1 || var_index == 2)
            {
                numbers[number] = -1;
                break;
            }
        }
        variants[index, var_index] = var[i++] + variants[index, var_index];

        Console.Write(variants[index, var_index] + " ");
        if (i == 3)
        {
            break;
        }

    }
    Console.WriteLine();
    Console.WriteLine();
    string answer;
    while (true)
    {

        Console.Write("Answer(a, b or c): ");
        answer = Console.ReadLine();
        if (answer == "a" || answer == "b" || answer == "c")
        {
            break;
        }
    }

    bool check = false;
    var_index = 0;
    while (var_index != 3)
    {
        if (variants[index, var_index].StartsWith(answer) && variants[index, var_index].EndsWith(variants[index, 3]))
        {
            check = true;
            break;
        }
        var_index++;
    }

    if (check)
    {
        point += 10;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Correct");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
        Console.WriteLine("----------------------------------------------------------");
        
    }
    else
    {
        if (point > 10)
        {
            point -= 10;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("False");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------");
            
        }
        else
        {
            point = 0;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("False");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------");
            
        }
    }
    index++;
    Console.WriteLine();
    Console.WriteLine();
}
Console.Clear();
Console.WriteLine("Final Point = " + point);
Console.WriteLine("Введите ваше число: ");
string input = Console.ReadLine();
    if (input.Length > 2)
        Console.WriteLine("{0}->{1}",input, input[2]);
    else
        Console.WriteLine("Число не состоит из трех символов");
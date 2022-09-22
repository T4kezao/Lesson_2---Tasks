// По хорошему тут все дни недели указать, что было более корректно, но тогда код будет конских размеров :D
int a;
Console.WriteLine("Введите нужный день недели: ");
a = Convert.ToInt32(Console.ReadLine());
    if (a == 6)
        Console.WriteLine("Это суббота!Выходной!");
    if (a == 7)
        Console.WriteLine("Это воскресенье!Выходной!");
    if (a > 7)
        Console.WriteLine("Неккоректное значение!");
    if (a < 6)
        Console.WriteLine("Это не выходной!");    
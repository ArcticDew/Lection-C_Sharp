// Вид 1
void Method1()
{
    Console.WriteLine("Автоор ...");
}
Method1();

// Вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");

void Method21 (string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21("Текст", 2);
Method21(msg: "Text", count: 1); // Если мы явно указываем на аргументы функции, то неважно в каком порядке их расположить!
Method21(count: 3, msg: "New text");

// Вид 3
// Вид 4
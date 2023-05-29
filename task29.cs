void RandArray()
{
    int[] array = new int[8];
    for (int i=0; i<8; i++)
    {
        array[i] =new Random().Next(100);
    }
    Console.Write(String.Join(',', array));
    return;
}

void UsersArray()
{
    int[] array = new int[8];
    for (int i=0; i<8; i++)
    {
        Console.WriteLine($"Введите {i}-ый элемент массива и нажмите Enter");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.Write(String.Join(",", array));
    return;
}   

Console.WriteLine("Если Вы хотите задать массив самостоятельно, нажмите 1. Если хотите задать массив автоматически, нажмите 2");
int answer = Convert.ToInt32(Console.ReadLine());
if (answer == 1)
    UsersArray();
else if (answer == 2)
    RandArray();
else {
    Console.WriteLine("Вы неверно выбрали вариант ответа, перезапустите, пожалуйста, программу");
}
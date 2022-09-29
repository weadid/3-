Console.WriteLine("1. Игра угадай число ");
Console.WriteLine("2. Таблица умножения");
Console.WriteLine("3. Вывести все делители числа");
Console.WriteLine("4. Выйти из программы");

int m = 0;
while (m <= 3)
{
    Console.WriteLine("Выберите программу, которую хотите запустить: ");
    m = Convert.ToInt32(Console.ReadLine());
    switch(m)
    {
        case 1:
        Console.WriteLine("Это игра 'Угадай число'!!!");
        Console.WriteLine("Ваша задача угадать число");


        Random random = new Random();
        int gyl = random.Next(0, 101);

        while(true)
        {
        Console.WriteLine("Введите число от 0 до 100: ");
        int number = Convert.ToInt32(Console.ReadLine());

            if (number == gyl)
            {
                Console.WriteLine("Вы выиграли!!!!!");
                    break;
            }    
        else if (number > gyl)
            {
                 Console.WriteLine("Нужно меньше");
            }
            else
            {
                Console.WriteLine("Нужно больше");
            }
        } break;
            
        case 2:
        int[,] array = new int[11, 10];

        for (int b = 1; b < array.GetLength(0); b++)
        {
            for (int a = 1; a < array.GetLength(1); a++)
            {

                int sum = b * a;
                if (b == a)
                {
                    array[b, a] = sum;
                    Console.Write(array[b, a] + "\t");
                }
                else if (b > a)
                {
                    array[b, a] = sum;
                    Console.Write(array[b, a] + "\t");
                }
                else if (b < a)
                {
                    array[b, a] = sum;
                    Console.Write(array[b, a] + "\t");
                }
            }
                Console.WriteLine("\n\n");
            }
            Console.ReadKey(true);
            break;
        case 3:
        Console.Write("Введите число ");
        int num = int.Parse(Console.ReadLine());

        int i = 1;
        while (i <= num)
        {
             i++;
             if (num % i == 0)
                 Console.WriteLine(i);
        } break;
    }         
}
while (m == 4)
{
    break;
}
while (m > 4)
{
    Console.WriteLine("Ошибка!!!! ");
    break;
}
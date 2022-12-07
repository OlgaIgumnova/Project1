//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int[] z = new int[5];
            Console.WriteLine("Введите число:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Z[{0}]=", i);
                z[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum = z[i] + sum;
            }
            Console.Write("sum = {0}", sum);
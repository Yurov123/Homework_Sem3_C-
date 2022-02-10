// Найти кубы чисел от 1 до N


            Console.WriteLine("Enter number a");
            double a = Convert.ToDouble(Console.ReadLine()); // от единицы скучно,решил пусть будет от любого числа
            Console.WriteLine("Enter number b");
            double b = Convert.ToDouble(Console.ReadLine());
            while (a <= b)
            {
                Console.WriteLine(a);
                Console.WriteLine((a * a * a));
                a++;
            }
        


// Найти расстояние между точками в пространстве 2D/3D

 
        char selection;
        Double x1, x2, y1, y2, z1, z2, distance;

        Console.WriteLine("One. Distance between two points on a plane.");
        Console.WriteLine("Two. Distance between two points in space.");
        Console.WriteLine("Select the desired item (One and Two):");

        selection = Convert.ToChar(Console.ReadLine());

        switch (selection)
        {
            case '1':
                Console.Write("Enter coordinates x1: ");
                x1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter coordinates x2: ");
                x2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter coordinates y1: ");
                y1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter coordinates y2: ");
                y2 = Convert.ToDouble(Console.ReadLine());

                distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                Console.WriteLine($"The distance between two points on the plane is {distance}");
                Console.ReadKey();
                break;
            case '2':
                Console.Write("Enter coordinates x1: ");
                x1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter coordinates x2: ");
                x2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter coordinates y1: ");
                y1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter coordinates y2: ");
                y2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter coordinates z1: ");
                z1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter coordinates z2: ");
                z2 = Convert.ToDouble(Console.ReadLine());

                distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
                Console.WriteLine($"The distance between two points in space is {distance}");
                Console.ReadKey();
                break;
            }
           

    

















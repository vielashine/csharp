{
    double y1, y2, s1, s2, ort;

    Console.WriteLine(" 1. Yazili Notu Gir :");
    y1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine(" 2. Yazili Notu Gir :");
    y2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine(" 1. Sozlu Notu Gir :");
    s1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine(" 1. Sozlu Notu Gir :");
    s2 = Convert.ToDouble(Console.ReadLine());

    ort = (y1 + y2 + s1 + s2) / 4;

    if (ort >= 50) 
    { 
        Console.WriteLine(" {0} Ortalama ile gectin" , ort); 
    }

  
    else 
    { Console.WriteLine(" {0} Ortalama ile " , ort); }

    Console.ReadKey();

 }

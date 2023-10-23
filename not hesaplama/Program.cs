{
    double v, f, ort;
    Console.WriteLine("Vize Giriniz ");

    v = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Final Giriniz ");

    f = Convert.ToDouble(Console.ReadLine());


    ort = (v * 0.4) + (f * 0.6);
    if (ort >= 70)
    {
        Console.WriteLine("Gecti");

    }
    else
    {
        Console.WriteLine("Kaldi");

        Console.ReadKey();

    }
}

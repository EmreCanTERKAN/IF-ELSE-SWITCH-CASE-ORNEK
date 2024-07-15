using System;

class Program
{
    static void Main()
    {
                  
        // switch case yapısının okunulabilirlik açısından daha kolay olduğunu düşündüğüm için switch case yapısıyla yapılmanın daha kolay olduğunu düşünüyorum . İki türlüde yapılabilir.!!

         int elmaFiyati = 2;
         int armutFiyati = 3;
         int cilekFiyati = 2;
         int muzFiyati = 3;
         int digerMeyveFiyati = 4;

     
        Console.WriteLine("Emrenin Manavına Hoşgeldiniz!");
        Console.WriteLine("Lütfen almak istediğiniz meyveyi yazınız:");
        Console.WriteLine("Elma, Armut, Çilek, Muz veya Diğer");

        Console.WriteLine();
        Console.WriteLine("Hangi Meyveyi Satın Almak İstersiniz ? (Elma/Armut/Çilek/Muz/Diger)");
        string meyve = Console.ReadLine().ToLower();

        switch (meyve)
        {
            case "elma":
                Console.WriteLine($"Elma'nın fiyatı: {elmaFiyati} TL");
                break;
            case "armut":
                Console.WriteLine($"Armut'un fiyatı: {armutFiyati} TL");
                break;
            case "cilek":
                Console.WriteLine($"Çilek'in fiyatı: {cilekFiyati} TL");
                break;
            case "muz":
                Console.WriteLine($"Muz'un fiyatı: {muzFiyati} TL");
                break;
            case "diger":
                Console.WriteLine($"Diğer meyvelerin fiyatı: {digerMeyveFiyati} TL");
                break;
            default:
                Console.WriteLine("Geçersiz meyve ismi girdiniz.");
                break;
        }

        Console.WriteLine("___________________________________________");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");

        const int elmaFiyati1 = 2;
        const int armutFiyati1 = 3;
        const int cilekFiyati1= 2;
        const int muzFiyati1 = 3;
        const int digerMeyveFiyati1 = 4;

        Console.WriteLine("Emrenin Manavına Hoşgeldiniz!");
        Console.WriteLine("Lütfen almak istediğiniz meyveyi yazınız:");
        Console.WriteLine("Elma, Armut, Çilek, Muz veya Diğer");


        Console.WriteLine("Hangi Meyveyi Satın Almak İstersiniz ? (Elma/Armut/Çilek/Muz/Diger)");
        string meyve1 = Console.ReadLine().ToUpper();


        if (meyve1 == "ELMA")
        {
            Console.WriteLine($"Elma'nın fiyatı: {elmaFiyati} TL");
        }
        else if (meyve1 == "ARMUT")
        {
            Console.WriteLine($"Armut'un fiyatı: {armutFiyati} TL");
        }
        else if (meyve1 == "CILEK")
        {
            Console.WriteLine($"Çilek'in fiyatı: {cilekFiyati} TL");
        }
        else if (meyve1 == "MUZ")
        {
            Console.WriteLine($"Muz'un fiyatı: {muzFiyati} TL");
        }
        else if (meyve1 == "DIGER")
        {
            Console.WriteLine($"Diğer meyvelerin fiyatı: {digerMeyveFiyati} TL");
        }
        else
        {
            Console.WriteLine("Geçersiz meyve ismi girdiniz.");
        }

    }
}

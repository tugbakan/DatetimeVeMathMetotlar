using System;
using System.Diagnostics;

public class Program
{
    public static void Main(string[] args)
    {
        // DateTime
        Console.WriteLine(DateTime.Now); // Günün tarihini getirir.
        Console.WriteLine(DateTime.Now.Date); // Saati ignore ederek sadece tarihi getirir.
        Console.WriteLine(DateTime.Now.Day);  //Günü getirir.
        Console.WriteLine(DateTime.Now.Month); // Ayı getirir.
        Console.WriteLine(DateTime.Now.Year); // Yılı getirir.
        Console.WriteLine(DateTime.Now.Hour); //Saati getirir.
        Console.WriteLine(DateTime.Now.Minute); //Dakikayı getirir.
        Console.WriteLine(DateTime.Now.Second); //Saniyeyi getirir.

        Console.WriteLine(DateTime.Now.DayOfWeek); //Haftanın gününü string halde getirir.
        Console.WriteLine(DateTime.Now.DayOfYear); //Yılın gününü getirir. 

        Console.WriteLine(DateTime.Now.ToLongDateString()); // Ayı ve günü string formatıyla getirir. (4 Kasım 2024 Pazartesi)
        Console.WriteLine(DateTime.Now.ToShortDateString()); // 4.11.2024

        Console.WriteLine(DateTime.Now.ToLongTimeString()); //11:59:23
        Console.WriteLine(DateTime.Now.ToShortTimeString()); //11:59

        //Now yerine herhangi bir datetime, ekrandan gelen, tablodan çektiğimiz datetime da kullanabiliriz.

        Console.WriteLine(DateTime.Now.AddDays(2)); //2 Gün ekler
        Console.WriteLine(DateTime.Now.AddHours(3)); //3 Saat ekler
        Console.WriteLine(DateTime.Now.AddSeconds(30)); // 30 saniye ekler
        Console.WriteLine(DateTime.Now.AddMonths(5)); // 5 ay ekler
        Console.WriteLine(DateTime.Now.AddYears(10)); // 10 yıl ekler
        Console.WriteLine(DateTime.Now.AddMilliseconds(50)); 

        //DateTime Format 
         Console.WriteLine(DateTime.Now.ToString("dd")); //04
         Console.WriteLine(DateTime.Now.ToString("ddd")); //Pzt
         Console.WriteLine(DateTime.Now.ToString("dddd")); //Pazartesi

         Console.WriteLine(DateTime.Now.ToString("MM")); //11
         Console.WriteLine(DateTime.Now.ToString("MMM")); //Kas
         Console.WriteLine(DateTime.Now.ToString("MM")); //Kasım

         Console.WriteLine(DateTime.Now.ToString("yy")); //24
         Console.WriteLine(DateTime.Now.ToString("yyyy")); //2024

         //Math Kütüphanesi
         Console.WriteLine("***Math Kütüphanesi***");
         
         Console.WriteLine(Math.Abs(-25)); // Mutlak değerini getirir.
         Console.WriteLine(Math.Sin(10)); // Sinüs karşılığını verir.
         Console.WriteLine(Math.Cos(10)); //Cosinüs karşılığını verir.
         Console.WriteLine(Math.Tan(10)); //Tanjant karşılığını verir.

         Console.WriteLine(Math.Ceiling(22.3));//Ondalıklı ifadelerde sayıdan büyük en küçük tam sayıyı getirir. Yukarı yuvarlar 23
         Console.WriteLine(Math.Round(22.3)); //Hangisine daha yakınsa ona yuvarlar. 22
         Console.WriteLine(Math.Round(22.7)); //Hangisine daha yakınsa ona yuvarlar. 23
         Console.WriteLine(Math.Floor(22.3)); //Sayıdan küçük en büyük tam sayıyı getirir. Aşağı yuvarlar. 22

         Console.WriteLine(Math.Max(2,6)); //İki sayının max değeri
         Console.WriteLine(Math.Min(2,6));  //iki sayının min değeri

         Console.WriteLine(Math.Pow(3,4)); // 3^4=81
         Console.WriteLine(Math.Sqrt(9)); //Karekök alır. 3
         Console.WriteLine(Math.Log(9)); //9 un e tabanındaki logaritmik karşılığı
         Console.WriteLine(Math.Exp(3)); // e^3 
         Console.WriteLine(Math.Log10(10)); //Sayının logaritma 10 tabanındaki karşılığını verir
    }
}
